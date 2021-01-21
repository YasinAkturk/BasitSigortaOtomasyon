using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SigortaOtomasyon
{
    public partial class PoliceBolumu : Form
    {
        public PoliceBolumu()
        {
            InitializeComponent();
        }
        public void verigoster()
        {
            Policeclass pc = new Policeclass();
            DataTable table = pc.goster();
            PoliceListe.DataSource = table;
        }
        public void temizle()
        {
            txt_id.Clear();
            baslangic.Clear();
            bitis.Clear();
            fiyat.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
        private void PoliceKapa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sigortaDBDataSet.Sigorta' table. You can move, or remove it, as needed.
            this.sigortaTableAdapter.Fill(this.sigortaDBDataSet.Sigorta);
            // TODO: This line of code loads data into the 'sigortaDBDataSet.Musteri' table. You can move, or remove it, as needed.
            this.musteriTableAdapter.Fill(this.sigortaDBDataSet.Musteri);
            lbl_menuadi.Text = "Poliçe Bölümü";
            verigoster();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Policeclass pc = new Policeclass();
            pc.policeekle(musterisec.SelectedValue.ToString(),sigortaturu.SelectedValue.ToString(),baslangic.Text,bitis.Text,Convert.ToInt32(fiyat.Text));
            verigoster();
            temizle();
        }

        private void ben_guncelle_Click(object sender, EventArgs e)
        {
            Policeclass pc = new Policeclass();
            pc.policeguncelle(musterisec.SelectedValue.ToString(), sigortaturu.SelectedValue.ToString(), baslangic.Text, bitis.Text, Convert.ToInt32(fiyat.Text), Convert.ToInt32(txt_id.Text));
            verigoster();
            temizle();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Policeclass pc = new Policeclass();
            pc.policesil(Convert.ToInt32(txt_id.Text));
            verigoster();
            temizle();
        }

        private void PoliceListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = PoliceListe.CurrentRow.Cells[0].Value.ToString();
            musterisec.SelectedValue= PoliceListe.CurrentRow.Cells[1].Value.ToString();
            sigortaturu.SelectedValue = PoliceListe.CurrentRow.Cells[2].Value.ToString();
            baslangic.Text = PoliceListe.CurrentRow.Cells[3].Value.ToString();
            bitis.Text = PoliceListe.CurrentRow.Cells[4].Value.ToString();
            fiyat.Text = PoliceListe.CurrentRow.Cells[5].Value.ToString();
        }

        private void fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
