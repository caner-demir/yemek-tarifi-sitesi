using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class KategoriAdminDetay : System.Web.UI.Page
    {
        sqlSinif conn = new sqlSinif();
        string sayfaID;
        protected void Page_Load(object sender, EventArgs e)
        {
            sayfaID = Request.QueryString["kategoriid"];
            if(Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select * from Tbl_Kategoriler where KategoriID=@p1", conn.Baglanti());
                komut.Parameters.AddWithValue("@p1", sayfaID);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    TextBox1.Text = oku[1].ToString();
                }
                conn.Baglanti().Close();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Kategoriler set KategoriAd=@p1 where KategoriID=@p3", conn.Baglanti());
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p3", sayfaID);
            komut.ExecuteNonQuery();
            conn.Baglanti().Close();
        }
    }
}