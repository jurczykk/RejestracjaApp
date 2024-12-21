namespace RejestracjaApp
{
    partial class DodajPacjentaForm
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
            this.txtImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtDataUrodzenia = new System.Windows.Forms.TextBox();
            this.txtPesel = new System.Windows.Forms.TextBox();
            this.btnDodajPacjenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(161, 117);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(100, 20);
            this.txtImie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj dane nowego pacjenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nazwisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Urodzenia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pesel:";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(161, 154);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(100, 20);
            this.txtNazwisko.TabIndex = 6;
            // 
            // txtDataUrodzenia
            // 
            this.txtDataUrodzenia.Location = new System.Drawing.Point(161, 194);
            this.txtDataUrodzenia.Name = "txtDataUrodzenia";
            this.txtDataUrodzenia.Size = new System.Drawing.Size(100, 20);
            this.txtDataUrodzenia.TabIndex = 7;
            // 
            // txtPesel
            // 
            this.txtPesel.Location = new System.Drawing.Point(161, 236);
            this.txtPesel.Name = "txtPesel";
            this.txtPesel.Size = new System.Drawing.Size(100, 20);
            this.txtPesel.TabIndex = 8;
            // 
            // btnDodajPacjenta
            // 
            this.btnDodajPacjenta.Location = new System.Drawing.Point(161, 291);
            this.btnDodajPacjenta.Name = "btnDodajPacjenta";
            this.btnDodajPacjenta.Size = new System.Drawing.Size(75, 23);
            this.btnDodajPacjenta.TabIndex = 9;
            this.btnDodajPacjenta.Text = "Zapisz";
            this.btnDodajPacjenta.UseVisualStyleBackColor = true;
            this.btnDodajPacjenta.Click += new System.EventHandler(this.btnDodajPacjenta_Click);
            // 
            // DodajPacjentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajPacjenta);
            this.Controls.Add(this.txtPesel);
            this.Controls.Add(this.txtDataUrodzenia);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImie);
            this.Name = "DodajPacjentaForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtDataUrodzenia;
        private System.Windows.Forms.TextBox txtPesel;
        private System.Windows.Forms.Button btnDodajPacjenta;
    }
}