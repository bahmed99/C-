using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new directeur("bahri","ahmed",15,10,1999,1000,"informatique","biat");
            p.afficher();

          
        }
        class Personne
        {
            private String nom;
            private String prenom;
            private DateTime dateDeNaissance;
            public Personne(String nom, String prenom, int j, int m, int a)
            {
                this.nom = nom;
                this.prenom = prenom;
                this.dateDeNaissance = new DateTime(a, m, j);
            }

            public virtual void afficher()
            {
                Console.Write("je suis " + prenom + " " + nom + " je suis née le " + dateDeNaissance.Day + "/" + dateDeNaissance.Month + "/" + dateDeNaissance.Year);
            }
        }

        class Employe : Personne
        {
            private float salaire;
            public Employe(String nom, String prenom, int j, int m, int a, float salaire) : base(nom, prenom, j, m, a)
            {
                this.salaire = salaire;
            }

            public override void afficher()
            {
                base.afficher();
                Console.Write("  mon salaire est " + salaire);
            }
        }   

        class chef : Employe
        {
            private String service;
            public chef(String nom, String prenom, int j, int m, int a, float salaire, String service) : base(nom, prenom, j, m, a, salaire)
            {
                this.service = service;
            }
            public override void afficher()
            {
                base.afficher();
                Console.Write("   mon service est " + service);
            }


        }
        class directeur : chef
        {
            private String societe;
            public directeur(String nom, String prenom, int j, int m, int a, float salaire, string service,String societe) : base(nom, prenom, j, m, a, salaire,service)
            {
                this.societe = societe;
            }

            public override void afficher()
            {
                base.afficher();
                Console.Write("   ma societe est " + societe);
            }
        } 
    }



}   



