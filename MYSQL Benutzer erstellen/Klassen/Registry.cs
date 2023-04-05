﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYSQL_Benutzer_erstellen.Klassen
{
    internal class Registry
    {
        public static string GetValue(string Schluessel)
        {
            RegistryKey _key;
            _key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"software\" + Application.CompanyName + @"\MYSQL_Benutzer");

            if (_key != null)
                return _key.GetValue(Schluessel).ToString();
            else
                return "Kein Eintrag gefunden";
        }

        public static void SetValue(string Schluessel, string Wert)
        {
            RegistryKey _key;
            _key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"software\" + Application.CompanyName + @"\MYSQL_Benutzer");

            _key.SetValue(Schluessel, Wert);
        }

        public static bool RegistryKeyExists(string path)
        {
            return Microsoft.Win32.Registry.CurrentUser.OpenSubKey(path) != null;
        }

        public static void DeleteSubKeyTree(string keyName, string Löschen)
        {
            using (RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(keyName, true))
            {
                if (key != null)
                {
                    key.DeleteSubKey(Löschen);
                }
            }
        }
    }
}
