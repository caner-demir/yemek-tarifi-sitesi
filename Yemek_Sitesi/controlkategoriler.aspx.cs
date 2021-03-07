using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class Kategoriler : System.Web.UI.Page
    {
        sqlSinif conn = new sqlSinif();
        string sayfaID = "";
        string Islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {
                sayfaID = Request.QueryString["kategoriid"];
                Islem = Request.QueryString["islem"];
            }
            SqlCommand komut = new SqlCommand("Select * From Tbl_Kategoriler", conn.Baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            DataList1.DataSource = oku;
            DataList1.DataBind();

            if(Islem == "sil")
            {
                SqlCommand komutSil = new SqlCommand("Delete from Tbl_Kategoriler where KategoriID=@p1", conn.Baglanti());
                komutSil.Parameters.AddWithValue("@p1", sayfaID);
                komutSil.ExecuteNonQuery();
                conn.Baglanti().Close();
            }

            Panel2.Visible = true;
            Panel4.Visible = true;
        }

        protected void ButtonOpen_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void ButtonClose_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }

        protected void ButtonOpen0_Click(object sender, EventArgs e)
        {
            Panel4.Visible = true;
        }

        protected void ButtonClose0_Click(object sender, EventArgs e)
        {
            Panel4.Visible = false;
        }

        protected void ButtonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Kategoriler (KategoriAd) values (@p1)", conn.Baglanti());
            komut.Parameters.AddWithValue("@p1", TextBoxAd.Text);
            komut.ExecuteNonQuery();
            conn.Baglanti().Close();
        }
    }
}