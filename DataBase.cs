using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace MoyeeApp
{
    class DataBase
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=SEYDA;Initial Catalog=MOYEE;Integrated Security=True;MultipleActiveResultSets=True");
    }
}
