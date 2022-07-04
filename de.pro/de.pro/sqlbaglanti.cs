using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace de.pro
{
    class sqlbaglanti
    {
        public SqlConnection sqlbaglntisi()
        {
            SqlConnection baglan = new SqlConnection("Data Source=ALHIDJAZI\\SQLEXPRESS;Initial Catalog=kutuphane_projesi;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
