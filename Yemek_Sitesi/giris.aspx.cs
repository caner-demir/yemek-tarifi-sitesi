using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class login : System.Web.UI.Page
    {
        sqlSinif conn = new sqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            string Cikis = Request.QueryString["cikis"];

            if (Cikis == "true")
            {
                Session.Abandon();
                Response.Redirect("/giris.aspx");
            }
        }

        protected void ButtonGiris_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("SELECT COUNT(1) FROM Tbl_Kullanicilar WHERE KullaniciAd=@p1 AND KullaniciSifre=@p2", conn.Baglanti());
            komut.Parameters.AddWithValue("@p1", TextBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", TextBoxSifre.Text);
            int sayi = Convert.ToInt32(komut.ExecuteScalar());

            if (sayi == 1)
            {
                Session.Timeout = 30;
                Session.Add("KullaniciAdi", TextBoxAd.Text);
                Response.Redirect("/controlyemekler.aspx");
            }
            else
            {
                Response.Redirect("/giris.aspx");
            }
        }
    }
}