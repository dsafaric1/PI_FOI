using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Core;

namespace VatrogasnoDrustvo.Bridge
{

    class VDFonts
    {
        public static Font TITLE_FONT = new Font("Verdana", 14);
        public static Font BODY_FONT = new Font("Helvetica", 13);
        public static Font BODY_SMALLER_FONT = new Font("Helvetica", 6);
    }

    /// <summary>
    /// Klasa za generiranje PDF dokumenata
    /// </summary>
    class DocumentGenerator
    {
        Document document;

        public DocumentGenerator()
        {
            document = new Document();
            document.DefaultPageSetup.LeftMargin = 50;
            document.DefaultPageSetup.TopMargin = 50;
        }

        /// <summary>
        /// 
        /// </summary>
        private void generateHeader() 
        {
            //paragraf sa info vatrogasnog društva
            Section section = document.AddSection();
            Paragraph VDinfo = section.AddParagraph();
            VDinfo.Format.Font = VDFonts.BODY_SMALLER_FONT.Clone();
            VDinfo.Format.LineSpacing = 11;
            VDinfo.Format.LineSpacingRule = LineSpacingRule.AtLeast;

            VDinfo.AddFormattedText("Vatrogasno društvo d.o.o., Stjepana Radića 7, 40000 Čakovec, Hrvatska");
            VDinfo.AddLineBreak();
            VDinfo.AddFormattedText("Tel: 040/000-000, Mail: kontakt@vd.hr");
            VDinfo.AddLineBreak();
            VDinfo.AddFormattedText("MBS: 0000000, OIB: 0000000000000");
            VDinfo.AddLineBreak();
            VDinfo.AddFormattedText("Žiro račun: xxxxxxxxx-xxxxxxxxxxxx");
            VDinfo.AddLineBreak();

            VDinfo.Format.Borders.Bottom.Width = 1;
        }

        private void generateBody(Narudzba narudzba) 
        {
            Section section = document.Sections[0];

            //order title
            Paragraph orderTitle = section.AddParagraph();
            orderTitle.Format.Font = VDFonts.TITLE_FONT.Clone();
            orderTitle.Format.LineSpacing = 20;
            orderTitle.Format.LineSpacingRule = LineSpacingRule.AtLeast;
            orderTitle.Format.Alignment = ParagraphAlignment.Center;
            orderTitle.Format.SpaceBefore = 100;
            orderTitle.Format.SpaceAfter = 20;

            if (narudzba.Rbr == 0) orderTitle.AddFormattedText("NARUDŽBENICA");
            else orderTitle.AddFormattedText("NARUDŽBENICA " + narudzba.Rbr);

            Paragraph order = section.AddParagraph();
            order.Format.LineSpacing = 15;
            order.Format.LineSpacingRule = LineSpacingRule.AtLeast;
            order.Format.SpaceBefore = 30;
            order.AddFormattedText("Dobavljač: " + narudzba.Dobavljac.Naziv);
            order.AddLineBreak();

            //body
            //stavke
            Table orderTable = section.AddTable();
            orderTable.Style = "orderTable";
            orderTable.Borders.Width = 0.25;

            //table columns
            Column orderTableName = orderTable.AddColumn(Unit.FromCentimeter(7));
            orderTableName.Format.Alignment = ParagraphAlignment.Center;

            Column orderTableQuality = orderTable.AddColumn(Unit.FromCentimeter(4));
            orderTableQuality.Format.Alignment = ParagraphAlignment.Center;

            Column orderTableQuantity = orderTable.AddColumn(Unit.FromCentimeter(2.5));
            orderTableQuantity.Format.Alignment = ParagraphAlignment.Center;

            Column orderTablePrice = orderTable.AddColumn(Unit.FromCentimeter(3.5));
            orderTablePrice.Format.Alignment = ParagraphAlignment.Center;

            //table header
            Row header = orderTable.AddRow();
            header.HeadingFormat = true;
            header.Format.Alignment = ParagraphAlignment.Center;
            header.Format.Font.Bold = true;

            header.Cells[0].AddParagraph("Oprema");
            header.Cells[0].Format.Alignment = ParagraphAlignment.Center;
            header.Cells[0].VerticalAlignment = VerticalAlignment.Center;

            header.Cells[1].AddParagraph("Jedinična mjera");
            header.Cells[1].Format.Alignment = ParagraphAlignment.Center;
            header.Cells[1].VerticalAlignment = VerticalAlignment.Center;

            header.Cells[2].AddParagraph("Količina");
            header.Cells[2].Format.Alignment = ParagraphAlignment.Center;
            header.Cells[2].VerticalAlignment = VerticalAlignment.Center;

            header.Cells[3].AddParagraph("Cijena");
            header.Cells[3].Format.Alignment = ParagraphAlignment.Center;
            header.Cells[3].VerticalAlignment = VerticalAlignment.Center;

            //row data
            int i=0;
            decimal baseCostValue = 0;
            foreach(StavkaNarudzbe stavka in narudzba.Stavke) 
            {
                Row row = orderTable.AddRow();
                row.Cells[i].AddParagraph(stavka.NarucenaOprema.Naziv);
                row.Cells[i++].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[i++].AddParagraph(stavka.JedinicaMjera);
                row.Cells[i++].AddParagraph(stavka.Kolicina.ToString());
                row.Cells[i].AddParagraph(string.Format("{0:C}", stavka.Cijena));
                row.Cells[i++].Format.Alignment = ParagraphAlignment.Right;
                baseCostValue += stavka.GetUkupnaCijena();
                i=0;
            }

            //offer summary
            Row baseCost = orderTable.AddRow();
            baseCost.Format.Alignment = ParagraphAlignment.Right;
            baseCost.Cells[0].AddParagraph("Osnovica");
            baseCost.Cells[0].MergeRight = 2;
            baseCost.Borders.Top.Width = 1;
            baseCost.Cells[3].AddParagraph(string.Format("{0:C}", baseCostValue));         //nešto za izmjenu

            Row PDV = orderTable.AddRow();
            PDV.Format.Alignment = ParagraphAlignment.Right;
            PDV.Cells[0].AddParagraph("PDV (25.00%)");
            PDV.Cells[0].MergeRight = 2;
            PDV.Borders.Top.Width = 1;
            PDV.Cells[3].AddParagraph(string.Format("{0:C}", (decimal.Parse((0.25).ToString()) * baseCostValue)));

            Row totalCost = orderTable.AddRow();
            totalCost.Format.Alignment = ParagraphAlignment.Right;
            totalCost.Cells[0].AddParagraph("Ukupna cijena");
            totalCost.Cells[0].MergeRight = 2;
            totalCost.Borders.Top.Width = 1;
            totalCost.Cells[3].AddParagraph(string.Format("{0:C}", (decimal.Parse((1.25).ToString()) * baseCostValue)));      

            //donji dio narudžbe
            Paragraph orderDetails = section.AddParagraph();
            orderDetails.Format.LineSpacing = 15;
            orderDetails.Format.LineSpacingRule = LineSpacingRule.AtLeast;
            orderDetails.Format.SpaceBefore = 30;

            orderDetails.AddFormattedText("Rok isporuke: " + narudzba.RokIsporuke);
            orderDetails.AddLineBreak();
            orderDetails.AddFormattedText("Način isporuke: " + narudzba.NacinIsporuke);
            orderDetails.AddLineBreak();

            if (narudzba.Upisao == null) narudzba.Upisao = VatrogasnoDrustvo.Forme.GlavnaForma.TrenutniVatrogasac;
            orderDetails.AddFormattedText("Sastavio: " + narudzba.Upisao.Ime + " " + narudzba.Upisao.Prezime);
        }

        private void generateFooter() 
        {
            
        }

        private bool writeToPdf() 
        {
            PdfDocumentRenderer render = new PdfDocumentRenderer(true);
            render.Document = document;
            render.RenderDocument();

            string filename = "order_VD.pdf";
            try
            {
                render.PdfDocument.Save(filename);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Zatvorite otvorenu PDF datoteku!");
                return false;
            }
        }
        public bool GenerateDocument(Narudzba narudzba) 
        {
            generateHeader();
            generateBody(narudzba);
            generateFooter();
            return writeToPdf();
        }
    }
}
