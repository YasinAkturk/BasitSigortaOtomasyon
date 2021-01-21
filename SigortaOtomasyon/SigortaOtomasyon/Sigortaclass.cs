using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SigortaOtomasyon
{
    class Sigortaclass
    {
        VeriTabani vt = new VeriTabani();
        public DataTable goster()
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Select * From Sigorta", vt.baglan);
                vt.okuyucu = vt.komut.ExecuteReader();
                DataTable tablo = new DataTable();
                tablo.Load(vt.okuyucu);
                vt.BaglantiKapa();
                return tablo;
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
        }

        public void sigortaekle(string tur)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("insert into Sigorta(sigorta_turu) values(@sigorta_turu)", vt.baglan);
                vt.komut.Parameters.AddWithValue("@sigorta_turu", tur);
                vt.komut.ExecuteNonQuery();
                vt.BaglantiKapa();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Kayıt İşlemi Başarılı");
            }
        }
        public void sigortasil(int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Delete from Sigorta Where sigorta_id=@sigorta_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@sigorta_id", id);
                vt.komut.ExecuteNonQuery();
                vt.BaglantiKapa();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Silme İşlemi Başarılı");
            }

        }
        public void sigortaguncelle(string tur, int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Update Sigorta set sigorta_turu=@sigorta_turu Where sigorta_id=@sigorta_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@sigorta_turu", tur);
                vt.komut.Parameters.AddWithValue("@sigorta_id", id);
                vt.komut.ExecuteNonQuery();
                vt.BaglantiKapa();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
                throw;
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Güncelleme İşlemi Başarılı");
            }
        }
    }
}
