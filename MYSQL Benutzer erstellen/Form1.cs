using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace MYSQL_Benuter_erstellen
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        string Server_IP, MYSQL_Name, MYSQL_Passwort;
        string Befehl;

        public void MYSQL(string SQL_Befehl, int switch_on)
        {
            try
            {
                string Connectionstring = "server=" + Server_IP + ";user id=" + MYSQL_Name + "; password=" + MYSQL_Passwort + ";port=3306;SslMode=None";

                MySqlConnection mySqlConnection = new(Connectionstring);
                mySqlConnection.Open();

                MySqlCommand command = mySqlConnection.CreateCommand();

                switch (switch_on)
                {
                    case 1:
                        {
                            command.CommandText = SQL_Befehl;
                            IDataReader reader = command.ExecuteReader();
                            int i = 0;

                            if (listBox1.InvokeRequired) listBox1.Invoke(new Action(() => listBox1.Items.Clear()));

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
                            break;
                        }
                    default:
                        break;
                }
                command.Dispose();
                mySqlConnection.Close();
                MessageBox.Show("Der Servicebenutzer wurde erfolgreich angelegt.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Benutzernameli = txtBox_Name.Text;
            string Passwortli = txtBox_Passwort.Text;
            string Datenbankli = listBox1.SelectedItem.ToString();

            if (!checkBox1.Checked)
                MYSQL("CREATE USER '" + Benutzernameli + "'@'%' IDENTIFIED BY '" + Passwortli + "';FLUSH PRIVILEGES;", 2);

            MYSQL("GRANT ALL PRIVILEGES ON " + Datenbankli + ".* TO '" + Benutzernameli + "'@'%';FLUSH PRIVILEGES;", 2);
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
            Server_IP = txtBox_MYSQL_IP.Text;
            MYSQL_Name = txtBox_MYSQL_Benutzer.Text;
            MYSQL_Passwort = txtBox_MYSQL_Passwort.Text;

            await Task.Run(() => MYSQL("show databases", 1));
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Server_IP = txtBox_MYSQL_IP.Text;
            MYSQL_Name = txtBox_MYSQL_Benutzer.Text;
            MYSQL_Passwort = txtBox_MYSQL_Passwort.Text;

            await Task.Run(() => MYSQL("show databases", 1));
        }
    }
}
