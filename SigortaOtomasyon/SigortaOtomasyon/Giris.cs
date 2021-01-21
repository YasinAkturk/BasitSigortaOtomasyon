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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        private void btn_musteri_Click(object sender, EventArgs e)
        {
            MusteriBolumu mb = new MusteriBolumu();
            mb.Show();
        }

        private void btn_sigorta_Click(object sender, EventArgs e)
        {
            SigortaBolumu sb = new SigortaBolumu();
            sb.Show();
        }

        private void btn_police_Click(object sender, EventArgs e)
        {
            PoliceBolumu pb = new PoliceBolumu();
            pb.Show();
        }
    }
}
