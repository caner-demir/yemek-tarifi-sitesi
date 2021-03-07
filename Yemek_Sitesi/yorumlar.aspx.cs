using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class YemekDetay : System.Web.UI.Page
    {
        sqlSinif conn = new sqlSinif();
        string yemekId = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            yemekId = Request.QueryString["yemekid"];
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yemekler where yemekId=@p1", conn.Baglanti());
            komut.Parameters.AddWithValue("@p1", yemekId);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Label3.Text = oku[1].ToString();
                Image1.ImageUrl = oku[4].ToString();
            }
            conn.Baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Yorumlar where yemekId=@p2 and yorumOnay=1", conn.Baglanti());
            komut2.Parameters.AddWithValue("@p2", yemekId);
            SqlDataReader oku2 = komut2.ExecuteReader();
            DataList2.DataSource = oku2;
            DataList2.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Yorumlar (YorumAdSoyad,YorumMail,YorumIcerik,YemekID,YemekPuan) values (@p1,@p2,@p3,@p4,@p5)", conn.Baglanti());
            komut.Parameters.AddWithValue("@p1", TextBox1.Text);
            komut.Parameters.AddWithValue("@p2", TextBox2.Text);
            komut.Parameters.AddWithValue("@p3", TextBox3.Text);
            komut.Parameters.AddWithValue("@p4", yemekId);
            komut.Parameters.AddWithValue("@p5", DropDownList1.SelectedValue);
            komut.ExecuteNonQuery();
            conn.Baglanti().Close();

        }
    }
}