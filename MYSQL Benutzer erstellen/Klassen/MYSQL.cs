using MySqlConnector;
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

            string ConnectionString = string.Format("server={0};user id={1};password={2};port={3};SslMode=Preferred;charset=utf8;IgnoreCommandTransaction=true", Server, Benutzername, Passwort, Port);

            return ConnectionString;
        }

        /// <summary>
        /// Um einen SQL-Befehl auszuführen der keine Art von Rückgabe benötigt.
        /// </summary>
        /// <param name="SQL_Befehl">Der SQL Befehl der ausgeführt werden soll.</param>
        /// <returns>Gibt ein true oder false zurück, ob der Befehl erfolgreich war oder nicht.</returns>
        public static bool Nur_Befehl(string SQL_Befehl)
        {
            using (MySqlConnection connection = new(Connectionstring()))
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        MySqlCommand insertCommand = new(SQL_Befehl, connection);
                        insertCommand.ExecuteNonQuery();

                        transaction.Commit();
                        connection.Close();
                        connection.Dispose();
                        transaction.Dispose();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(new Form { TopMost = true }, ex.Message.ToString());
                        transaction.Rollback();
                        connection.Close();
                        return false;
                    }
                }
            }
        }

        /// <summary>
        /// Erzeugt eine Liste mit Daten aus der Datenbank zum vereinfachten Darstellen von Einträgen.
        /// </summary>
        /// <param name="SQL_Befehl">Der SQL Befehl der genutzt werden soll.</param>
        /// <param name="Anzahl_spalten">Die Anzahl der Spalten die abgefragt werden sollen. Maximal 14.</param>
        /// <returns>Gibt eine Liste mit den gewünschten Daten zurück.</returns>
        public static List<string> Auflistung_Einträge(string SQL_Befehl, int Anzahl_spalten)
        {
            List<string> list = new();

            using (MySqlConnection connection = new(Connectionstring()))
            {
                connection.Open();

                using (MySqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        MySqlCommand insertCommand = new(SQL_Befehl, connection);
                        insertCommand.ExecuteNonQuery();

                        using (IDataReader reader = insertCommand.ExecuteReader())
                        {
                            while (reader.Read() != false)
                            {
                                int i = 0;
                                while (i < Anzahl_spalten)
                                {
                                    list.Add(reader[i].ToString());
                                    i++;
                                }
                            }
                        }

                        transaction.Commit();
                        connection.Close();
                        connection.Dispose();
                        transaction.Dispose();
                        return list;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(new Form { TopMost = true }, ex.Message.ToString());
                        transaction.Rollback();
                        connection.Close();
                        list.Clear();
                        list.Add("# Leer #");
                        return list;
                    }
                }
            }
        }
    }
}
