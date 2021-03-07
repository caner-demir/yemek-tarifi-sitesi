using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class OnerilerAdmin : System.Web.UI.Page
    {
        sqlSinif conn = new sqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tbl_Tarifler", conn.Baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            DataList1.DataSource = oku;
            DataList1.DataBind();
            Panel2.Visible = true;
        }

        protected void ButtonOpen_Click(object sender, EventArgs e)
        {
            Panel2.Visible = true;
        }

        protected void ButtonClose_Click(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }
    }
}