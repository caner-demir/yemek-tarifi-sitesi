using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class OneriDetayAdmin : System.Web.UI.Page
    {
        sqlSinif conn = new sqlSinif();
        string TarifID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            TarifID = Request.QueryString["tarifid"];
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select * from Tbl_Tarifler where TarifID=@p1", conn.Baglanti());
                komut.Parameters.AddWithValue("@p1", TarifID);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    TextBoxAd.Text = oku[1].ToString();
                    TextBoxAd0.Text = oku[2].ToString();
                    TextBoxAd1.Text = oku[3].ToString();
                    TextBoxAd2.Text = oku[4].ToString();
                    TextBoxAd3.Text = oku[5].ToString();
                }
                SqlCommand komut2 = new SqlCommand("Select * from Tbl_Kategoriler", conn.Baglanti());
                SqlDataReader oku2 = komut2.ExecuteReader();
                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "KategoriID";
                DropDownList1.DataSource = oku2;
                DropDownList1.DataBind();

                conn.Baglanti().Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
    {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Yemekler (YemekAd,YemekMalzeme,YemekTarif,KategoriID,Gonderen) values (@p1,@p2,@p3,@p4,@p5)", conn.Baglanti());
            komut.Parameters.AddWithValue("@p1", TextBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", TextBoxAd0.Text);
            komut.Parameters.AddWithValue("@p3", TextBoxAd1.Text);
            komut.Parameters.AddWithValue("@p5", TextBoxAd2.Text);
            komut.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
            komut.ExecuteNonQuery();

            SqlCommand kategoriDuzenle1 = new SqlCommand("Update Tbl_Kategoriler set KategoriAdet=KategoriAdet+1 where KategoriID=@p1", conn.Baglanti());
            kategoriDuzenle1.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
            kategoriDuzenle1.ExecuteNonQuery();

            SqlCommand oneriSil = new SqlCommand("Delete from Tbl_Tarifler where TarifID=@p1", conn.Baglanti());
            oneriSil.Parameters.AddWithValue("@p1", TarifID);
            oneriSil.ExecuteNonQuery();
            conn.Baglanti().Close();
        }
    }
}
