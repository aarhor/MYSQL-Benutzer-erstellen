
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
            this.btn_Speichern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtBox_Passwort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBox_MYSQL_Passwort = new System.Windows.Forms.TextBox();
            this.txtBox_MYSQL_Benutzer = new System.Windows.Forms.TextBox();
            this.txtBox_MYSQL_IP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.Location = new System.Drawing.Point(94, 222);
            this.btn_Speichern.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Speichern.Name = "btn_Speichern";
            this.btn_Speichern.Size = new System.Drawing.Size(88, 27);
            this.btn_Speichern.TabIndex = 3;
            this.btn_Speichern.Text = "Speichern";
            this.btn_Speichern.UseVisualStyleBackColor = true;
            this.btn_Speichern.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(94, 7);
            this.txtBox_Name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(179, 23);
            this.txtBox_Name.TabIndex = 1;
            this.txtBox_Name.Text = "srv-db-";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(94, 67);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 124);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtBox_Passwort
            // 
            this.txtBox_Passwort.Location = new System.Drawing.Point(94, 37);
            this.txtBox_Passwort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_Passwort.Name = "txtBox_Passwort";
            this.txtBox_Passwort.PasswordChar = '*';
            this.txtBox_Passwort.Size = new System.Drawing.Size(179, 23);
            this.txtBox_Passwort.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passwort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datenbank:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtBox_MYSQL_Passwort);
            this.groupBox1.Controls.Add(this.txtBox_MYSQL_Benutzer);
            this.groupBox1.Controls.Add(this.txtBox_MYSQL_IP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 255);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(260, 203);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MYSQL Einstellungen";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 167);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Testen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBox_MYSQL_Passwort
            // 
            this.txtBox_MYSQL_Passwort.Location = new System.Drawing.Point(7, 137);
            this.txtBox_MYSQL_Passwort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_MYSQL_Passwort.Name = "txtBox_MYSQL_Passwort";
            this.txtBox_MYSQL_Passwort.PasswordChar = '*';
            this.txtBox_MYSQL_Passwort.Size = new System.Drawing.Size(179, 23);
            this.txtBox_MYSQL_Passwort.TabIndex = 10;
            this.txtBox_MYSQL_Passwort.Text = "giCi)GpH28,7i>`Tec?N8UtV5";
            // 
            // txtBox_MYSQL_Benutzer
            // 
            this.txtBox_MYSQL_Benutzer.Location = new System.Drawing.Point(7, 89);
            this.txtBox_MYSQL_Benutzer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_MYSQL_Benutzer.Name = "txtBox_MYSQL_Benutzer";
            this.txtBox_MYSQL_Benutzer.Size = new System.Drawing.Size(179, 23);
            this.txtBox_MYSQL_Benutzer.TabIndex = 9;
            this.txtBox_MYSQL_Benutzer.Text = "pi";
            // 
            // txtBox_MYSQL_IP
            // 
            this.txtBox_MYSQL_IP.Location = new System.Drawing.Point(7, 40);
            this.txtBox_MYSQL_IP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBox_MYSQL_IP.Name = "txtBox_MYSQL_IP";
            this.txtBox_MYSQL_IP.Size = new System.Drawing.Size(179, 23);
            this.txtBox_MYSQL_IP.TabIndex = 8;
            this.txtBox_MYSQL_IP.Text = "192.168.0.3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "MYSQL Passwort:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "MYSQL Benutzer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server IP-Adresse:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(94, 197);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Bereits vorhanden";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 463);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_Passwort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Speichern);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "MYSQL Benutzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

