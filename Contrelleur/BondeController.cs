using DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAO;

namespace Contrelleur
{
    public class BondeController
    {
        private List<Bonde> bondes = new List<Bonde>();
        public string GenerateCode(string prefix, DateTime date)
        {
            string codePrefix = prefix.ToUpper();
            int year = date.Year % 100;
            int month = date.Month;

            
            if (codePrefix != "BS" && codePrefix != "BE")
            {
                MessageBox.Show("Prefix incorrect!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BondeDAO dao = new BondeDAO();
            int codeNumber = dao.MaxCode(codePrefix, date);

            string codeNumberString = codeNumber.ToString().PadLeft(3, '0');
            string code = $"{codePrefix}{year}{month:D2}{codeNumberString}";

            return code;
        }

        public List<Bonde> GetBondes()
        {
            BondeDAO bondeDAO = new BondeDAO();
            bondes = bondeDAO.FindAll();
            return bondes;
        }

        public List<Bonde> GetArchive()
        {
            BondeDAO bondeDAO = new BondeDAO();
            bondes = bondeDAO.FindArchive();
            return bondes;
        }

        public bool AddBonde(Bonde b)
        {
            BondeDAO bondeDAO = new BondeDAO();
            bondes = bondeDAO.FindAll();
            if (bondes.Contains(b)) return false;
            return bondeDAO.AjouterBonde(b);
        }

        public bool ArchiverBonde(Bonde b)
        {
            BondeDAO bondeDAO = new BondeDAO();
            return bondeDAO.Archiver(b);
        }
    }
}
