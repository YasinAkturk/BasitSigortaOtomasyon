using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SigortaOtomasyon
{
    class Policeclass
    {
        VeriTabani vt = new VeriTabani();
        public DataTable goster()
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Select * From Police", vt.baglan);
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

        public void policeekle(string adsoyad, string tur, string baslangic, string bitis, int fiyat)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("insert into Police(musteri,sigorta_turu,police_baslangic,police_bitis,police_fiyat) values(@musteri,@sigorta_turu,@police_baslangic,@police_bitis,@police_fiyat)", vt.baglan);
                vt.komut.Parameters.AddWithValue("@musteri", adsoyad);
                vt.komut.Parameters.AddWithValue("@sigorta_turu", tur);
                vt.komut.Parameters.AddWithValue("@police_baslangic", baslangic);
                vt.komut.Parameters.AddWithValue("@police_bitis", bitis);
                vt.komut.Parameters.AddWithValue("@police_fiyat", fiyat);
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
        public void policesil(int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Delete from Police Where police_id=@police_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@police_id", id);
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
        public void policeguncelle(string adsoyad, string tur, string baslangic, string bitis, int fiyat, int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Update Police set musteri=@musteri,sigorta_turu=@sigorta_turu,police_baslangic=@police_baslangic,police_bitis=@police_bitis,police_fiyat=@police_fiyat Where police_id=@police_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@musteri", adsoyad);
                vt.komut.Parameters.AddWithValue("@sigorta_turu", tur);
                vt.komut.Parameters.AddWithValue("@police_baslangic", baslangic);
                vt.komut.Parameters.AddWithValue("@police_bitis", bitis);
                vt.komut.Parameters.AddWithValue("@police_fiyat", fiyat);
                vt.komut.Parameters.AddWithValue("@police_id", id);
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
