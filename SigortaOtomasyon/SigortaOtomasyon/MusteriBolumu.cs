using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigortaOtomasyon
{
    public partial class MusteriBolumu : Form
    {
        public MusteriBolumu()
        {
            InitializeComponent();
        }
        private void MusteriKapa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void verigoster()
        {
            Mustericlass mc = new Mustericlass();
            DataTable table = mc.goster();
            MusteriListe.DataSource = table;
        }        
        private void MusteriBolumu_Load(object sender, EventArgs e)
        {
            lbl_menuadi.Text = "Müşteri Bölümü";
            verigoster();
        }
        public void temizle()
        {
            txt_id.Clear();
            txt_musteri.Clear();
            txt_mustel.Clear();
            txt_musadres.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Mustericlass mc = new Mustericlass();
            mc.musteriekle(txt_musteri.Text,txt_mustel.Text,txt_musadres.Text);
            verigoster();
            temizle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Mustericlass mc = new Mustericlass();
            mc.musterisil(Convert.ToInt32(txt_id.Text));
            verigoster();
            temizle();
        }

        private void MusteriListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = MusteriListe.CurrentRow.Cells[0].Value.ToString();
            txt_musteri.Text = MusteriListe.CurrentRow.Cells[1].Value.ToString();
            txt_mustel.Text = MusteriListe.CurrentRow.Cells[2].Value.ToString();
            txt_musadres.Text = MusteriListe.CurrentRow.Cells[3].Value.ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            Mustericlass mc = new Mustericlass();
            mc.musteriguncelle(txt_musteri.Text, txt_mustel.Text, txt_musadres.Text,Convert.ToInt32(txt_id.Text));
            verigoster();
            temizle();
        }

        private void txt_mustel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
