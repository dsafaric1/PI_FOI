﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using VatrogasnoDrustvo.Bridge;
using VatrogasnoDrustvo.Core;
using VatrogasnoDrustvo.Forme;

namespace VatrogasnoDrustvo.Forms
{
    public partial class PodaciNarudzbe : Form
    {
        private Narudzba narudzba;
        List<StavkaNarudzbe> stavke;
        public PodaciNarudzbe()
        {
            InitializeComponent();
            btnSalji.Text = "Kreiraj narudžbu";
            FillSelect();

        }

        private void FillSelect()
        {
            try
            {
                cmbDobavljac.DataSource = JsonConvert.DeserializeObject<List<Dobavljac>>(new Sender().Receive
                    ("https://testerinho.com/vatrogasci/gettable.php?table=Dobavljači"));
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška kod kontaktiranja servera! " + e.ToString());
            }
        }

        public PodaciNarudzbe(DataGridViewRow row)
        {
            InitializeComponent();
            narudzba = new Narudzba(row);

            //punjenje dgv podacima
            /*try
            {
                dgvStavke.DataSource = JsonConvert.DeserializeObject<List<object>>(new Sender().Receive
                    ("https://testerinho.com/vatrogasci/gettable.php?table=StavkeNarudžbe&narudzba=" + narudzba.Rbr));
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška kod kontaktiranja servera! " + e.ToString());
            }*/

            dgvStavke.DataSource = narudzba.Stavke;

            //dodavanje u textboxove 
            txtNacinIsporuke.Text = narudzba.NacinIsporuke;
            dtpRokIsporuke.Value = narudzba.RokIsporuke;
            cmbDobavljac.Text = narudzba.Dobavljac.Naziv.ToString();
            btnSalji.Visible = false;
            btnDodajStavke.Visible = false;
            lblPodaciNarudzbeNaslov.Visible = false;
            txtNacinIsporuke.ReadOnly = true;
            dtpRokIsporuke.Enabled = false;
        }

        private void btnDodajStavke_Click(object sender, EventArgs e)
        {
            PodaciStavkeNarudzbe PodaciStavkeNarudzbe = new PodaciStavkeNarudzbe();
            PodaciStavkeNarudzbe.ShowDialog();
            stavke = PodaciStavkeNarudzbe.SendChecked();
            dgvStavke.DataSource = stavke;
        }

        private void btnSalji_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow Row in dgvStavke.Rows){
                //validacija za jedinicnu mjeru
                if(new Regex("@/[w]").Match(Row.Cells[1].Value.ToString()).Success)
                {
                   MessageBox.Show("Jedinicna mjera nije dobro unešena za " + Row.Cells[0].Value.ToString()); 
                   return;
                }
                //validacija za kolicinu
                if(new Regex("@/[d]").Match(Row.Cells[2].Value.ToString()).Success){
                   MessageBox.Show("Kolicina nije dobro unešena za " + Row.Cells[0].Value.ToString()); 
                   return;
                }
                //validacija za cijenu
                if(new Regex("@/[d]").Match(Row.Cells[3].Value.ToString()).Success){
                   MessageBox.Show("Cijena nije dobro unešena za " + Row.Cells[0].Value.ToString()); 
                   return;
                }

            }
            //ako je sve ispunjeno 
            if (txtNacinIsporuke.Text != "")
            {
                createNarudzbu();
            }
        }

        private Narudzba getData(Narudzba narudzba)
        {
            //punjenje podacima iz forme
            if (narudzba == null) narudzba = new Narudzba();
            narudzba.NacinIsporuke = txtNacinIsporuke.Text;
            narudzba.RokIsporuke = dtpRokIsporuke.Value;
            narudzba.Dobavljac = cmbDobavljac.SelectedValue as Dobavljac;
            foreach (DataGridViewRow Row in dgvStavke.Rows)
            {
                //preuzimanje podataka iz dgv i spremanje u listu stavke
                narudzba.Stavke.Add(new StavkaNarudzbe
                {
                    Cijena = int.Parse(Row.Cells[3].Value.ToString()),
                    Kolicina = int.Parse(Row.Cells[2].Value.ToString()),
                    JedinicaMjera = Row.Cells[1].Value.ToString(),
                    NarucenaOprema = new Oprema { Naziv = Row.Cells[0].Value.ToString() }
                });

            }
            return narudzba;
        }

        private void createNarudzbu()
        {
            //dohvacanje podataka iz forme i kreiranje narudzbe
            narudzba = getData(narudzba);
            try
            {
                var response = JsonConvert.DeserializeObject<Dictionary<string, object>>
                    (new Sender().Send(narudzba, "https://testerinho.com/vatrogasci/insertNarudzba.php", GlavnaForma.TrenutniVatrogasac));

                if (bool.Parse(response["passed"].ToString()))
                {
                    MessageBox.Show("Uneseno je nova narudzba!");
                }
                else
                {
                    MessageBox.Show(response["text"].ToString());
                }
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Pogreška u kontaktiranju servera " + e.ToString());
            }
        }


    }
}
