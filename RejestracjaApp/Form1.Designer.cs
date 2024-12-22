namespace RejestracjaApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOtworzDodajPacjentaForm = new System.Windows.Forms.Button();
            this.btnSzukajPacjenta = new System.Windows.Forms.Button();
            this.txtSzukajNazwisko = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpecjalizacja = new System.Windows.Forms.TextBox();
            this.btnSzukajLekarzy = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOtworzDodajPacjentaForm
            // 
            this.btnOtworzDodajPacjentaForm.Location = new System.Drawing.Point(85, 351);
            this.btnOtworzDodajPacjentaForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOtworzDodajPacjentaForm.Name = "btnOtworzDodajPacjentaForm";
            this.btnOtworzDodajPacjentaForm.Size = new System.Drawing.Size(224, 34);
            this.btnOtworzDodajPacjentaForm.TabIndex = 1;
            this.btnOtworzDodajPacjentaForm.Text = "Dodaj Nowego Pacjenta";
            this.btnOtworzDodajPacjentaForm.UseVisualStyleBackColor = true;
            this.btnOtworzDodajPacjentaForm.Click += new System.EventHandler(this.btnOtworzDodajPacjentaForm_Click);
            // 
            // btnSzukajPacjenta
            // 
            this.btnSzukajPacjenta.Location = new System.Drawing.Point(604, 157);
            this.btnSzukajPacjenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSzukajPacjenta.Name = "btnSzukajPacjenta";
            this.btnSzukajPacjenta.Size = new System.Drawing.Size(184, 31);
            this.btnSzukajPacjenta.TabIndex = 2;
            this.btnSzukajPacjenta.Text = "Wyszukaj Pacjenta";
            this.btnSzukajPacjenta.UseVisualStyleBackColor = true;
            this.btnSzukajPacjenta.Click += new System.EventHandler(this.btnSzukajPacjenta_Click);
            // 
            // txtSzukajNazwisko
            // 
            this.txtSzukajNazwisko.Location = new System.Drawing.Point(430, 157);
            this.txtSzukajNazwisko.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSzukajNazwisko.Name = "txtSzukajNazwisko";
            this.txtSzukajNazwisko.Size = new System.Drawing.Size(148, 26);
            this.txtSzukajNazwisko.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Akcje:";
            // 
            // txtSpecjalizacja
            // 
            this.txtSpecjalizacja.Location = new System.Drawing.Point(430, 225);
            this.txtSpecjalizacja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSpecjalizacja.Name = "txtSpecjalizacja";
            this.txtSpecjalizacja.Size = new System.Drawing.Size(148, 26);
            this.txtSpecjalizacja.TabIndex = 7;
            // 
            // btnSzukajLekarzy
            // 
            this.btnSzukajLekarzy.Location = new System.Drawing.Point(604, 223);
            this.btnSzukajLekarzy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSzukajLekarzy.Name = "btnSzukajLekarzy";
            this.btnSzukajLekarzy.Size = new System.Drawing.Size(184, 31);
            this.btnSzukajLekarzy.TabIndex = 6;
            this.btnSzukajLekarzy.Text = "Wyszukaj Lekarza";
            this.btnSzukajLekarzy.UseVisualStyleBackColor = true;
            this.btnSzukajLekarzy.Click += new System.EventHandler(this.btnSzukajLekarzy_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.metroLabel1.Location = new System.Drawing.Point(307, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(201, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Witaj! Zalogwałeś się poprawnie!";
            // 
            // metroTile1
            // 
            this.metroTile1.Controls.Add(this.metroLabel3);
            this.metroTile1.Controls.Add(this.metroLabel2);
            this.metroTile1.Location = new System.Drawing.Point(71, 130);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(767, 149);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 11;
            this.metroTile1.Text = "\r\n";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 31);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(153, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Podaj nazwisko pacjenta:";
            this.metroLabel2.UseStyleColors = true;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(198, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Wyszukaj lekarza po specjalizacji";
            this.metroLabel3.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 449);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSpecjalizacja);
            this.Controls.Add(this.btnSzukajLekarzy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSzukajNazwisko);
            this.Controls.Add(this.btnSzukajPacjenta);
            this.Controls.Add(this.btnOtworzDodajPacjentaForm);
            this.Controls.Add(this.metroTile1);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTile1.ResumeLayout(false);
            this.metroTile1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOtworzDodajPacjentaForm;
        private System.Windows.Forms.Button btnSzukajPacjenta;
        private System.Windows.Forms.TextBox txtSzukajNazwisko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpecjalizacja;
        private System.Windows.Forms.Button btnSzukajLekarzy;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}

