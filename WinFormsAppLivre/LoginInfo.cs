using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppLivre
{
    public class LoginInfo
    {
        public static int idUser;
        public static int idVille;
        public static string username;
        public static string mdp;
        public static string email;
        public static string nom;
        public static string prenom;
        public static DateTime dateNaissance;
        public static string adresse;
        public static int porteMonnais;
        public static bool isAdmin;
        public static string connectionString = @"Data Source=192.168.111.10;Initial Catalog=PROJET;Persist Security Info=True;User ID=sa;Password=abcd4ABCD;";
    }
}
