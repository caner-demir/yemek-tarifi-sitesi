using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Yemek_Sitesi
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object kullanici = Session["KullaniciAdi"];

            if (kullanici == null)
            {
                Response.Redirect("/giris.aspx");
            }
            else
            {
                Label1.Text = kullanici.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("/giris.aspx");
        }
    }
}