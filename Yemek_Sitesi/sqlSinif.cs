using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Yemek_Sitesi
{
    public class sqlSinif
    {
        public SqlConnection Baglanti()
        {
            // Database'in bulunduğu dosya yolunu aşağıya yazın.
            SqlConnection baglan = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Caner Demir\Caner\yemek-tarifi-sitesi\Yemek_Sitesi\App_Data\Dbo_yemekTarif.mdf;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}