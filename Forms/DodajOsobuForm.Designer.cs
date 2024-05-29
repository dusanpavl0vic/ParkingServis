namespace ParkingServis.Forms
{
    partial class DodajOsobuForm
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
            this.numericID = new System.Windows.Forms.NumericUpDown();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.textAdresa = new System.Windows.Forms.TextBox();
            this.labelLicnoIme = new System.Windows.Forms.Label();
            this.textLicnoIme = new System.Windows.Forms.TextBox();
            this.labelImeRoditelja = new System.Windows.Forms.Label();
            this.textImeRoditelja = new System.Windows.Forms.TextBox();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.textPrezime = new System.Windows.Forms.TextBox();
            this.labelJMBG = new System.Windows.Forms.Label();
            this.textJMBG = new System.Windows.Forms.TextBox();
            this.labelBrojLicen = new System.Windows.Forms.Label();
            this.textBrojLicneKarte = new System.Windows.Forms.TextBox();
            this.labelMestoIzdanjaLicne = new System.Windows.Forms.Label();
            this.textMestoIzdanjaLicne = new System.Windows.Forms.TextBox();
            this.labelBrojVozackeDozvole = new System.Windows.Forms.Label();
            this.textBrojVozackeDozvole = new System.Windows.Forms.TextBox();
            this.labelZona = new System.Windows.Forms.Label();
            this.textZona = new System.Windows.Forms.TextBox();
            this.labelPIB = new System.Windows.Forms.Label();
            this.textPIB = new System.Windows.Forms.TextBox();
            this.comboOsobaType = new System.Windows.Forms.ComboBox();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.textNaziv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).BeginInit();
            this.SuspendLayout();
            // 
            // numericID
            // 
            this.numericID.Location = new System.Drawing.Point(43, 55);
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(120, 20);
            this.numericID.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(40, 39);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "ID";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(222, 375);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 44);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Sacuvaj";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.Location = new System.Drawing.Point(40, 95);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(22, 13);
            this.labelTip.TabIndex = 4;
            this.labelTip.Text = "Tip";
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(40, 148);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(40, 13);
            this.labelAdresa.TabIndex = 6;
            this.labelAdresa.Text = "Adresa";
            // 
            // textAdresa
            // 
            this.textAdresa.Location = new System.Drawing.Point(43, 164);
            this.textAdresa.Name = "textAdresa";
            this.textAdresa.Size = new System.Drawing.Size(120, 20);
            this.textAdresa.TabIndex = 5;
            // 
            // labelLicnoIme
            // 
            this.labelLicnoIme.AutoSize = true;
            this.labelLicnoIme.Location = new System.Drawing.Point(40, 206);
            this.labelLicnoIme.Name = "labelLicnoIme";
            this.labelLicnoIme.Size = new System.Drawing.Size(53, 13);
            this.labelLicnoIme.TabIndex = 8;
            this.labelLicnoIme.Text = "Licko Ime";
            // 
            // textLicnoIme
            // 
            this.textLicnoIme.Location = new System.Drawing.Point(43, 222);
            this.textLicnoIme.Name = "textLicnoIme";
            this.textLicnoIme.Size = new System.Drawing.Size(120, 20);
            this.textLicnoIme.TabIndex = 7;
            // 
            // labelImeRoditelja
            // 
            this.labelImeRoditelja.AutoSize = true;
            this.labelImeRoditelja.Location = new System.Drawing.Point(40, 262);
            this.labelImeRoditelja.Name = "labelImeRoditelja";
            this.labelImeRoditelja.Size = new System.Drawing.Size(68, 13);
            this.labelImeRoditelja.TabIndex = 10;
            this.labelImeRoditelja.Text = "Ime Roditelja";
            // 
            // textImeRoditelja
            // 
            this.textImeRoditelja.Location = new System.Drawing.Point(43, 278);
            this.textImeRoditelja.Name = "textImeRoditelja";
            this.textImeRoditelja.Size = new System.Drawing.Size(120, 20);
            this.textImeRoditelja.TabIndex = 9;
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(219, 39);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(44, 13);
            this.labelPrezime.TabIndex = 12;
            this.labelPrezime.Text = "Prezime";
            // 
            // textPrezime
            // 
            this.textPrezime.Location = new System.Drawing.Point(222, 55);
            this.textPrezime.Name = "textPrezime";
            this.textPrezime.Size = new System.Drawing.Size(120, 20);
            this.textPrezime.TabIndex = 11;
            // 
            // labelJMBG
            // 
            this.labelJMBG.AutoSize = true;
            this.labelJMBG.Location = new System.Drawing.Point(219, 95);
            this.labelJMBG.Name = "labelJMBG";
            this.labelJMBG.Size = new System.Drawing.Size(36, 13);
            this.labelJMBG.TabIndex = 14;
            this.labelJMBG.Text = "JMBG";
            // 
            // textJMBG
            // 
            this.textJMBG.Location = new System.Drawing.Point(222, 111);
            this.textJMBG.Name = "textJMBG";
            this.textJMBG.Size = new System.Drawing.Size(120, 20);
            this.textJMBG.TabIndex = 13;
            // 
            // labelBrojLicen
            // 
            this.labelBrojLicen.AutoSize = true;
            this.labelBrojLicen.Location = new System.Drawing.Point(219, 148);
            this.labelBrojLicen.Name = "labelBrojLicen";
            this.labelBrojLicen.Size = new System.Drawing.Size(82, 13);
            this.labelBrojLicen.TabIndex = 16;
            this.labelBrojLicen.Text = "Broj Licne Karte";
            // 
            // textBrojLicneKarte
            // 
            this.textBrojLicneKarte.Location = new System.Drawing.Point(222, 164);
            this.textBrojLicneKarte.Name = "textBrojLicneKarte";
            this.textBrojLicneKarte.Size = new System.Drawing.Size(120, 20);
            this.textBrojLicneKarte.TabIndex = 15;
            // 
            // labelMestoIzdanjaLicne
            // 
            this.labelMestoIzdanjaLicne.AutoSize = true;
            this.labelMestoIzdanjaLicne.Location = new System.Drawing.Point(219, 206);
            this.labelMestoIzdanjaLicne.Name = "labelMestoIzdanjaLicne";
            this.labelMestoIzdanjaLicne.Size = new System.Drawing.Size(102, 13);
            this.labelMestoIzdanjaLicne.TabIndex = 18;
            this.labelMestoIzdanjaLicne.Text = "Mesto Izdanja Licne";
            // 
            // textMestoIzdanjaLicne
            // 
            this.textMestoIzdanjaLicne.Location = new System.Drawing.Point(222, 222);
            this.textMestoIzdanjaLicne.Name = "textMestoIzdanjaLicne";
            this.textMestoIzdanjaLicne.Size = new System.Drawing.Size(120, 20);
            this.textMestoIzdanjaLicne.TabIndex = 17;
            // 
            // labelBrojVozackeDozvole
            // 
            this.labelBrojVozackeDozvole.AutoSize = true;
            this.labelBrojVozackeDozvole.Location = new System.Drawing.Point(219, 262);
            this.labelBrojVozackeDozvole.Name = "labelBrojVozackeDozvole";
            this.labelBrojVozackeDozvole.Size = new System.Drawing.Size(112, 13);
            this.labelBrojVozackeDozvole.TabIndex = 20;
            this.labelBrojVozackeDozvole.Text = "Broj Vozacke Dozvole";
            // 
            // textBrojVozackeDozvole
            // 
            this.textBrojVozackeDozvole.Location = new System.Drawing.Point(222, 278);
            this.textBrojVozackeDozvole.Name = "textBrojVozackeDozvole";
            this.textBrojVozackeDozvole.Size = new System.Drawing.Size(120, 20);
            this.textBrojVozackeDozvole.TabIndex = 19;
            // 
            // labelZona
            // 
            this.labelZona.AutoSize = true;
            this.labelZona.Location = new System.Drawing.Point(399, 39);
            this.labelZona.Name = "labelZona";
            this.labelZona.Size = new System.Drawing.Size(32, 13);
            this.labelZona.TabIndex = 22;
            this.labelZona.Text = "Zona";
            // 
            // textZona
            // 
            this.textZona.Location = new System.Drawing.Point(402, 55);
            this.textZona.Name = "textZona";
            this.textZona.Size = new System.Drawing.Size(120, 20);
            this.textZona.TabIndex = 21;
            // 
            // labelPIB
            // 
            this.labelPIB.AutoSize = true;
            this.labelPIB.Location = new System.Drawing.Point(219, 95);
            this.labelPIB.Name = "labelPIB";
            this.labelPIB.Size = new System.Drawing.Size(24, 13);
            this.labelPIB.TabIndex = 24;
            this.labelPIB.Text = "PIB";
            // 
            // textPIB
            // 
            this.textPIB.Location = new System.Drawing.Point(222, 111);
            this.textPIB.Name = "textPIB";
            this.textPIB.Size = new System.Drawing.Size(120, 20);
            this.textPIB.TabIndex = 23;
            // 
            // comboOsobaType
            // 
            this.comboOsobaType.FormattingEnabled = true;
            this.comboOsobaType.Items.AddRange(new object[] {
            "FizickoLice",
            "PravnoLice"});
            this.comboOsobaType.Location = new System.Drawing.Point(43, 110);
            this.comboOsobaType.Name = "comboOsobaType";
            this.comboOsobaType.Size = new System.Drawing.Size(120, 21);
            this.comboOsobaType.TabIndex = 25;
            this.comboOsobaType.SelectedIndexChanged += new System.EventHandler(this.comboOsobaType_SelectedIndexChanged);
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.Location = new System.Drawing.Point(219, 148);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(34, 13);
            this.labelNaziv.TabIndex = 27;
            this.labelNaziv.Text = "Naziv";
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(222, 164);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(120, 20);
            this.textNaziv.TabIndex = 26;
            // 
            // DodajOsobuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 450);
            this.Controls.Add(this.labelNaziv);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.comboOsobaType);
            this.Controls.Add(this.labelPIB);
            this.Controls.Add(this.textPIB);
            this.Controls.Add(this.labelZona);
            this.Controls.Add(this.textZona);
            this.Controls.Add(this.labelBrojVozackeDozvole);
            this.Controls.Add(this.textBrojVozackeDozvole);
            this.Controls.Add(this.labelMestoIzdanjaLicne);
            this.Controls.Add(this.textMestoIzdanjaLicne);
            this.Controls.Add(this.labelBrojLicen);
            this.Controls.Add(this.textBrojLicneKarte);
            this.Controls.Add(this.labelJMBG);
            this.Controls.Add(this.textJMBG);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.textPrezime);
            this.Controls.Add(this.labelImeRoditelja);
            this.Controls.Add(this.textImeRoditelja);
            this.Controls.Add(this.labelLicnoIme);
            this.Controls.Add(this.textLicnoIme);
            this.Controls.Add(this.labelAdresa);
            this.Controls.Add(this.textAdresa);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.numericID);
            this.Name = "DodajOsobuForm";
            this.Text = "DodajOsobuForm";
            this.Load += new System.EventHandler(this.DodajOsobuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.TextBox textAdresa;
        private System.Windows.Forms.Label labelLicnoIme;
        private System.Windows.Forms.TextBox textLicnoIme;
        private System.Windows.Forms.Label labelImeRoditelja;
        private System.Windows.Forms.TextBox textImeRoditelja;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.TextBox textPrezime;
        private System.Windows.Forms.Label labelJMBG;
        private System.Windows.Forms.TextBox textJMBG;
        private System.Windows.Forms.Label labelBrojLicen;
        private System.Windows.Forms.TextBox textBrojLicneKarte;
        private System.Windows.Forms.Label labelMestoIzdanjaLicne;
        private System.Windows.Forms.TextBox textMestoIzdanjaLicne;
        private System.Windows.Forms.Label labelBrojVozackeDozvole;
        private System.Windows.Forms.TextBox textBrojVozackeDozvole;
        private System.Windows.Forms.Label labelZona;
        private System.Windows.Forms.TextBox textZona;
        private System.Windows.Forms.Label labelPIB;
        private System.Windows.Forms.TextBox textPIB;
        private System.Windows.Forms.ComboBox comboOsobaType;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.TextBox textNaziv;
    }
}