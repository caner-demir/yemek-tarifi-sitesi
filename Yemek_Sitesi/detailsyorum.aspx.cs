using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class detailsyorum : System.Web.UI.Page
    {
        sqlSinif conn = new sqlSinif();
        string YorumID = "";
        string puanOrtalama = "";
        string YemekID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            YorumID = Request.QueryString["yorumid"];
            SqlCommand komut = new SqlCommand("Select * from Tbl_Yorumlar where YorumID=@p1", conn.Baglanti());
            komut.Parameters.AddWithValue("@p1", YorumID);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                TextBoxAd.Text = oku[1].ToString();
                TextBoxMail.Text = oku[2].ToString();
                TextBoxYorum.Text = oku[5].ToString();
                YemekID = oku[6].ToString();
            }
            conn.Baglanti().Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand kayit = new SqlCommand("Update Tbl_Yorumlar set YorumAdSoyad=@p1,YorumMail=@p2,YorumIcerik=@p3,YorumOnay=1 where YorumID=@p4", conn.Baglanti());
            kayit.Parameters.AddWithValue("@p1", TextBoxAd.Text);
            kayit.Parameters.AddWithValue("@p2", TextBoxMail.Text);
            kayit.Parameters.AddWithValue("@p3", TextBoxYorum.Text);
            kayit.Parameters.AddWithValue("@p4", YorumID);
            kayit.ExecuteNonQuery();


            SqlCommand yorumSayisiArttir = new SqlCommand("Update Tbl_Yemekler set YorumSayisi=YorumSayisi+1 where yemekId=@p1", conn.Baglanti());
            yorumSayisiArttir.Parameters.AddWithValue("@p1", YemekID);
            yorumSayisiArttir.ExecuteNonQuery();

            SqlCommand puanDuzenle = new SqlCommand("Select AVG(Cast(YemekPuan as Float)) from Tbl_Yorumlar where YemekID=@p1", conn.Baglanti());
            puanDuzenle.Parameters.AddWithValue("@p1", YemekID);
            puanOrtalama = puanDuzenle.ExecuteScalar().ToString();

            SqlCommand puanGuncelle = new SqlCommand("Update Tbl_Yemekler set YemekPuan=@p2 where yemekId=@p1", conn.Baglanti());
            puanGuncelle.Parameters.AddWithValue("@p1", YemekID);
            puanGuncelle.Parameters.AddWithValue("@p2", Math.Round(Convert.ToDouble(puanOrtalama), 1));
            puanGuncelle.ExecuteNonQuery();
            conn.Baglanti().Close();
        }
    }
}