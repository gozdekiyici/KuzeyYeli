using KuzeyYeli.orm.Entity;
using KuzeyYeli.orm.Facade;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuzeyYeli.orm.Facade
{
    public class Urunler
    {
        public static DataTable Listele()
        {
            return Tools.Listele("UrunListele");
        }

        public static bool Ekle(Urun entity)
        {
            SqlCommand komut = new SqlCommand("UrunEkle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@urunAdi", entity.UrunAdi);
            komut.Parameters.AddWithValue("@fiyat", entity.Fiyat);
            komut.Parameters.AddWithValue("@stok", entity.Stok);
            return Tools.ExecuteNonQuery(komut);
        }

        public static bool Sil(Urun entity)
        {
            SqlCommand komut = new SqlCommand("UrunSil", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@urunId", entity.UrunId);
            return Tools.ExecuteNonQuery(komut);
        }

        public static bool Guncelle(Urun entity)
        {
            SqlCommand komut = new SqlCommand("urunGuncelle", Tools.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@a", entity.UrunAdi);
            komut.Parameters.AddWithValue("@f", entity.Fiyat);
            komut.Parameters.AddWithValue("@s", entity.Stok);
            komut.Parameters.AddWithValue("@id", entity.UrunId);
            return Tools.ExecuteNonQuery (komut);


        }

    }




}
