using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace SigortaOtomasyon
{
    class Mustericlass
    {
        VeriTabani vt = new VeriTabani();
        public DataTable goster()
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Select * From Musteri", vt.baglan);
                vt.okuyucu = vt.komut.ExecuteReader();
                DataTable tablo = new DataTable();
                tablo.Load(vt.okuyucu);
                vt.BaglantiKapa();
                return tablo;
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(""+hata);
                throw;
            }
        }

        public void musteriekle(string adsoyad, string tel, string adres)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("insert into Musteri(musteri_adsoyad,musteri_tel,musteri_adres) values(@musteri_adsoyad,@musteri_tel,@musteri_adres)", vt.baglan);
                vt.komut.Parameters.AddWithValue("@musteri_adsoyad",adsoyad);
                vt.komut.Parameters.AddWithValue("@musteri_tel", tel);
                vt.komut.Parameters.AddWithValue("@musteri_adres", adres);
                vt.komut.ExecuteNonQuery();
                vt.BaglantiKapa();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(""+hata);
                throw;
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Kayıt İşlemi Başarılı");
            }
        }
        public void musterisil(int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Delete from Musteri Where musteri_id=@musteri_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@musteri_id", id);
                vt.komut.ExecuteNonQuery();
                vt.BaglantiKapa();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(""+hata);
                throw;
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Silme İşlemi Başarılı");
            }
            
        }
        public void musteriguncelle(string adsoyad, string tel, string adres, int id)
        {
            try
            {
                vt.BaglantiAc();
                vt.komut = new SqlCommand("Update Musteri set musteri_adsoyad=@musteri_adsoyad,musteri_tel=@musteri_tel,musteri_adres=@musteri_adres Where musteri_id=@musteri_id", vt.baglan);
                vt.komut.Parameters.AddWithValue("@musteri_adsoyad", adsoyad);
                vt.komut.Parameters.AddWithValue("@musteri_tel", tel);
                vt.komut.Parameters.AddWithValue("@musteri_adres", adres);
                vt.komut.Parameters.AddWithValue("@musteri_id", id);
                vt.komut.ExecuteNonQuery();
                vt.BaglantiKapa();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show(""+hata);
                throw;
            }
            finally
            {
                System.Windows.Forms.MessageBox.Show("Güncelleme İşlemi Başarılı");
            }
        }
    }
}
