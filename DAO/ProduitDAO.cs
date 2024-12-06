using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace DAO
{
    public class ProduitDAO
    {
        static SqlConnection cnx;

        public List<Produit> FindAll()
        {
            List<Produit> produis = new List<Produit>();
            try
            {
                cnx = Connection.GetInstance();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Produit", cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Produit p = new Produit(dr.GetString(0),dr.GetString(1),dr.GetInt32(2),(float)dr.GetDouble(3));
                    produis.Add(p);
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
            return produis;
        }

        public Produit FindById(String id)
        {
            Produit produit = null;
            try
            {
                cnx = Connection.GetInstance();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM Produit WHERE ref = @ref", cnx);
                cmd.Parameters.AddWithValue("@ref", id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    produit = new Produit(dr.GetString(0), dr.GetString(1), dr.GetInt32(2), (float)dr.GetDouble(3));
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
            return produit;
        }


        public bool AjouterProduit(Produit p)
        {
            try
            {
                cnx = Connection.GetInstance();
                SqlCommand cmd = new SqlCommand($"INSERT INTO Produit VALUES (@ref,@des,@qte,@prix)", cnx);
                cmd.Parameters.AddWithValue("@ref", p.Reference);
                cmd.Parameters.AddWithValue("@des", p.Designiation);
                cmd.Parameters.AddWithValue("@qte", p.Qte);
                cmd.Parameters.AddWithValue("@prix", p.PrixAchat);
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

        public bool UpdateProduit(Produit p)
        {
            try
            {
                cnx = Connection.GetInstance();
                SqlCommand cmd = new SqlCommand("UPDATE Produit SET qte = @qte, prixAchat = @prixAchat WHERE ref = @reference", cnx);
                cmd.Parameters.AddWithValue("@qte", p.Qte);
                cmd.Parameters.AddWithValue("@prixAchat", p.PrixAchat);
                cmd.Parameters.AddWithValue("@reference", p.Reference);
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
