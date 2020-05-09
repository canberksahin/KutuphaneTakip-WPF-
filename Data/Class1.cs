using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Class1
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=KutuphaneDb;Integrated Security=True");
    }
}
