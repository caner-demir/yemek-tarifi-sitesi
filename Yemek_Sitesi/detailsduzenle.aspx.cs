using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class YemekDuzenle : System.Web.UI.Page
    {
        sqlSinif conn = new sqlSinif();
        string YemekID = "";
        static string eskiKategoriID = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            YemekID = Request.QueryString["yemekid"];
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select * from Tbl_Yemekler where YemekID=@p1", conn.Baglanti());
                komut.Parameters.AddWithValue("@p1", YemekID);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    TextBoxAd.Text = oku[1].ToString();
                    TextBoxAd0.Text = oku[2].ToString();
                    TextBoxAd1.Text = oku[3].ToString();
                    DropDownList1.SelectedValue = oku[7].ToString();
                    eskiKategoriID = oku[7].ToString();
                }
                conn.Baglanti().Close();

            }

            if (Page.IsPostBack == false)
            {
                SqlCommand komut2 = new SqlCommand("Select * from Tbl_Kategoriler", conn.Baglanti());
                SqlDataReader oku2 = komut2.ExecuteReader();
                DropDownList1.DataTextField = "KategoriAd";
                DropDownList1.DataValueField = "KategoriID";
                DropDownList1.DataSource = oku2;
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs(Server.MapPath("/Resimler/" + FileUpload1.FileName));
                SqlCommand komut = new SqlCommand("Update Tbl_Yemekler set YemekAd=@p1,YemekMalzeme=@p2,YemekTarif=@p3,KategoriID=@p4,YemekResim=@p5,Durum=0 where YemekID=@p6", conn.Baglanti());
                komut.Parameters.AddWithValue("@p1", TextBoxAd.Text);
                komut.Parameters.AddWithValue("@p2", TextBoxAd0.Text);
                komut.Parameters.AddWithValue("@p3", TextBoxAd1.Text);
                komut.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
                komut.Parameters.AddWithValue("@p5", "~/Resimler/" + FileUpload1.FileName);
                komut.Parameters.AddWithValue("@p6", YemekID);
                komut.ExecuteNonQuery();
            }
            else
            {
                SqlCommand komut = new SqlCommand("Update Tbl_Yemekler set YemekAd=@p1,YemekMalzeme=@p2,YemekTarif=@p3,KategoriID=@p4,Durum=0 where YemekID=@p6", conn.Baglanti());
                komut.Parameters.AddWithValue("@p1", TextBoxAd.Text);
                komut.Parameters.AddWithValue("@p2", TextBoxAd0.Text);
                komut.Parameters.AddWithValue("@p3", TextBoxAd1.Text);
                komut.Parameters.AddWithValue("@p4", DropDownList1.SelectedValue);
                komut.Parameters.AddWithValue("@p6", YemekID);
                komut.ExecuteNonQuery();
            }

            SqlCommand kategoriDuzenle1 = new SqlCommand("Update Tbl_Kategoriler set KategoriAdet=KategoriAdet-1 where KategoriID=@p1", conn.Baglanti());
            kategoriDuzenle1.Parameters.AddWithValue("@p1", eskiKategoriID);
            kategoriDuzenle1.ExecuteNonQuery();
            SqlCommand kategoriDuzenle2 = new SqlCommand("Update Tbl_Kategoriler set KategoriAdet=KategoriAdet+1 where KategoriID=@p1", conn.Baglanti());
            kategoriDuzenle2.Parameters.AddWithValue("@p1", DropDownList1.SelectedValue);
            kategoriDuzenle2.ExecuteNonQuery();
            conn.Baglanti().Close();

            if( CheckBox1.Checked == true)
            {
                SqlCommand komut2 = new SqlCommand("Update Tbl_Yemekler set Durum=0", conn.Baglanti());
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("Update Tbl_Yemekler set Durum=1 where YemekID=@p1", conn.Baglanti());
                komut3.Parameters.AddWithValue("@p1", YemekID);
                komut3.ExecuteNonQuery();
                conn.Baglanti().Close();
            }
        }
    }
}