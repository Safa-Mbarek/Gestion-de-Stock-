using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class BondeDAO
    {
        static SqlConnection cnx;

        public int MaxCode(string codePrefix, DateTime date)
        {
            int codeNumber = 1;
            int year = date.Year % 100;
            int month = date.Month;
            try
            {
                cnx = Connection.GetInstance();
                string query = $"SELECT ISNULL(MAX(CAST(RIGHT(num, 3) AS INT)), 0) AS MaxCodeNumber FROM Bond " +
                               $"WHERE num LIKE '{codePrefix}{year}{month:D2}%'";
                SqlCommand cmd = new SqlCommand(query, cnx);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    codeNumber = (int)result + 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnx.Close();
            }
            return codeNumber;
        }

        public List<Bonde> FindAll()
        {
            List<Bonde> bondes = new List<Bonde>();
            ProduitDAO produitDAO = new ProduitDAO();
            List<Produit> produitList = produitDAO.FindAll();
            try
            {
                cnx = Connection.GetInstance();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Bond WHERE etat = 1", cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    foreach (Produit produit in produitList)
                    {
                        if (produit.Reference.Equals(dr.GetString(5)))
                        {
                            Bonde b = new Bonde(dr.GetString(0), dr.GetDateTime(1), dr.GetString(2), dr.GetInt32(3), (float)dr.GetDouble(4),produit);
                            bondes.Add(b);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnx.Close();
            }
            return bondes;
        }

        public List<Bonde> FindArchive()
        {
            List<Bonde> bondes = new List<Bonde>();
            ProduitDAO produitDAO = new ProduitDAO();
            List<Produit> produitList = produitDAO.FindAll();
            try
            {
                cnx = Connection.GetInstance();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Bond WHERE etat = 0", cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    foreach (Produit produit in produitList)
                    {
                        if (produit.Reference.Equals(dr.GetString(5)))
                        {
                            Bonde b = new Bonde(dr.GetString(0), dr.GetDateTime(1), dr.GetString(2), dr.GetInt32(3), (float)dr.GetDouble(4), produit);
                            bondes.Add(b);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnx.Close();
            }
            return bondes;
        }

        public bool AjouterBonde(Bonde b)
        {
            try
            {
                cnx = Connection.GetInstance();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Bond VALUES (@num,@date,@type,@qte,@prix,@ref,${1})", cnx);
                cmd.Parameters.AddWithValue("@num", b.Num);
                cmd.Parameters.AddWithValue("@date", b.Date);
                cmd.Parameters.AddWithValue("@type", b.Type);
                cmd.Parameters.AddWithValue("@qte", b.Qte);
                cmd.Parameters.AddWithValue("@prix", b.Prix);
                cmd.Parameters.AddWithValue("@ref", b.Produit.Reference);
                int res = cmd.ExecuteNonQuery();
                if (res != 0) return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnx.Close();
            }
            return false;
        }

        public bool Archiver(Bonde b)
        {
            try
            {
                cnx = Connection.GetInstance();
                SqlCommand cmd = new SqlCommand($"UPDATE Bond SET etat = 0 WHERE num like @num", cnx);
                cmd.Parameters.AddWithValue("@num", b.Num);
                int res = cmd.ExecuteNonQuery();
                if (res != 0) return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnx.Close();
            }
            return false;
        }
    }
}
