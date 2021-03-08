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



// class personne
// {
//     private String nom;
//     private int age;

//     public String Prenom { get; set; }

//     public String Nom
//     {
//         get { return nom; }
//         set { nom = value; }

//     }
//     public int Age
//     {
//         get { return age; }
//         set { age = value; }

//     }
//     public virtual void sePresenter()
//     {
//         Console.WriteLine("je suis" + " " + nom + " " + "et j'ai " + age);

//     }

//     public personne(String nom, String prenom, int age)
//     {
//         this.nom = nom;
//         this.Prenom = prenom;
//         this.age = age;
//     }
// }


// class Etudiant : personne
// {
//     public int Note { get; set; }
//     public Etudiant(String nom ,String prenom ,int note,int age):base(nom,prenom,age)
//     {
//         this.Note =note ; 
//     }
//     public override void sePresenter(){
//         base.sePresenter() ;
//         Console.WriteLine("mon note est " +Note);
//     }

// }


//  personne p = new personne("ahmed", "bahri", 9);

//          p.sePresenter();

//         Etudiant e = new Etudiant("ahmed","bahri",5,6);
//         e.sePresenter(); 

//         personne [] table = new personne[2]; 

//         table[0]= e; 
//         table[1]=p; 
//         personne p2 = new Etudiant("na","en",18,9);        

