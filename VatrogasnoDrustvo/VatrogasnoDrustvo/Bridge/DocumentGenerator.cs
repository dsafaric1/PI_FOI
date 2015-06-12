using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            //body

            
            Paragraph orderDetails = section.AddParagraph();
            orderDetails.Format.LineSpacing = 15;
            orderDetails.Format.LineSpacingRule = LineSpacingRule.AtLeast;
            orderDetails.Format.SpaceBefore = 30;

            orderDetails.AddFormattedText("Rok isporuke: " + narudzba.RokIsporuke);
            orderDetails.AddLineBreak();
            orderDetails.AddFormattedText("Način isporuke: " + narudzba.NacinIsporuke);
            orderDetails.AddLineBreak();
            orderDetails.AddFormattedText("Sastavio: " + narudzba.Upisao.Ime + " " + narudzba.Upisao.Prezime);  
        }

        private void generateFooter() 
        {
            
        }

        private void writeToPdf() 
        {
            PdfDocumentRenderer render = new PdfDocumentRenderer(true);
            render.Document = document;
            render.RenderDocument();

            string filename = "order_VD.pdf";
            render.PdfDocument.Save(filename);
            Process.Start(filename);
        }
        public void GenerateDocument(Narudzba narudzba) 
        {
            generateHeader();
            generateBody(narudzba);
            generateFooter();
            writeToPdf();
        }
    }
}
