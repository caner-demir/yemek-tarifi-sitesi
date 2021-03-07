using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class Kullanici : System.Web.UI.MasterPage
    {
        sqlSinif conn = new sqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_Kategoriler", conn.Baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            DataList1.DataSource = oku;
            DataList1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("anasayfa.aspx?arama=" + TextBoxSearch.Text);
        }
    }
}