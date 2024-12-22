namespace RejestracjaApp
{
    partial class LogowanieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogowanie = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtHaslo = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogowanie
            // 
            this.btnLogowanie.BackColor = System.Drawing.Color.LightBlue;
            this.btnLogowanie.Location = new System.Drawing.Point(267, 325);
            this.btnLogowanie.Name = "btnLogowanie";
            this.btnLogowanie.Size = new System.Drawing.Size(158, 34);
            this.btnLogowanie.TabIndex = 3;
            this.btnLogowanie.Text = "Zaloguj";
            this.btnLogowanie.UseVisualStyleBackColor = false;
            this.btnLogowanie.Click += new System.EventHandler(this.btnLogowanie_Click);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(314, 170);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(136, 26);
            this.txtLogin.TabIndex = 4;
            // 
            // txtHaslo
            // 
            this.txtHaslo.Location = new System.Drawing.Point(314, 217);
            this.txtHaslo.Name = "txtHaslo";
            this.txtHaslo.Size = new System.Drawing.Size(136, 26);
            this.txtHaslo.TabIndex = 5;
            this.txtHaslo.UseSystemPasswordChar = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(90, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(248, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Witaj! Zaloguj sie w systemie przychodni!";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroTile1
            // 
            this.metroTile1.Controls.Add(this.metroLabel3);
            this.metroTile1.Controls.Add(this.metroLabel2);
            this.metroTile1.Controls.Add(this.metroLabel1);
            this.metroTile1.Location = new System.Drawing.Point(59, 86);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(536, 202);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "\r\n";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(90, 131);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Hasło:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(90, 84);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Login:";
            // 
            // LogowanieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.txtHaslo);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.btnLogowanie);
            this.Controls.Add(this.metroTile1);
            this.Name = "LogowanieForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "NovaPrzychodnia";
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogowanie;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtHaslo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}