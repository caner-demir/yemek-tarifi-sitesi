using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class AnaSayfa : System.Web.UI.Page
    {
        sqlSinif conn = new sqlSinif();

        string KategoriID = "";
        string Arama = "";
        string GununYemegi = "";
        string Gonderen = "";

        public string SayfaNo = "";
        public decimal ToplamSayfa;
        int gonderi_sayisi = 4;

        protected void Page_Load(object sender, EventArgs e)
        {
            KategoriID = Request.QueryString["kategoriid"];
            Arama = Request.QueryString["arama"];
            GununYemegi = Request.QueryString["gununyemegi"];
            Gonderen = Request.QueryString["gonderen"];
            SayfaNo = Request.QueryString["sayfa"];
            

            if (KategoriID == null && Arama == null && GununYemegi == null && Gonderen == null)
            {
                SqlCommand komut_sonuclar = new SqlCommand("SELECT COUNT(*) FROM Tbl_Yemekler", conn.Baglanti());
                decimal sonuclar = Convert.ToDecimal(komut_sonuclar.ExecuteScalar());
                ToplamSayfa = Math.Ceiling(sonuclar / gonderi_sayisi);

                if ( SayfaNo == null)
                {
                    SayfaNo = "1";
                }
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yemekler ORDER BY YemekTarih DESC OFFSET @p1 ROWS FETCH NEXT @p2 ROWS ONLY", conn.Baglanti());
                komut.Parameters.AddWithValue("@p1", gonderi_sayisi * (Convert.ToInt32(SayfaNo) - 1));
                komut.Parameters.AddWithValue("@p2", gonderi_sayisi);
                SqlDataReader oku = komut.ExecuteReader();
                DataList2.DataSource = oku;
                DataList2.DataBind();

                string url_anasayfa = "anasayfa.aspx?sayfa=";

                HyperLink1.NavigateUrl = url_anasayfa + (Convert.ToInt32(SayfaNo) + 1);
                HyperLink2.NavigateUrl = url_anasayfa + (Convert.ToInt32(SayfaNo) - 1);
            }
            else if (KategoriID != null)
            {
                SqlCommand komut_sonuclar = new SqlCommand("SELECT COUNT(*) FROM Tbl_Yemekler WHERE KategoriID=@p1", conn.Baglanti());
                komut_sonuclar.Parameters.AddWithValue("@p1", KategoriID);
                decimal sonuclar = Convert.ToDecimal(komut_sonuclar.ExecuteScalar());
                ToplamSayfa = Math.Ceiling(sonuclar / gonderi_sayisi);

                if (SayfaNo == null)
                {
                    SayfaNo = "1";
                }
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yemekler WHERE KategoriID=@p1 ORDER BY YemekTarih DESC OFFSET @p2 ROWS FETCH NEXT @p3 ROWS ONLY", conn.Baglanti());
                komut.Parameters.AddWithValue("@p1", KategoriID);
                komut.Parameters.AddWithValue("@p2", gonderi_sayisi * (Convert.ToInt32(SayfaNo) - 1));
                komut.Parameters.AddWithValue("@p3", gonderi_sayisi);
                SqlDataReader oku = komut.ExecuteReader();
                DataList2.DataSource = oku;
                DataList2.DataBind();

                string url_kategori = "anasayfa.aspx?kategoriid=" + KategoriID + "&" + "sayfa=";

                HyperLink1.NavigateUrl = url_kategori + (Convert.ToInt32(SayfaNo) + 1);
                HyperLink2.NavigateUrl = url_kategori + (Convert.ToInt32(SayfaNo) - 1);
            }
            else if (GununYemegi == "true")
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yemekler WHERE Durum=1", conn.Baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                DataList2.DataSource = oku;
                DataList2.DataBind();
            }
            else if (Arama != null)
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yemekler WHERE YemekAd LIKE '%" + Arama + "%'", conn.Baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                DataList2.DataSource = oku;
                DataList2.DataBind();
            }
            else if (Gonderen != null)
            {
                SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Yemekler WHERE Gonderen=@p1", conn.Baglanti());
                komut.Parameters.AddWithValue("@p1", Gonderen);
                SqlDataReader oku = komut.ExecuteReader();
                DataList2.DataSource = oku;
                DataList2.DataBind();
            }
        }
    }
}