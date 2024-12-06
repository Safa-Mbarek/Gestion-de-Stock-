using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAO;

namespace Contrelleur
{
    public class ProduitControlleur
    {
        private List<Produit> produits;
        
        public List<Produit> GetProduits()
        {
            ProduitDAO produitDAO = new ProduitDAO();
            produits = produitDAO.FindAll();
            return produits;
        }

        public Produit GetProduitById(String id)
        {
            ProduitDAO produitDAO = new ProduitDAO();
            Produit produit = produitDAO.FindById(id);
            return produit;
        }

        public bool AddProduit(Produit p)
        {
            ProduitDAO produitDAO = new ProduitDAO();
            produits = produitDAO.FindAll();
            if(produits.Contains(p)) return false;
            return produitDAO.AjouterProduit(p);
        }

        public bool UpdateProduit(Produit p, Bonde b)
        {
            if (b.Type == "BE")
            {
                p.PrixAchat = ((p.PrixAchat * p.Qte) + (b.Prix * b.Qte)) / (p.Qte + b.Qte);
                p.Qte += b.Qte;
            }
            else
            {
                if (b.Qte > p.Qte) return false;
                p.Qte -= b.Qte;
            }
            ProduitDAO produitDAO=new ProduitDAO();
            return produitDAO.UpdateProduit(p);
        }
    }
}
