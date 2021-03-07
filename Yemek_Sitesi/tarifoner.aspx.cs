using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public partial class TarifOner : System.Web.UI.Page
    {
        sqlSinif conn = new sqlSinif();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonTarifOner_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Tarifler (TarifAd,TarifMalzeme,TarifYapilis,TarifSahip,TarifSahipMail) values (@t1,@t2,@t3,@t4,@t5)", conn.Baglanti());
            komut.Parameters.AddWithValue("@t1", TextBoxTarifAd.Text);
            komut.Parameters.AddWithValue("@t2", TextBoxMalzemeler.Text);
            komut.Parameters.AddWithValue("@t3", TextBoxYapilis.Text);
            komut.Parameters.AddWithValue("@t4", TextBoxTarifOneren.Text);
            komut.Parameters.AddWithValue("@t5", TextBoxMailAdresi.Text);
            komut.ExecuteNonQuery();
            conn.Baglanti().Close();

        }
    }
}