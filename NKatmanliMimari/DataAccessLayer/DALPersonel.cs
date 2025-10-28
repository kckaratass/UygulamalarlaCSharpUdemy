using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework;
using EntityLayer;
using System.Data.SqlClient;    
namespace DataAccessLayer
{
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            var komut1 = new SqlCommand("Select * from TBLBILGI", Baglanti.bgl);

            if (komut1.Connection.State != System.Data.ConnectionState.Open)
            {
                komut1.Connection.Open();
            }

            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString()); 
                ent.Ad = dr["AD"].ToString();
                ent.Soyad = dr["SOYAD"].ToString();
                ent.Sehir = dr["SEHIR"].ToString();
                ent.Gorev = dr["GOREV"].ToString();
                ent.Maas = short.Parse(dr["MAAS"].ToString());
                degerler.Add(ent);
            } 
            dr.Close();
            return degerler;

        }

        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLBILGI (AD,SOYAD,SEHIR,GOREV,MAAS) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            
            if (komut2.Connection.State != System.Data.ConnectionState.Open)
            {
                komut2.Connection.Open();
            }

            komut2.Parameters.AddWithValue("@p1", p.Ad);
            komut2.Parameters.AddWithValue("@p2", p.Soyad);
            komut2.Parameters.AddWithValue("@p3", p.Sehir);
            komut2.Parameters.AddWithValue("@p4", p.Gorev);
            komut2.Parameters.AddWithValue("@p5", p.Maas);

            return komut2.ExecuteNonQuery();
        }
    }
}
