using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYSQL_Benutzer_erstellen.Klassen
{
    internal class MYSQL
    {
        /// <summary>
        /// Erstellt einen aktuellen MYSQL Connectionstring
        /// </summary>
        /// <returns>Gibt einen aktuellen Connection string zurück.</returns>
        public static string Connectionstring()
        {
            string Server = Registry.GetValue("IP-Adresse");
            string Benutzername = Registry.GetValue("Benutzername");
            string Passwort = Crypto_137.Text_Decrypt(Registry.GetValue("Passwort"), string.Empty);
            string Port = Registry.GetValue("Port");

            string ConnectionString = string.Format("server={0};user id={1};password={2};port={3};SslMode=Preferred", Server, Benutzername, Passwort, Port);

            return ConnectionString;
        }
    }
}
