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
            this.label1 = new System.Windows.Forms.Label();
            this.btnOtworzDodajPacjentaForm = new System.Windows.Forms.Button();
            this.btnSzukajPacjenta = new System.Windows.Forms.Button();
            this.txtSzukajNazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpecjalizacja = new System.Windows.Forms.TextBox();
            this.btnSzukajLekarzy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(280, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj! Zalogowałes sie poprawnie!";
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
            this.btnSzukajPacjenta.Location = new System.Drawing.Point(513, 159);
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
            this.txtSzukajNazwisko.Location = new System.Drawing.Point(339, 159);
            this.txtSzukajNazwisko.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSzukajNazwisko.Name = "txtSzukajNazwisko";
            this.txtSzukajNazwisko.Size = new System.Drawing.Size(148, 26);
            this.txtSzukajNazwisko.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Podaj nazwisko pacjenta:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wyszukaj lekarza po specjalizacji:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtSpecjalizacja
            // 
            this.txtSpecjalizacja.Location = new System.Drawing.Point(339, 227);
            this.txtSpecjalizacja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSpecjalizacja.Name = "txtSpecjalizacja";
            this.txtSpecjalizacja.Size = new System.Drawing.Size(148, 26);
            this.txtSpecjalizacja.TabIndex = 7;
            // 
            // btnSzukajLekarzy
            // 
            this.btnSzukajLekarzy.Location = new System.Drawing.Point(513, 225);
            this.btnSzukajLekarzy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSzukajLekarzy.Name = "btnSzukajLekarzy";
            this.btnSzukajLekarzy.Size = new System.Drawing.Size(184, 31);
            this.btnSzukajLekarzy.TabIndex = 6;
            this.btnSzukajLekarzy.Text = "Wyszukaj Lekarza";
            this.btnSzukajLekarzy.UseVisualStyleBackColor = true;
            this.btnSzukajLekarzy.Click += new System.EventHandler(this.btnSzukajLekarzy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSpecjalizacja);
            this.Controls.Add(this.btnSzukajLekarzy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSzukajNazwisko);
            this.Controls.Add(this.btnSzukajPacjenta);
            this.Controls.Add(this.btnOtworzDodajPacjentaForm);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOtworzDodajPacjentaForm;
        private System.Windows.Forms.Button btnSzukajPacjenta;
        private System.Windows.Forms.TextBox txtSzukajNazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpecjalizacja;
        private System.Windows.Forms.Button btnSzukajLekarzy;
    }
}

