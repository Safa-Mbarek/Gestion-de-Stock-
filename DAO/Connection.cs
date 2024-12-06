using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class Connection
    {
        static string chaneCnx = @"Data Source=DESKTOP-PLI0O4R\SQLEXPRESS; Database=Gestion du Stock; Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaneCnx);

        public static SqlConnection GetInstance()
        {
            try
            {
                if (cnx.State != System.Data.ConnectionState.Open)
                {
                    cnx.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cnx;
        }
    }
}
