using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class Yemekler : System.Web.UI.Page
    {
        sqlSinif conn = new sqlSinif();
        static string YemekID = "";
        string Islem = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                YemekID = Request.QueryString["yemekid"];
                Islem = Request.QueryString["islem"];
            }
            SqlCommand komut = new SqlCommand("Select * from Tbl_Yemekler", conn.Baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            DataList1.DataSource = oku;
            DataList1.DataBind();

            Panel2.Visible = true;
            Panel4.Visible = true;

            if( Page.IsPostBack == false)
            {
                SqlCommand komut2 = new SqlCommand("Select * from Tbl_Kategoriler", conn.Baglanti());
                SqlDataReader oku2 = komut2.ExecuteReader();
                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "KategoriID";
                DropDownList1.DataSource = oku2;
                DropDownList1.DataBind();
            }

            if (Islem == "sil")
            {
                SqlCommand kategoriDuzenle1 = new SqlCommand("Update Tbl_Kategoriler set KategoriAdet=KategoriAdet-1 where KategoriID = (Select KategoriID from Tbl_Yemekler where YemekID=@p1)", conn.Baglanti());
                kategoriDuzenle1.Parameters.AddWithValue("@p1", YemekID);
                kategoriDuzenle1.ExecuteNonQuery();

                SqlCommand komutSil = new SqlCommand("Delete from Tbl_Yemekler where YemekID=@p1", conn.Baglanti());
                komutSil.Parameters.AddWithValue("@p1", YemekID);
                komutSil.ExecuteNonQuery();
                conn.Baglanti().Close();
            }
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
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("/Resimler/" + FileUpload1.FileName));
                SqlCommand komut = new SqlCommand("Insert into Tbl_Yemekler (YemekAd,YemekMalzeme,YemekTarif,KategoriID,Gonderen,YemekResim) values (@p1,@p2,@p3,@p4,'Admin',@p5)", conn.Baglanti());
                komut.Parameters.AddWithValue("@p1", TextBoxAd.Text);
                komut.Parameters.AddWithValue("@p2", TextBoxAd0.Text);
                komut.Parameters.AddWithValue("@p3", TextBoxAd1.Text);
                komut.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
                komut.Parameters.AddWithValue("@p5", "~/Resimler/" + FileUpload1.FileName);
                komut.ExecuteNonQuery();
            }
            else
            {
                SqlCommand komut = new SqlCommand("Insert into Tbl_Yemekler (YemekAd,YemekMalzeme,YemekTarif,KategoriID,Gonderen) values (@p1,@p2,@p3,@p4,'Admin')", conn.Baglanti());
                komut.Parameters.AddWithValue("@p1", TextBoxAd.Text);
                komut.Parameters.AddWithValue("@p2", TextBoxAd0.Text);
                komut.Parameters.AddWithValue("@p3", TextBoxAd1.Text);
                komut.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
                komut.ExecuteNonQuery();
            }

            SqlCommand komut1 = new SqlCommand("Update Tbl_Kategoriler set KategoriAdet=KategoriAdet+1 where KategoriID=@p1", conn.Baglanti());
            komut1.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
            komut1.ExecuteNonQuery();
            conn.Baglanti().Close();
        }
    }
}