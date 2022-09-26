namespace ViseFormi
{
    partial class formStudenti
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
            this.btnDodajNovog = new System.Windows.Forms.Button();
            this.btnObrisiSve = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDodajNovog
            // 
            this.btnDodajNovog.Location = new System.Drawing.Point(21, 12);
            this.btnDodajNovog.Name = "btnDodajNovog";
            this.btnDodajNovog.Size = new System.Drawing.Size(139, 23);
            this.btnDodajNovog.TabIndex = 1;
            this.btnDodajNovog.Text = "Dodaj novog studenta";
            this.btnDodajNovog.UseVisualStyleBackColor = true;
            this.btnDodajNovog.Click += new System.EventHandler(this.btnDodajNovog_Click);
            // 
            // btnObrisiSve
            // 
            this.btnObrisiSve.Location = new System.Drawing.Point(21, 259);
            this.btnObrisiSve.Name = "btnObrisiSve";
            this.btnObrisiSve.Size = new System.Drawing.Size(139, 23);
            this.btnObrisiSve.TabIndex = 2;
            this.btnObrisiSve.Text = "Obrisi sve studente";
            this.btnObrisiSve.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(363, 127);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(105, 23);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi studenta";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 199);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // formStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 303);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnObrisiSve);
            this.Controls.Add(this.btnDodajNovog);
            this.Name = "formStudenti";
            this.Text = "Studenti";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDodajNovog;
        private System.Windows.Forms.Button btnObrisiSve;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.ListBox listBox1;
    }
}

