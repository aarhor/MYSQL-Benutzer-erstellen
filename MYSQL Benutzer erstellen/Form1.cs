using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Web;
using MYSQL_Benutzer_erstellen.Klassen;
using System.IO;

namespace MYSQL_Benuter_erstellen
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        public string Berechtigungen = "";
        bool Grant_Option = false;

        public string Set_Checkbox(string Checkbox_Name, bool Check)
        {
            string Berechtigung_set_checkbox = Berechtigungen;
            if (Checkbox_Name == "chkBox_Recht_ALTER")
            {
                if (chkBox_Recht_ALTER_ROUTINE.InvokeRequired)
                {
                    chkBox_Recht_ALTER_ROUTINE.Invoke(new Action(() => chkBox_Recht_ALTER_ROUTINE.Enabled = Check));
                    chkBox_Recht_ALTER_ROUTINE.Invoke(new Action(() => chkBox_Recht_ALTER_ROUTINE.Checked = false));
                }
                Berechtigung_set_checkbox = Berechtigung_set_checkbox.Replace(" ALTER ROUTINE,", string.Empty);
            }
            else if (Checkbox_Name == "chkBox_Recht_CREATE")
            {
                if (chkBox_Recht_CREATE_ROUTINE.InvokeRequired)
                {
                    chkBox_Recht_CREATE_ROUTINE.Invoke(new Action(() => chkBox_Recht_CREATE_ROUTINE.Enabled = Check));
                    chkBox_Recht_CREATE_ROUTINE.Invoke(new Action(() => chkBox_Recht_CREATE_ROUTINE.Checked = false));
                }

                if (chkBox_Recht_CREATE_TEMPORARY_TABLES.InvokeRequired)
                {
                    chkBox_Recht_CREATE_TEMPORARY_TABLES.Invoke(new Action(() => chkBox_Recht_CREATE_TEMPORARY_TABLES.Enabled = Check));
                    chkBox_Recht_CREATE_TEMPORARY_TABLES.Invoke(new Action(() => chkBox_Recht_CREATE_TEMPORARY_TABLES.Checked = false));
                }

                if (chkBox_Recht_CREATE_VIEW.InvokeRequired)
                {
                    chkBox_Recht_CREATE_VIEW.Invoke(new Action(() => chkBox_Recht_CREATE_VIEW.Enabled = Check));
                    chkBox_Recht_CREATE_VIEW.Invoke(new Action(() => chkBox_Recht_CREATE_VIEW.Checked = false));
                }
                Berechtigung_set_checkbox = Berechtigung_set_checkbox.Replace(" CREATE ROUTINE,", string.Empty);
                Berechtigung_set_checkbox = Berechtigung_set_checkbox.Replace(" CREATE TEMPORARY TABLES,", string.Empty);
                Berechtigung_set_checkbox = Berechtigung_set_checkbox.Replace(" CREATE VIEW,", string.Empty);
            }
            else if (Checkbox_Name == "chkBox_Recht_DELETE")
            {
                if (chkBox_Recht_DELETE_HISTORY.InvokeRequired)
                {
                    chkBox_Recht_DELETE_HISTORY.Invoke(new Action(() => chkBox_Recht_DELETE_HISTORY.Enabled = Check));
                    chkBox_Recht_DELETE_HISTORY.Invoke(new Action(() => chkBox_Recht_DELETE_HISTORY.Checked = false));
                }
                Berechtigung_set_checkbox = Berechtigung_set_checkbox.Replace(" DELETE HISTORY,", string.Empty);
            }

            return Berechtigung_set_checkbox;
        }

        public async void Berechtigungen_pruefen(object sender)
        {
            CheckBox checkBox_Recht = (CheckBox)sender;

            if (checkBox_Recht != null)
            {
                string Checkbox_Text = checkBox_Recht.Text;
                string Checkbox_Name = checkBox_Recht.Name;
                string Formatierte_Berechtigung = string.Format(" {0},", Checkbox_Text);

                if (checkBox_Recht.Checked)
                {
                    await Task.Run(() => Berechtigungen = Set_Checkbox(Checkbox_Name, false));

                    if (Checkbox_Name.Contains("chkBox_Recht_ALTER_"))
                        Formatierte_Berechtigung = Formatierte_Berechtigung.Insert(1, "ALTER ");
                    else if (Checkbox_Name.Contains("chkBox_Recht_CREATE_"))
                        Formatierte_Berechtigung = Formatierte_Berechtigung.Insert(1, "CREATE ");
                    else if (Checkbox_Name.Contains("chkBox_Recht_DELETE_"))
                        Formatierte_Berechtigung = Formatierte_Berechtigung.Insert(1, "DELETE ");

                    Berechtigungen += Formatierte_Berechtigung;

                    if (Checkbox_Name == "chkBox_Recht_ALL")
                    {
                        Berechtigungen = " ALL";
                    }
                }
                else
                {
                    await Task.Run(() => Berechtigungen = Set_Checkbox(Checkbox_Name, true));

                    if (Checkbox_Name.Contains("chkBox_Recht_ALTER_"))
                        Formatierte_Berechtigung = Formatierte_Berechtigung.Insert(1, "ALTER ");
                    else if (Checkbox_Name.Contains("chkBox_Recht_CREATE_"))
                        Formatierte_Berechtigung = Formatierte_Berechtigung.Insert(1, "CREATE ");
                    else if (Checkbox_Name.Contains("chkBox_Recht_DELETE_"))
                        Formatierte_Berechtigung = Formatierte_Berechtigung.Insert(1, "DELETE ");

                    Berechtigungen = Berechtigungen.Replace(Formatierte_Berechtigung, string.Empty);

                    if (Checkbox_Name == "chkBox_Recht_ALL")
                    {
                        Berechtigungen = string.Empty;
                    }
                }

                //if (richTextBox1.InvokeRequired) richTextBox1.Invoke(new Action(() => richTextBox1.Text = string.Format("Recht:\n{0}", Berechtigungen)));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBox_Name.Text = "srv-db-" + listBox1.SelectedItem.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Es werden nur die Berechtigungen vergeben.");
                txtBox_Passwort.ReadOnly = true;
            }
            else
                txtBox_Passwort.ReadOnly = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string UserFile = string.Format(@"{0}\Microsoft\UserSecrets\f2979d6f-6fbc-4943-b574-b488c2eac9d7\secrets.json", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            if (!File.Exists(UserFile))
            {
                MessageBox.Show("Datei nicht vorhanden");
                _ = Directory.CreateDirectory(Path.GetDirectoryName(UserFile));
                PasswordGenerator randomPasswordGenerator = new();

                string Passwort = randomPasswordGenerator.GeneratePassword(true, true, true, true, 30);

                using (StreamWriter writer = new StreamWriter(UserFile))
                {
                    writer.WriteLine("{");
                    writer.WriteLine(string.Format("\"Crypto_137\": \"{0}\"", Passwort));
                    writer.WriteLine("}");
                }
            }

            try
            {
                Berechtigungen = " CREATE, DELETE, DROP, INSERT, LOCK TABLES, SELECT, UPDATE,"; //Standardberechtigungen
                string Passwort = Crypto_137.Text_Decrypt(Registry.GetValue("Passwort"), string.Empty);

                txtBox_MYSQL_IP.Text = Registry.GetValue("IP-Adresse");
                txtBox_MYSQL_Benutzer.Text = Registry.GetValue("Benutzername");
                txtBox_MYSQL_Passwort.Text = Passwort;
                txtBox_MYSQL_Port.Text = Registry.GetValue("Port");
                txtBox_Host.Text = Registry.GetValue("Letzter Host");

                if (txtBox_MYSQL_IP.Text == "")
                    throw new FormatException();

                List<string> list = MYSQL.Auflistung_Einträge("show databases", 1);
                list.Sort();

                foreach (var item in list)
                {
                    listBox1.Items.Add(item);
                }

                list.Clear();

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Es ist ein Fehler aufgetreten. Bitte einmal die MYSQL Verbindungsdaten prüfen und dort auf den Button \"Speichern\" drücken.\n" +
                    ex.Message.ToString());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Es fehlen Daten. Bitte einmal die MYSQL Verbindungsdaten prüfen und dort auf den Button \"Speichern\" drücken.");
            }
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            string Benutzernameli = txtBox_Name.Text;
            string Passwortli = txtBox_Passwort.Text;
            string Datenbankli = listBox1.SelectedItem.ToString();
            string Host = txtBox_Host.Text;

            if (!checkBox1.Checked)
                if (!MYSQL.Nur_Befehl(string.Format("CREATE USER '{0}'@'{1}' IDENTIFIED BY '{2}';FLUSH PRIVILEGES;", Benutzernameli, Host, Passwortli))) { MessageBox.Show("Der Benutzer konnte nicht erstellt werden!"); }

            Berechtigungen = Berechtigungen.Remove(Berechtigungen.Length - 1, 1);

            if (Grant_Option)
                Berechtigungen += ", GRANT OPTION";

            if (MYSQL.Nur_Befehl(string.Format("GRANT{0} ON {1}.* TO '{2}'@'{3}';FLUSH PRIVILEGES;", Berechtigungen.ToLower(), Datenbankli, Benutzernameli, Host)))
            {
                if (checkBox1.Checked)
                    MessageBox.Show("Der Benutzer wurde erfolgreich angelegt und die gewünschten Berechtigungen wurde zugewiesen.");
                else
                    MessageBox.Show("Dem Benutzer wurden erfolgreich die gewünschten Berechtigungen zugewiesen.");
            }
        }

        private void btn_MYSQL_Daten_speichern_Click(object sender, EventArgs e)
        {
            string Passwort = Crypto_137.Text_Encrypt(txtBox_MYSQL_Passwort.Text, string.Empty);

            Registry.SetValue("IP-Adresse", txtBox_MYSQL_IP.Text);
            Registry.SetValue("Benutzername", txtBox_MYSQL_Benutzer.Text);
            Registry.SetValue("Passwort", Passwort);
            Registry.SetValue("Port", txtBox_MYSQL_Port.Text);
            Registry.SetValue("Letzter Host", txtBox_Host.Text);

            List<string> list = MYSQL.Auflistung_Einträge("show databases", 1);
            list.Sort();

            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
            list.Clear();
        }

        private void btn_Neues_Passwort_Click(object sender, EventArgs e)
        {
            PasswordGenerator randomPasswordGenerator = new PasswordGenerator();

            txtBox_Passwort.Text = randomPasswordGenerator.GeneratePassword(true, true, true, true, 30);
        }

        private async void chkBox_Recht_Checked(object sender, EventArgs e)
        {
            await Task.Run(() => Berechtigungen_pruefen(sender));
        }

        private void chkBox_Recht_GRANT_OPTION_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox_Recht_GRANT_OPTION.Checked)
                Grant_Option = true;
            else
                Grant_Option = false;
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
                txtBox_MYSQL_Passwort.PasswordChar = '\0';
            else
                txtBox_MYSQL_Passwort.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
