
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
            button2 = new Button();
            txtBox_MYSQL_Passwort = new TextBox();
            txtBox_MYSQL_Benutzer = new TextBox();
            txtBox_MYSQL_IP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            groupBox2 = new GroupBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox16 = new CheckBox();
            checkBox17 = new CheckBox();
            checkBox18 = new CheckBox();
            checkBox19 = new CheckBox();
            checkBox20 = new CheckBox();
            checkBox21 = new CheckBox();
            checkBox22 = new CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Speichern
            // 
            btn_Speichern.Location = new Point(94, 222);
            btn_Speichern.Margin = new Padding(4, 3, 4, 3);
            btn_Speichern.Name = "btn_Speichern";
            btn_Speichern.Size = new Size(88, 27);
            btn_Speichern.TabIndex = 3;
            btn_Speichern.Text = "Speichern";
            btn_Speichern.UseVisualStyleBackColor = true;
            btn_Speichern.Click += button1_Click;
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
            txtBox_Name.Text = "srv-db-";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(94, 67);
            listBox1.Margin = new Padding(4, 3, 4, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(179, 124);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtBox_Passwort
            // 
            txtBox_Passwort.Location = new Point(94, 37);
            txtBox_Passwort.Margin = new Padding(4, 3, 4, 3);
            txtBox_Passwort.Name = "txtBox_Passwort";
            txtBox_Passwort.PasswordChar = '*';
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
            label3.Location = new Point(14, 67);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Datenbank:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
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
            groupBox1.Size = new Size(260, 203);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "MYSQL Einstellungen";
            // 
            // button2
            // 
            button2.Location = new Point(98, 166);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 11;
            button2.Text = "Testen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtBox_MYSQL_Passwort
            // 
            txtBox_MYSQL_Passwort.Location = new Point(7, 137);
            txtBox_MYSQL_Passwort.Margin = new Padding(4, 3, 4, 3);
            txtBox_MYSQL_Passwort.Name = "txtBox_MYSQL_Passwort";
            txtBox_MYSQL_Passwort.PasswordChar = '*';
            txtBox_MYSQL_Passwort.Size = new Size(179, 23);
            txtBox_MYSQL_Passwort.TabIndex = 10;
            txtBox_MYSQL_Passwort.Text = "giCi)GpH28,7i>`Tec?N8UtV5";
            // 
            // txtBox_MYSQL_Benutzer
            // 
            txtBox_MYSQL_Benutzer.Location = new Point(7, 89);
            txtBox_MYSQL_Benutzer.Margin = new Padding(4, 3, 4, 3);
            txtBox_MYSQL_Benutzer.Name = "txtBox_MYSQL_Benutzer";
            txtBox_MYSQL_Benutzer.Size = new Size(179, 23);
            txtBox_MYSQL_Benutzer.TabIndex = 9;
            txtBox_MYSQL_Benutzer.Text = "pi";
            // 
            // txtBox_MYSQL_IP
            // 
            txtBox_MYSQL_IP.Location = new Point(7, 40);
            txtBox_MYSQL_IP.Margin = new Padding(4, 3, 4, 3);
            txtBox_MYSQL_IP.Name = "txtBox_MYSQL_IP";
            txtBox_MYSQL_IP.Size = new Size(179, 23);
            txtBox_MYSQL_IP.TabIndex = 8;
            txtBox_MYSQL_IP.Text = "192.168.0.3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 119);
            label6.Margin = new Padding(4, 3, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 2;
            label6.Text = "MYSQL Passwort:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 70);
            label5.Margin = new Padding(4, 3, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 1;
            label5.Text = "MYSQL Benutzer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 22);
            label4.Margin = new Padding(4, 3, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 0;
            label4.Text = "Server IP-Adresse:";
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
            groupBox2.Controls.Add(checkBox22);
            groupBox2.Controls.Add(checkBox21);
            groupBox2.Controls.Add(checkBox20);
            groupBox2.Controls.Add(checkBox19);
            groupBox2.Controls.Add(checkBox18);
            groupBox2.Controls.Add(checkBox17);
            groupBox2.Controls.Add(checkBox16);
            groupBox2.Controls.Add(checkBox15);
            groupBox2.Controls.Add(checkBox14);
            groupBox2.Controls.Add(checkBox13);
            groupBox2.Controls.Add(checkBox12);
            groupBox2.Controls.Add(checkBox11);
            groupBox2.Controls.Add(checkBox10);
            groupBox2.Controls.Add(checkBox9);
            groupBox2.Controls.Add(checkBox8);
            groupBox2.Controls.Add(checkBox7);
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Location = new Point(280, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(442, 451);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Berechtigungen";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 22);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(125, 19);
            checkBox2.TabIndex = 0;
            checkBox2.Text = "Eiskalter Vollzugriff";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 47);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 19);
            checkBox3.TabIndex = 1;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 72);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(83, 19);
            checkBox4.TabIndex = 2;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 97);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(83, 19);
            checkBox5.TabIndex = 3;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(6, 122);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(83, 19);
            checkBox6.TabIndex = 4;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(6, 147);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(83, 19);
            checkBox7.TabIndex = 5;
            checkBox7.Text = "checkBox7";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(6, 172);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(83, 19);
            checkBox8.TabIndex = 6;
            checkBox8.Text = "checkBox8";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(6, 197);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(83, 19);
            checkBox9.TabIndex = 7;
            checkBox9.Text = "checkBox9";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(6, 222);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(89, 19);
            checkBox10.TabIndex = 8;
            checkBox10.Text = "checkBox10";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(6, 247);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(89, 19);
            checkBox11.TabIndex = 9;
            checkBox11.Text = "checkBox11";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(6, 272);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(89, 19);
            checkBox12.TabIndex = 10;
            checkBox12.Text = "checkBox12";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(6, 297);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(89, 19);
            checkBox13.TabIndex = 11;
            checkBox13.Text = "checkBox13";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(6, 322);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(89, 19);
            checkBox14.TabIndex = 12;
            checkBox14.Text = "checkBox14";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point(6, 347);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(89, 19);
            checkBox15.TabIndex = 13;
            checkBox15.Text = "checkBox15";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(6, 372);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(89, 19);
            checkBox16.TabIndex = 14;
            checkBox16.Text = "checkBox16";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            checkBox17.AutoSize = true;
            checkBox17.Location = new Point(6, 397);
            checkBox17.Name = "checkBox17";
            checkBox17.Size = new Size(89, 19);
            checkBox17.TabIndex = 15;
            checkBox17.Text = "checkBox17";
            checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            checkBox18.AutoSize = true;
            checkBox18.Location = new Point(6, 422);
            checkBox18.Name = "checkBox18";
            checkBox18.Size = new Size(89, 19);
            checkBox18.TabIndex = 16;
            checkBox18.Text = "checkBox18";
            checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            checkBox19.AutoSize = true;
            checkBox19.Location = new Point(137, 47);
            checkBox19.Name = "checkBox19";
            checkBox19.Size = new Size(89, 19);
            checkBox19.TabIndex = 17;
            checkBox19.Text = "checkBox19";
            checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            checkBox20.AutoSize = true;
            checkBox20.Location = new Point(137, 72);
            checkBox20.Name = "checkBox20";
            checkBox20.Size = new Size(89, 19);
            checkBox20.TabIndex = 18;
            checkBox20.Text = "checkBox20";
            checkBox20.UseVisualStyleBackColor = true;
            // 
            // checkBox21
            // 
            checkBox21.AutoSize = true;
            checkBox21.Location = new Point(137, 97);
            checkBox21.Name = "checkBox21";
            checkBox21.Size = new Size(89, 19);
            checkBox21.TabIndex = 19;
            checkBox21.Text = "checkBox21";
            checkBox21.UseVisualStyleBackColor = true;
            // 
            // checkBox22
            // 
            checkBox22.AutoSize = true;
            checkBox22.Location = new Point(137, 22);
            checkBox22.Name = "checkBox22";
            checkBox22.Size = new Size(138, 19);
            checkBox22.TabIndex = 20;
            checkBox22.Text = "With GRANT OPTION";
            checkBox22.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 463);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBox_MYSQL_Passwort;
        private System.Windows.Forms.CheckBox checkBox1;
        private GroupBox groupBox2;
        private CheckBox checkBox22;
        private CheckBox checkBox21;
        private CheckBox checkBox20;
        private CheckBox checkBox19;
        private CheckBox checkBox18;
        private CheckBox checkBox17;
        private CheckBox checkBox16;
        private CheckBox checkBox15;
        private CheckBox checkBox14;
        private CheckBox checkBox13;
        private CheckBox checkBox12;
        private CheckBox checkBox11;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
    }
}

