
namespace MYSQL_Benuter_erstellen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Speichern = new Button();
            label1 = new Label();
            txtBox_Name = new TextBox();
            listBox1 = new ListBox();
            txtBox_Passwort = new TextBox();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            checkBox23 = new CheckBox();
            txtBox_MYSQL_Port = new TextBox();
            label7 = new Label();
            btn_MYSQL_Daten_speichern = new Button();
            txtBox_MYSQL_Passwort = new TextBox();
            txtBox_MYSQL_Benutzer = new TextBox();
            txtBox_MYSQL_IP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            richTextBox1 = new RichTextBox();
            chkBox_Recht_GRANT_OPTION = new CheckBox();
            chkBox_Recht_UPDATE = new CheckBox();
            chkBox_Recht_TRIGGER = new CheckBox();
            chkBox_Recht_SHOW_VIEW = new CheckBox();
            chkBox_Recht_SELECT = new CheckBox();
            chkBox_Recht_REFERENCES = new CheckBox();
            chkBox_Recht_LOCK_TABLES = new CheckBox();
            chkBox_Recht_INSERT = new CheckBox();
            chkBox_Recht_INDEX = new CheckBox();
            chkBox_Recht_EXECUTE = new CheckBox();
            chkBox_Recht_EVENT = new CheckBox();
            chkBox_Recht_DROP = new CheckBox();
            chkBox_Recht_DELETE_HISTORY = new CheckBox();
            chkBox_Recht_DELETE = new CheckBox();
            chkBox_Recht_CREATE_VIEW = new CheckBox();
            chkBox_Recht_CREATE_TEMPORARY_TABLES = new CheckBox();
            chkBox_Recht_CREATE_ROUTINE = new CheckBox();
            chkBox_Recht_CREATE = new CheckBox();
            chkBox_Recht_ALTER_ROUTINE = new CheckBox();
            chkBox_Recht_ALTER = new CheckBox();
            chkBox_Recht_ALL = new CheckBox();
            btn_Neues_Passwort = new Button();
            txtBox_Host = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Speichern
            // 
            btn_Speichern.Location = new Point(185, 222);
            btn_Speichern.Margin = new Padding(4, 3, 4, 3);
            btn_Speichern.Name = "btn_Speichern";
            btn_Speichern.Size = new Size(88, 27);
            btn_Speichern.TabIndex = 3;
            btn_Speichern.Text = "Erstellen";
            btn_Speichern.UseVisualStyleBackColor = true;
            btn_Speichern.Click += btn_Speichern_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // txtBox_Name
            // 
            txtBox_Name.Location = new Point(94, 7);
            txtBox_Name.Margin = new Padding(4, 3, 4, 3);
            txtBox_Name.Name = "txtBox_Name";
            txtBox_Name.Size = new Size(179, 23);
            txtBox_Name.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(94, 97);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(179, 94);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtBox_Passwort
            // 
            txtBox_Passwort.Location = new Point(94, 37);
            txtBox_Passwort.Margin = new Padding(4, 3, 4, 3);
            txtBox_Passwort.Name = "txtBox_Passwort";
            txtBox_Passwort.Size = new Size(179, 23);
            txtBox_Passwort.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 40);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Passwort:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 97);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Datenbank:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox23);
            groupBox1.Controls.Add(txtBox_MYSQL_Port);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btn_MYSQL_Daten_speichern);
            groupBox1.Controls.Add(txtBox_MYSQL_Passwort);
            groupBox1.Controls.Add(txtBox_MYSQL_Benutzer);
            groupBox1.Controls.Add(txtBox_MYSQL_IP);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(14, 255);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(259, 219);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "MYSQL Verbindungseinstellungen";
            // 
            // checkBox23
            // 
            checkBox23.AutoSize = true;
            checkBox23.Location = new Point(163, 131);
            checkBox23.Name = "checkBox23";
            checkBox23.Size = new Size(77, 34);
            checkBox23.TabIndex = 11;
            checkBox23.Text = "Kennwort\r\nanzeigen";
            checkBox23.UseVisualStyleBackColor = true;
            checkBox23.CheckedChanged += checkBox23_CheckedChanged;
            // 
            // txtBox_MYSQL_Port
            // 
            txtBox_MYSQL_Port.Location = new Point(8, 184);
            txtBox_MYSQL_Port.Margin = new Padding(4, 3, 4, 3);
            txtBox_MYSQL_Port.Name = "txtBox_MYSQL_Port";
            txtBox_MYSQL_Port.Size = new Size(149, 23);
            txtBox_MYSQL_Port.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 166);
            label7.Margin = new Padding(4, 3, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 12;
            label7.Text = "Port:";
            // 
            // btn_MYSQL_Daten_speichern
            // 
            btn_MYSQL_Daten_speichern.Location = new Point(164, 181);
            btn_MYSQL_Daten_speichern.Margin = new Padding(4, 3, 4, 3);
            btn_MYSQL_Daten_speichern.Name = "btn_MYSQL_Daten_speichern";
            btn_MYSQL_Daten_speichern.Size = new Size(88, 27);
            btn_MYSQL_Daten_speichern.TabIndex = 11;
            btn_MYSQL_Daten_speichern.Text = "Speichern";
            btn_MYSQL_Daten_speichern.UseVisualStyleBackColor = true;
            btn_MYSQL_Daten_speichern.Click += btn_MYSQL_Daten_speichern_Click;
            // 
            // txtBox_MYSQL_Passwort
            // 
            txtBox_MYSQL_Passwort.Location = new Point(7, 137);
            txtBox_MYSQL_Passwort.Margin = new Padding(4, 3, 4, 3);
            txtBox_MYSQL_Passwort.Name = "txtBox_MYSQL_Passwort";
            txtBox_MYSQL_Passwort.PasswordChar = '*';
            txtBox_MYSQL_Passwort.Size = new Size(149, 23);
            txtBox_MYSQL_Passwort.TabIndex = 10;
            // 
            // txtBox_MYSQL_Benutzer
            // 
            txtBox_MYSQL_Benutzer.Location = new Point(7, 89);
            txtBox_MYSQL_Benutzer.Margin = new Padding(4, 3, 4, 3);
            txtBox_MYSQL_Benutzer.Name = "txtBox_MYSQL_Benutzer";
            txtBox_MYSQL_Benutzer.Size = new Size(149, 23);
            txtBox_MYSQL_Benutzer.TabIndex = 9;
            // 
            // txtBox_MYSQL_IP
            // 
            txtBox_MYSQL_IP.Location = new Point(7, 40);
            txtBox_MYSQL_IP.Margin = new Padding(4, 3, 4, 3);
            txtBox_MYSQL_IP.Name = "txtBox_MYSQL_IP";
            txtBox_MYSQL_IP.Size = new Size(149, 23);
            txtBox_MYSQL_IP.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 119);
            label6.Margin = new Padding(4, 3, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 2;
            label6.Text = "Passwort:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 70);
            label5.Margin = new Padding(4, 3, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 1;
            label5.Text = "Benutzername:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 22);
            label4.Margin = new Padding(4, 3, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 0;
            label4.Text = "IP-Adresse:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(94, 197);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(121, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Bereits vorhanden";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(richTextBox1);
            groupBox2.Controls.Add(chkBox_Recht_GRANT_OPTION);
            groupBox2.Controls.Add(chkBox_Recht_UPDATE);
            groupBox2.Controls.Add(chkBox_Recht_TRIGGER);
            groupBox2.Controls.Add(chkBox_Recht_SHOW_VIEW);
            groupBox2.Controls.Add(chkBox_Recht_SELECT);
            groupBox2.Controls.Add(chkBox_Recht_REFERENCES);
            groupBox2.Controls.Add(chkBox_Recht_LOCK_TABLES);
            groupBox2.Controls.Add(chkBox_Recht_INSERT);
            groupBox2.Controls.Add(chkBox_Recht_INDEX);
            groupBox2.Controls.Add(chkBox_Recht_EXECUTE);
            groupBox2.Controls.Add(chkBox_Recht_EVENT);
            groupBox2.Controls.Add(chkBox_Recht_DROP);
            groupBox2.Controls.Add(chkBox_Recht_DELETE_HISTORY);
            groupBox2.Controls.Add(chkBox_Recht_DELETE);
            groupBox2.Controls.Add(chkBox_Recht_CREATE_VIEW);
            groupBox2.Controls.Add(chkBox_Recht_CREATE_TEMPORARY_TABLES);
            groupBox2.Controls.Add(chkBox_Recht_CREATE_ROUTINE);
            groupBox2.Controls.Add(chkBox_Recht_CREATE);
            groupBox2.Controls.Add(chkBox_Recht_ALTER_ROUTINE);
            groupBox2.Controls.Add(chkBox_Recht_ALTER);
            groupBox2.Controls.Add(chkBox_Recht_ALL);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(280, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 481);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Tag = "Berechtigung";
            groupBox2.Text = "Berechtigungen";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(109, 172);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(160, 217);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "";
            // 
            // chkBox_Recht_GRANT_OPTION
            // 
            chkBox_Recht_GRANT_OPTION.AutoSize = true;
            chkBox_Recht_GRANT_OPTION.Location = new Point(137, 72);
            chkBox_Recht_GRANT_OPTION.Name = "chkBox_Recht_GRANT_OPTION";
            chkBox_Recht_GRANT_OPTION.Size = new Size(138, 19);
            chkBox_Recht_GRANT_OPTION.TabIndex = 20;
            chkBox_Recht_GRANT_OPTION.Text = "With GRANT OPTION";
            chkBox_Recht_GRANT_OPTION.UseVisualStyleBackColor = true;
            chkBox_Recht_GRANT_OPTION.CheckedChanged += chkBox_Recht_GRANT_OPTION_CheckedChanged;
            // 
            // chkBox_Recht_UPDATE
            // 
            chkBox_Recht_UPDATE.AutoSize = true;
            chkBox_Recht_UPDATE.Checked = true;
            chkBox_Recht_UPDATE.CheckState = CheckState.Checked;
            chkBox_Recht_UPDATE.Location = new Point(137, 47);
            chkBox_Recht_UPDATE.Name = "chkBox_Recht_UPDATE";
            chkBox_Recht_UPDATE.Size = new Size(68, 19);
            chkBox_Recht_UPDATE.TabIndex = 19;
            chkBox_Recht_UPDATE.Tag = "Berechtigung";
            chkBox_Recht_UPDATE.Text = "UPDATE";
            chkBox_Recht_UPDATE.UseVisualStyleBackColor = true;
            chkBox_Recht_UPDATE.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_TRIGGER
            // 
            chkBox_Recht_TRIGGER.AutoSize = true;
            chkBox_Recht_TRIGGER.Location = new Point(137, 22);
            chkBox_Recht_TRIGGER.Name = "chkBox_Recht_TRIGGER";
            chkBox_Recht_TRIGGER.Size = new Size(71, 19);
            chkBox_Recht_TRIGGER.TabIndex = 18;
            chkBox_Recht_TRIGGER.Tag = "Berechtigung";
            chkBox_Recht_TRIGGER.Text = "TRIGGER";
            chkBox_Recht_TRIGGER.UseVisualStyleBackColor = true;
            chkBox_Recht_TRIGGER.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_SHOW_VIEW
            // 
            chkBox_Recht_SHOW_VIEW.AutoSize = true;
            chkBox_Recht_SHOW_VIEW.Location = new Point(6, 447);
            chkBox_Recht_SHOW_VIEW.Name = "chkBox_Recht_SHOW_VIEW";
            chkBox_Recht_SHOW_VIEW.Size = new Size(91, 19);
            chkBox_Recht_SHOW_VIEW.TabIndex = 17;
            chkBox_Recht_SHOW_VIEW.Tag = "Berechtigung";
            chkBox_Recht_SHOW_VIEW.Text = "SHOW VIEW";
            chkBox_Recht_SHOW_VIEW.UseVisualStyleBackColor = true;
            chkBox_Recht_SHOW_VIEW.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_SELECT
            // 
            chkBox_Recht_SELECT.AutoSize = true;
            chkBox_Recht_SELECT.Checked = true;
            chkBox_Recht_SELECT.CheckState = CheckState.Checked;
            chkBox_Recht_SELECT.Location = new Point(6, 422);
            chkBox_Recht_SELECT.Name = "chkBox_Recht_SELECT";
            chkBox_Recht_SELECT.Size = new Size(64, 19);
            chkBox_Recht_SELECT.TabIndex = 16;
            chkBox_Recht_SELECT.Tag = "Berechtigung";
            chkBox_Recht_SELECT.Text = "SELECT";
            chkBox_Recht_SELECT.UseVisualStyleBackColor = true;
            chkBox_Recht_SELECT.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_REFERENCES
            // 
            chkBox_Recht_REFERENCES.AutoSize = true;
            chkBox_Recht_REFERENCES.Location = new Point(6, 397);
            chkBox_Recht_REFERENCES.Name = "chkBox_Recht_REFERENCES";
            chkBox_Recht_REFERENCES.Size = new Size(93, 19);
            chkBox_Recht_REFERENCES.TabIndex = 15;
            chkBox_Recht_REFERENCES.Tag = "Berechtigung";
            chkBox_Recht_REFERENCES.Text = "REFERENCES";
            chkBox_Recht_REFERENCES.UseVisualStyleBackColor = true;
            chkBox_Recht_REFERENCES.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_LOCK_TABLES
            // 
            chkBox_Recht_LOCK_TABLES.AutoSize = true;
            chkBox_Recht_LOCK_TABLES.Checked = true;
            chkBox_Recht_LOCK_TABLES.CheckState = CheckState.Checked;
            chkBox_Recht_LOCK_TABLES.Location = new Point(6, 372);
            chkBox_Recht_LOCK_TABLES.Name = "chkBox_Recht_LOCK_TABLES";
            chkBox_Recht_LOCK_TABLES.Size = new Size(97, 19);
            chkBox_Recht_LOCK_TABLES.TabIndex = 14;
            chkBox_Recht_LOCK_TABLES.Tag = "Berechtigung";
            chkBox_Recht_LOCK_TABLES.Text = "LOCK TABLES";
            chkBox_Recht_LOCK_TABLES.UseVisualStyleBackColor = true;
            chkBox_Recht_LOCK_TABLES.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_INSERT
            // 
            chkBox_Recht_INSERT.AutoSize = true;
            chkBox_Recht_INSERT.Checked = true;
            chkBox_Recht_INSERT.CheckState = CheckState.Checked;
            chkBox_Recht_INSERT.Location = new Point(6, 347);
            chkBox_Recht_INSERT.Name = "chkBox_Recht_INSERT";
            chkBox_Recht_INSERT.Size = new Size(62, 19);
            chkBox_Recht_INSERT.TabIndex = 13;
            chkBox_Recht_INSERT.Tag = "Berechtigung";
            chkBox_Recht_INSERT.Text = "INSERT";
            chkBox_Recht_INSERT.UseVisualStyleBackColor = true;
            chkBox_Recht_INSERT.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_INDEX
            // 
            chkBox_Recht_INDEX.AutoSize = true;
            chkBox_Recht_INDEX.Location = new Point(6, 322);
            chkBox_Recht_INDEX.Name = "chkBox_Recht_INDEX";
            chkBox_Recht_INDEX.Size = new Size(59, 19);
            chkBox_Recht_INDEX.TabIndex = 12;
            chkBox_Recht_INDEX.Tag = "Berechtigung";
            chkBox_Recht_INDEX.Text = "INDEX";
            chkBox_Recht_INDEX.UseVisualStyleBackColor = true;
            chkBox_Recht_INDEX.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_EXECUTE
            // 
            chkBox_Recht_EXECUTE.AutoSize = true;
            chkBox_Recht_EXECUTE.Location = new Point(6, 297);
            chkBox_Recht_EXECUTE.Name = "chkBox_Recht_EXECUTE";
            chkBox_Recht_EXECUTE.Size = new Size(73, 19);
            chkBox_Recht_EXECUTE.TabIndex = 11;
            chkBox_Recht_EXECUTE.Tag = "Berechtigung";
            chkBox_Recht_EXECUTE.Text = "EXECUTE";
            chkBox_Recht_EXECUTE.UseVisualStyleBackColor = true;
            chkBox_Recht_EXECUTE.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_EVENT
            // 
            chkBox_Recht_EVENT.AutoSize = true;
            chkBox_Recht_EVENT.Location = new Point(6, 272);
            chkBox_Recht_EVENT.Name = "chkBox_Recht_EVENT";
            chkBox_Recht_EVENT.Size = new Size(60, 19);
            chkBox_Recht_EVENT.TabIndex = 10;
            chkBox_Recht_EVENT.Tag = "Berechtigung";
            chkBox_Recht_EVENT.Text = "EVENT";
            chkBox_Recht_EVENT.UseVisualStyleBackColor = true;
            chkBox_Recht_EVENT.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_DROP
            // 
            chkBox_Recht_DROP.AutoSize = true;
            chkBox_Recht_DROP.Checked = true;
            chkBox_Recht_DROP.CheckState = CheckState.Checked;
            chkBox_Recht_DROP.Location = new Point(6, 247);
            chkBox_Recht_DROP.Name = "chkBox_Recht_DROP";
            chkBox_Recht_DROP.Size = new Size(57, 19);
            chkBox_Recht_DROP.TabIndex = 9;
            chkBox_Recht_DROP.Tag = "Berechtigung";
            chkBox_Recht_DROP.Text = "DROP";
            chkBox_Recht_DROP.UseVisualStyleBackColor = true;
            chkBox_Recht_DROP.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_DELETE_HISTORY
            // 
            chkBox_Recht_DELETE_HISTORY.AutoSize = true;
            chkBox_Recht_DELETE_HISTORY.Enabled = false;
            chkBox_Recht_DELETE_HISTORY.Location = new Point(25, 222);
            chkBox_Recht_DELETE_HISTORY.Name = "chkBox_Recht_DELETE_HISTORY";
            chkBox_Recht_DELETE_HISTORY.Size = new Size(72, 19);
            chkBox_Recht_DELETE_HISTORY.TabIndex = 8;
            chkBox_Recht_DELETE_HISTORY.Tag = "Berechtigung";
            chkBox_Recht_DELETE_HISTORY.Text = "HISTORY";
            chkBox_Recht_DELETE_HISTORY.UseVisualStyleBackColor = true;
            chkBox_Recht_DELETE_HISTORY.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_DELETE
            // 
            chkBox_Recht_DELETE.AutoSize = true;
            chkBox_Recht_DELETE.Checked = true;
            chkBox_Recht_DELETE.CheckState = CheckState.Checked;
            chkBox_Recht_DELETE.Location = new Point(6, 197);
            chkBox_Recht_DELETE.Name = "chkBox_Recht_DELETE";
            chkBox_Recht_DELETE.Size = new Size(64, 19);
            chkBox_Recht_DELETE.TabIndex = 7;
            chkBox_Recht_DELETE.Tag = "Berechtigung";
            chkBox_Recht_DELETE.Text = "DELETE";
            chkBox_Recht_DELETE.UseVisualStyleBackColor = true;
            chkBox_Recht_DELETE.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_CREATE_VIEW
            // 
            chkBox_Recht_CREATE_VIEW.AutoSize = true;
            chkBox_Recht_CREATE_VIEW.Enabled = false;
            chkBox_Recht_CREATE_VIEW.Location = new Point(25, 172);
            chkBox_Recht_CREATE_VIEW.Name = "chkBox_Recht_CREATE_VIEW";
            chkBox_Recht_CREATE_VIEW.Size = new Size(53, 19);
            chkBox_Recht_CREATE_VIEW.TabIndex = 6;
            chkBox_Recht_CREATE_VIEW.Tag = "Berechtigung";
            chkBox_Recht_CREATE_VIEW.Text = "VIEW";
            chkBox_Recht_CREATE_VIEW.UseVisualStyleBackColor = true;
            chkBox_Recht_CREATE_VIEW.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_CREATE_TEMPORARY_TABLES
            // 
            chkBox_Recht_CREATE_TEMPORARY_TABLES.AutoSize = true;
            chkBox_Recht_CREATE_TEMPORARY_TABLES.Enabled = false;
            chkBox_Recht_CREATE_TEMPORARY_TABLES.Location = new Point(25, 147);
            chkBox_Recht_CREATE_TEMPORARY_TABLES.Name = "chkBox_Recht_CREATE_TEMPORARY_TABLES";
            chkBox_Recht_CREATE_TEMPORARY_TABLES.Size = new Size(135, 19);
            chkBox_Recht_CREATE_TEMPORARY_TABLES.TabIndex = 5;
            chkBox_Recht_CREATE_TEMPORARY_TABLES.Tag = "Berechtigung";
            chkBox_Recht_CREATE_TEMPORARY_TABLES.Text = "TEMPORARY TABLES";
            chkBox_Recht_CREATE_TEMPORARY_TABLES.UseVisualStyleBackColor = true;
            chkBox_Recht_CREATE_TEMPORARY_TABLES.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_CREATE_ROUTINE
            // 
            chkBox_Recht_CREATE_ROUTINE.AutoSize = true;
            chkBox_Recht_CREATE_ROUTINE.Enabled = false;
            chkBox_Recht_CREATE_ROUTINE.Location = new Point(25, 122);
            chkBox_Recht_CREATE_ROUTINE.Name = "chkBox_Recht_CREATE_ROUTINE";
            chkBox_Recht_CREATE_ROUTINE.Size = new Size(74, 19);
            chkBox_Recht_CREATE_ROUTINE.TabIndex = 4;
            chkBox_Recht_CREATE_ROUTINE.Tag = "Berechtigung";
            chkBox_Recht_CREATE_ROUTINE.Text = "ROUTINE";
            chkBox_Recht_CREATE_ROUTINE.UseVisualStyleBackColor = true;
            chkBox_Recht_CREATE_ROUTINE.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_CREATE
            // 
            chkBox_Recht_CREATE.AutoSize = true;
            chkBox_Recht_CREATE.Checked = true;
            chkBox_Recht_CREATE.CheckState = CheckState.Checked;
            chkBox_Recht_CREATE.Location = new Point(6, 97);
            chkBox_Recht_CREATE.Name = "chkBox_Recht_CREATE";
            chkBox_Recht_CREATE.Size = new Size(66, 19);
            chkBox_Recht_CREATE.TabIndex = 3;
            chkBox_Recht_CREATE.Tag = "Berechtigung";
            chkBox_Recht_CREATE.Text = "CREATE";
            chkBox_Recht_CREATE.UseVisualStyleBackColor = true;
            chkBox_Recht_CREATE.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_ALTER_ROUTINE
            // 
            chkBox_Recht_ALTER_ROUTINE.AutoSize = true;
            chkBox_Recht_ALTER_ROUTINE.Enabled = false;
            chkBox_Recht_ALTER_ROUTINE.Location = new Point(25, 72);
            chkBox_Recht_ALTER_ROUTINE.Name = "chkBox_Recht_ALTER_ROUTINE";
            chkBox_Recht_ALTER_ROUTINE.Size = new Size(74, 19);
            chkBox_Recht_ALTER_ROUTINE.TabIndex = 2;
            chkBox_Recht_ALTER_ROUTINE.Tag = "Berechtigung";
            chkBox_Recht_ALTER_ROUTINE.Text = "ROUTINE";
            chkBox_Recht_ALTER_ROUTINE.UseVisualStyleBackColor = true;
            chkBox_Recht_ALTER_ROUTINE.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_ALTER
            // 
            chkBox_Recht_ALTER.AutoSize = true;
            chkBox_Recht_ALTER.Checked = true;
            chkBox_Recht_ALTER.CheckState = CheckState.Checked;
            chkBox_Recht_ALTER.Location = new Point(6, 47);
            chkBox_Recht_ALTER.Name = "chkBox_Recht_ALTER";
            chkBox_Recht_ALTER.Size = new Size(58, 19);
            chkBox_Recht_ALTER.TabIndex = 1;
            chkBox_Recht_ALTER.Tag = "Berechtigung";
            chkBox_Recht_ALTER.Text = "ALTER";
            chkBox_Recht_ALTER.UseVisualStyleBackColor = true;
            chkBox_Recht_ALTER.CheckedChanged += chkBox_Recht_Checked;
            // 
            // chkBox_Recht_ALL
            // 
            chkBox_Recht_ALL.AutoSize = true;
            chkBox_Recht_ALL.Location = new Point(6, 22);
            chkBox_Recht_ALL.Name = "chkBox_Recht_ALL";
            chkBox_Recht_ALL.Size = new Size(125, 19);
            chkBox_Recht_ALL.TabIndex = 0;
            chkBox_Recht_ALL.Text = "Eiskalter Vollzugriff";
            chkBox_Recht_ALL.UseVisualStyleBackColor = true;
            chkBox_Recht_ALL.CheckedChanged += chkBox_Recht_Checked;
            // 
            // btn_Neues_Passwort
            // 
            btn_Neues_Passwort.Location = new Point(94, 222);
            btn_Neues_Passwort.Margin = new Padding(4, 3, 4, 3);
            btn_Neues_Passwort.Name = "btn_Neues_Passwort";
            btn_Neues_Passwort.Size = new Size(83, 27);
            btn_Neues_Passwort.TabIndex = 10;
            btn_Neues_Passwort.Text = "Neues PW";
            btn_Neues_Passwort.UseVisualStyleBackColor = true;
            btn_Neues_Passwort.Click += btn_Neues_Passwort_Click;
            // 
            // txtBox_Host
            // 
            txtBox_Host.Location = new Point(94, 66);
            txtBox_Host.Margin = new Padding(4, 3, 4, 3);
            txtBox_Host.Name = "txtBox_Host";
            txtBox_Host.Size = new Size(179, 23);
            txtBox_Host.TabIndex = 11;
            txtBox_Host.Text = "%";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 69);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 12;
            label8.Text = "Host:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 481);
            Controls.Add(txtBox_Host);
            Controls.Add(label8);
            Controls.Add(btn_Neues_Passwort);
            Controls.Add(groupBox2);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(txtBox_Passwort);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(txtBox_Name);
            Controls.Add(label1);
            Controls.Add(btn_Speichern);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "MYSQL Benutzer";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_Speichern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtBox_Passwort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBox_MYSQL_Benutzer;
        private System.Windows.Forms.TextBox txtBox_MYSQL_IP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_MYSQL_Daten_speichern;
        private System.Windows.Forms.TextBox txtBox_MYSQL_Passwort;
        private System.Windows.Forms.CheckBox checkBox1;
        private GroupBox groupBox2;
        private CheckBox chkBox_Recht_GRANT_OPTION;
        private CheckBox chkBox_Recht_UPDATE;
        private CheckBox chkBox_Recht_TRIGGER;
        private CheckBox chkBox_Recht_SHOW_VIEW;
        private CheckBox chkBox_Recht_SELECT;
        private CheckBox chkBox_Recht_REFERENCES;
        private CheckBox chkBox_Recht_LOCK_TABLES;
        private CheckBox chkBox_Recht_INSERT;
        private CheckBox chkBox_Recht_INDEX;
        private CheckBox chkBox_Recht_EXECUTE;
        private CheckBox chkBox_Recht_EVENT;
        private CheckBox chkBox_Recht_DROP;
        private CheckBox chkBox_Recht_DELETE_HISTORY;
        private CheckBox chkBox_Recht_DELETE;
        private CheckBox chkBox_Recht_CREATE_VIEW;
        private CheckBox chkBox_Recht_CREATE_TEMPORARY_TABLES;
        private CheckBox chkBox_Recht_CREATE_ROUTINE;
        private CheckBox chkBox_Recht_CREATE;
        private CheckBox chkBox_Recht_ALTER_ROUTINE;
        private CheckBox chkBox_Recht_ALTER;
        private CheckBox chkBox_Recht_ALL;
        private TextBox txtBox_MYSQL_Port;
        private Label label7;
        private Button btn_Neues_Passwort;
        private CheckBox checkBox23;
        private TextBox txtBox_Host;
        private Label label8;
        private RichTextBox richTextBox1;
    }
}

