namespace AS2122_4E_INF_BenziAlessandro_GestioneArticoli
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAggiungiModifica = new System.Windows.Forms.Button();
            this.txtCodice = new System.Windows.Forms.TextBox();
            this.cmbUnitaMisura = new System.Windows.Forms.ComboBox();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.txtPrezzo = new System.Windows.Forms.TextBox();
            this.cmbVisualizza = new System.Windows.Forms.ComboBox();
            this.lstElenco = new System.Windows.Forms.ListBox();
            this.btnVisualizza = new System.Windows.Forms.Button();
            this.lblArticoliInseriti = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrizione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unità di misura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prezzo";
            // 
            // btnAggiungiModifica
            // 
            this.btnAggiungiModifica.Location = new System.Drawing.Point(25, 214);
            this.btnAggiungiModifica.Name = "btnAggiungiModifica";
            this.btnAggiungiModifica.Size = new System.Drawing.Size(227, 45);
            this.btnAggiungiModifica.TabIndex = 4;
            this.btnAggiungiModifica.Text = "Aggiungi/modifica articolo";
            this.btnAggiungiModifica.UseVisualStyleBackColor = true;
            this.btnAggiungiModifica.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCodice
            // 
            this.txtCodice.Location = new System.Drawing.Point(131, 48);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 23);
            this.txtCodice.TabIndex = 5;
            this.txtCodice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbUnitaMisura
            // 
            this.cmbUnitaMisura.FormattingEnabled = true;
            this.cmbUnitaMisura.Location = new System.Drawing.Point(131, 126);
            this.cmbUnitaMisura.Name = "cmbUnitaMisura";
            this.cmbUnitaMisura.Size = new System.Drawing.Size(121, 23);
            this.cmbUnitaMisura.TabIndex = 6;
            this.cmbUnitaMisura.SelectedIndexChanged += new System.EventHandler(this.cmbUnitaMisura_SelectedIndexChanged);
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.Location = new System.Drawing.Point(131, 84);
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(100, 23);
            this.txtDescrizione.TabIndex = 7;
            this.txtDescrizione.TextChanged += new System.EventHandler(this.txtDescrizione_TextChanged);
            // 
            // txtPrezzo
            // 
            this.txtPrezzo.Location = new System.Drawing.Point(131, 172);
            this.txtPrezzo.Name = "txtPrezzo";
            this.txtPrezzo.Size = new System.Drawing.Size(100, 23);
            this.txtPrezzo.TabIndex = 8;
            this.txtPrezzo.TextChanged += new System.EventHandler(this.txtPrezzo_TextChanged);
            // 
            // cmbVisualizza
            // 
            this.cmbVisualizza.FormattingEnabled = true;
            this.cmbVisualizza.Location = new System.Drawing.Point(456, 69);
            this.cmbVisualizza.Name = "cmbVisualizza";
            this.cmbVisualizza.Size = new System.Drawing.Size(143, 23);
            this.cmbVisualizza.TabIndex = 9;
            this.cmbVisualizza.SelectedIndexChanged += new System.EventHandler(this.cmbVisualizza_SelectedIndexChanged);
            // 
            // lstElenco
            // 
            this.lstElenco.FormattingEnabled = true;
            this.lstElenco.ItemHeight = 15;
            this.lstElenco.Location = new System.Drawing.Point(456, 117);
            this.lstElenco.Name = "lstElenco";
            this.lstElenco.Size = new System.Drawing.Size(234, 259);
            this.lstElenco.TabIndex = 10;
            this.lstElenco.SelectedIndexChanged += new System.EventHandler(this.lstElenco_SelectedIndexChanged);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(628, 69);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizza.TabIndex = 11;
            this.btnVisualizza.Text = "...";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // lblArticoliInseriti
            // 
            this.lblArticoliInseriti.AutoSize = true;
            this.lblArticoliInseriti.Location = new System.Drawing.Point(102, 361);
            this.lblArticoliInseriti.Name = "lblArticoliInseriti";
            this.lblArticoliInseriti.Size = new System.Drawing.Size(45, 15);
            this.lblArticoliInseriti.TabIndex = 12;
            this.lblArticoliInseriti.Text = "Articoli";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrezzo);
            this.groupBox1.Controls.Add(this.btnAggiungiModifica);
            this.groupBox1.Controls.Add(this.txtDescrizione);
            this.groupBox1.Controls.Add(this.cmbUnitaMisura);
            this.groupBox1.Location = new System.Drawing.Point(102, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 283);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dettagli articolo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblArticoliInseriti);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.lstElenco);
            this.Controls.Add(this.cmbVisualizza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAggiungiModifica;
        private TextBox txtCodice;
        private ComboBox cmbUnitaMisura;
        private TextBox txtDescrizione;
        private TextBox txtPrezzo;
        private ComboBox cmbVisualizza;
        private ListBox lstElenco;
        private Button btnVisualizza;
        private Label lblArticoliInseriti;
        private GroupBox groupBox1;
    }
}