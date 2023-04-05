using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;
using System.Web;
using MYSQL_Benutzer_erstellen.Klassen;


namespace MYSQL_Benuter_erstellen
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        public void MYSQL(string SQL_Befehl, int switch_on)
        {
            try
            {
                MySqlConnection mySqlConnection = new(MYSQL_Benutzer_erstellen.Klassen.MYSQL.Connectionstring());
                mySqlConnection.Open();

                MySqlCommand command = mySqlConnection.CreateCommand();

                switch (switch_on)
                {
                    case 1:
                        {
                            command.CommandText = SQL_Befehl;
                            IDataReader reader = command.ExecuteReader();
                            int i = 0;
                            if (listBox1.InvokeRequired) listBox1.Invoke(new Action(listBox1.Items.Clear));
                            while (reader.Read() != false)
                            {
                                if (listBox1.InvokeRequired) listBox1.Invoke(new Action(() => listBox1.Items.Add(reader[i].ToString())));
                            }

                            reader.Close();
                            break;
                        }
                    case 2:
                        {
                            command.CommandText = SQL_Befehl;
                            IDataReader reader = command.ExecuteReader();
                            reader.Close();
                            MessageBox.Show("Der Servicebenutzer wurde erfolgreich angelegt.");
                            break;
                        }
                    default:
                        break;
                }
                command.Dispose();
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
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
            string Passwort = Crypto_137.Text_Decrypt(Registry.GetValue("Passwort"), string.Empty);

            txtBox_MYSQL_IP.Text = Registry.GetValue("IP-Adresse");
            txtBox_MYSQL_Benutzer.Text = Registry.GetValue("Benutzername");
            txtBox_MYSQL_Passwort.Text = Passwort;
            txtBox_MYSQL_Port.Text = Registry.GetValue("Port");

            await Task.Run(() => MYSQL("show databases", 1));
        }

        private void btn_Speichern_Click(object sender, EventArgs e)
        {
            string Benutzernameli = txtBox_Name.Text;
            string Passwortli = txtBox_Passwort.Text;
            string Datenbankli = listBox1.SelectedItem.ToString();

            if (!checkBox1.Checked)
                MYSQL(string.Format("CREATE USER '{0}'@'192.168.0.%' IDENTIFIED BY '{1}';FLUSH PRIVILEGES;", Benutzernameli, Passwortli), 2);

            MYSQL(string.Format("GRANT ALL PRIVILEGES ON {0}.* TO '{1}'@'192.168.0.%';FLUSH PRIVILEGES;", Datenbankli, Benutzernameli), 2);
        }

        private async void btn_MYSQL_Daten_speichern_Click(object sender, EventArgs e)
        {
            string Passwort = Crypto_137.Text_Encrypt(txtBox_MYSQL_Passwort.Text, string.Empty);

            Registry.SetValue("IP-Adresse", txtBox_MYSQL_IP.Text);
            Registry.SetValue("Benutzername", txtBox_MYSQL_Benutzer.Text);
            Registry.SetValue("Passwort", Passwort);
            Registry.SetValue("Port", txtBox_MYSQL_Port.Text);

            await Task.Run(() => MYSQL("show databases", 1));
        }

        private void btn_Neues_Passwort_Click(object sender, EventArgs e)
        {
            PasswordGenerator randomPasswordGenerator = new PasswordGenerator();

            string password = randomPasswordGenerator.GeneratePassword(true, true, true, true, 30);

            MessageBox.Show(password);
        }

        private void chkBox_Recht_Checked(object sender, EventArgs e)
        {
            CheckBox checkBox_Recht = (CheckBox)sender;

            if (checkBox_Recht != null)
            {
                MessageBox.Show(checkBox_Recht.Text);
            }
        }
    }
}
