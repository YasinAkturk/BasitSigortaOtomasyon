using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SigortaOtomasyon
{
    class VeriTabani
    {
        public SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=SigortaDB;Integrated Security=True");
        public SqlCommand komut;
        public SqlDataAdapter adapter;
        public SqlDataReader okuyucu;
        public DataTable dataset;

        public void BaglantiAc()
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(""+hata);
                throw;
            }
        }

        public void BaglantiKapa()
        {
            try
            {
                if (baglan.State == ConnectionState.Open)
                {
                    baglan.Close();
                }
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
        }
    }
}
