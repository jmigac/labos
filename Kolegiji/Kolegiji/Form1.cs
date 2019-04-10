using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolegiji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnUnosKolegija_Click(object sender, EventArgs e)
        {
            if (TxtNazivKolegija.Text.Length > 0)
            {
                Kolegij noviKolegij = new Kolegij(TxtNazivKolegija.Text);
                TxtNazivKolegija.Text = "";
                TxtNazivKolegija.Focus();
                
            }
            else
            {
                MessageBox.Show("Unesite neki naziv kolegija!");
            }
        }

        private void IspisOcjena_Tick(object sender, EventArgs e)
        {
            ListaPopisSvihKolegija.Items.Clear();
            string ispis = "";
            foreach (var kolegij in Kolegij.SviKolegiji)
            {
                ispis += kolegij.NazivKolegija+":";
                foreach (var ocjena in kolegij.OcjeneKolegija)
                {
                    ispis += ocjena+ ",";
                }
                ListaPopisSvihKolegija.Items.Add(ispis);
                ispis = "";
            }
        }

        private void BtnUnosOcjene_Click(object sender, EventArgs e)
        {
            if(TxtDodjelaNaziv.Text.Length>0 && TxtOcjena.Text.Length == 1)
            {
                Kolegij kolegijUnos = Kolegij.NadiKolegij(TxtDodjelaNaziv.Text);
                if(kolegijUnos != null)
                {
                    kolegijUnos.OcjeneKolegija.Add(int.Parse(TxtOcjena.Text));
                    kolegijUnos.Prosjek = (double)kolegijUnos.OcjeneKolegija.Sum() / (double)kolegijUnos.OcjeneKolegija.Count;
                    Kolegij najbolji = Kolegij.NajboljiKolegij();
                    Kolegij najlosiji = Kolegij.NajlosijiKolegij();
                    LabelNajbolji.Text = String.Format($"Najbolji kolegij je:{najbolji.NazivKolegija} - {najbolji.Prosjek:0.00}");
                    LabelNajlosiji.Text = String.Format($"Najlošiji kolegij je:{najlosiji.NazivKolegija} - {najlosiji.Prosjek:0.00}");
                }
                else
                {
                    MessageBox.Show("Ne postoji kolegij!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtNazivKolegija.Focus();
        }
    }
}
