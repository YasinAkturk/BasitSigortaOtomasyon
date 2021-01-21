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
    public partial class SigortaBolumu : Form
    {
        public SigortaBolumu()
        {
            InitializeComponent();
        }
        public void verigoster()
        {
            Sigortaclass sc = new Sigortaclass();
            DataTable table = sc.goster();
            SigortaListe.DataSource = table;
        }
        public void temizle()
        {
            txt_id.Clear();
            txt_sigturu.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SigortaKapa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SigortaBolumu_Load(object sender, EventArgs e)
        {
            lbl_menuadi.Text = "Sigorta Bölümü";
            verigoster();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Sigortaclass sc = new Sigortaclass();
            sc.sigortaekle(txt_sigturu.Text);
            verigoster();
            temizle();
        }

        private void ben_guncelle_Click(object sender, EventArgs e)
        {
            Sigortaclass sc = new Sigortaclass();
            sc.sigortaguncelle(txt_sigturu.Text, Convert.ToInt32(txt_id.Text)); ;
            verigoster();
            temizle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Sigortaclass sc = new Sigortaclass();
            sc.sigortasil(Convert.ToInt32(txt_id.Text));
            verigoster();
            temizle();
        }

        private void SigortaListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = SigortaListe.CurrentRow.Cells[0].Value.ToString();
            txt_sigturu.Text = SigortaListe.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
