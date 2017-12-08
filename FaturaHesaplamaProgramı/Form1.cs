using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaHesaplamaProgramı
{
    public partial class Form1 : Form
    {
        Fatura fatura = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fatura = new Fatura();
            cmbAbone.SelectedIndex = 0;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            bool girisDogruMu = true;
            try
            {
                fatura.GunduzTuketim = double.Parse(txtTuketimGunduz.Text);
            }
            catch (Exception)
            {
                girisDogruMu = false;
                MessageBox.Show("Gündüz tüketim olarak sayısal bir veri girilmelidir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                fatura.PuantTuketim = double.Parse(txtTuketimPuant.Text);
            }
            catch (Exception)
            {
                girisDogruMu = false;
                MessageBox.Show("Puant tüketim olarak sayısal bir veri girilmelidir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                fatura.GeceTuketim = double.Parse(txtTuketimGece.Text);
            }
            catch (Exception)
            {
                girisDogruMu = false;
                MessageBox.Show("Gece tüketim olarak sayısal bir veri girilmelidir.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (girisDogruMu)
            {
                fatura.Hesapla();
               lblToplamTutar.Text = fatura.FaturaTutar.ToString("0.0");
            }
            else
            {
                lblToplamTutar.Text = "0";
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTuketimGunduz.Clear();
            txtTuketimPuant.Clear();
            txtTuketimGece.Clear();
            lblToplamTutar.Text = String.Empty;

        }
        void TexBoxTemizleForm1(System.Windows.Forms.Control.ControlCollection textbox)
        {
            foreach (System.Windows.Forms.Control item in textbox)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)item;
                    txt.Text = string.Empty;
                }
            }
        }

        private void btnHesaplama_Click(object sender, EventArgs e)
        {
            int ilkDeger = 0;
            int sonDeger = 0;
            int tuketim = 0;
            double tutar = 0.0;
            double atikSu = 0.0;
            double toplam = 0.0;
            ilkDeger = Convert.ToInt32(txtİlkEndeks.Text);
            sonDeger = Convert.ToInt32(txtSonEndeks.Text);
            tuketim = sonDeger - ilkDeger;
            txtTuketim.Text = Convert.ToString(tuketim) + " m3";

            switch (cmbAbone.SelectedIndex)
            {
                case 1:
                    tutar = tuketim * 0.91827;
                    break;
                case 2:
                    tutar = tuketim * 1.1827;
                    break;
            }
            txtTutar.Text = tutar.ToString() + " TL";
            atikSu = tutar / 2.0;
            toplam = tutar + atikSu;
            txtAtik.Text = atikSu.ToString() + " TL";
            txtToplamDeger.Text = toplam.ToString() + " TL";
        }

        private void btnTemizleme_Click(object sender, EventArgs e)
        {
            TexBoxTemizleForm(this.groupBox1.Controls);
            TexBoxTemizleForm(this.groupBox2.Controls);
        }
        void TexBoxTemizleForm(System.Windows.Forms.Control.ControlCollection textbox)
        {
            foreach (System.Windows.Forms.Control item in textbox)
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox txt = (System.Windows.Forms.TextBox)item;
                    txt.Text = string.Empty;
                }
            }
        }

        private void txtİlkEndeks_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtİlkEndeks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSonEndeks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

