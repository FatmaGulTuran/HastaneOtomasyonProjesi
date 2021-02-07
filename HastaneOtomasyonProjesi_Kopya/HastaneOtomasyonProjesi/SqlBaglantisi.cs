using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneOtomasyonProjesi
{
    class SqlBaglantisi
    {
        public String Adres = System.IO.File.ReadAllText(@"C:\adresim.txt");
        public SqlConnection baglanti()
        {

            SqlConnection baglan = new SqlConnection(Adres);
            baglan.Open();
            return baglan;

        }
    }
}
