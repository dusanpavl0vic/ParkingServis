namespace ParkingServis.Forms
{
    partial class DodajParking
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textZona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelSpratovi = new System.Windows.Forms.Label();
            this.labelNivoi = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.OdVreme = new System.Windows.Forms.DateTimePicker();
            this.DoVreme = new System.Windows.Forms.DateTimePicker();
            this.inputBrojParkingMesta = new System.Windows.Forms.NumericUpDown();
            this.inputSpratovi = new System.Windows.Forms.NumericUpDown();
            this.inputNivoi = new System.Windows.Forms.NumericUpDown();
            this.inputID = new System.Windows.Forms.NumericUpDown();
            this.inputMontazniObjekat = new System.Windows.Forms.ComboBox();
            this.inputTipParkinga = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.inputBrojParkingMesta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpratovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNivoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Montazni Objekat";
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(59, 186);
            this.textNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(159, 22);
            this.textNaziv.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zona";
            // 
            // textAdresa
            // 
            this.textAdresa.Location = new System.Drawing.Point(59, 256);
            this.textAdresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textAdresa.Name = "textAdresa";
            this.textAdresa.Size = new System.Drawing.Size(159, 22);
            this.textAdresa.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresa";
            // 
            // textZona
            // 
            this.textZona.Location = new System.Drawing.Point(248, 113);
            this.textZona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textZona.Name = "textZona";
            this.textZona.Size = new System.Drawing.Size(159, 22);
            this.textZona.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vreme od";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vreme do";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Broj Parking Mesta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 166);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Naziv";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tip Parkinga";
            // 
            // labelSpratovi
            // 
            this.labelSpratovi.AutoSize = true;
            this.labelSpratovi.Location = new System.Drawing.Point(244, 303);
            this.labelSpratovi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSpratovi.Name = "labelSpratovi";
            this.labelSpratovi.Size = new System.Drawing.Size(57, 16);
            this.labelSpratovi.TabIndex = 19;
            this.labelSpratovi.Text = "Spratovi";
            // 
            // labelNivoi
            // 
            this.labelNivoi.AutoSize = true;
            this.labelNivoi.Location = new System.Drawing.Point(245, 304);
            this.labelNivoi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNivoi.Name = "labelNivoi";
            this.labelNivoi.Size = new System.Drawing.Size(38, 16);
            this.labelNivoi.TabIndex = 21;
            this.labelNivoi.Text = "Nivoi";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(189, 395);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 43);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Sacuvaj";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // OdVreme
            // 
            this.OdVreme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.OdVreme.Location = new System.Drawing.Point(59, 324);
            this.OdVreme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OdVreme.Name = "OdVreme";
            this.OdVreme.ShowUpDown = true;
            this.OdVreme.Size = new System.Drawing.Size(159, 22);
            this.OdVreme.TabIndex = 23;
            // 
            // DoVreme
            // 
            this.DoVreme.Location = new System.Drawing.Point(248, 256);
            this.DoVreme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoVreme.Name = "DoVreme";
            this.DoVreme.Size = new System.Drawing.Size(159, 22);
            this.DoVreme.TabIndex = 24;
            // 
            // inputBrojParkingMesta
            // 
            this.inputBrojParkingMesta.Location = new System.Drawing.Point(248, 188);
            this.inputBrojParkingMesta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputBrojParkingMesta.Name = "inputBrojParkingMesta";
            this.inputBrojParkingMesta.Size = new System.Drawing.Size(160, 22);
            this.inputBrojParkingMesta.TabIndex = 25;
            // 
            // inputSpratovi
            // 
            this.inputSpratovi.Location = new System.Drawing.Point(248, 322);
            this.inputSpratovi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputSpratovi.Name = "inputSpratovi";
            this.inputSpratovi.Size = new System.Drawing.Size(160, 22);
            this.inputSpratovi.TabIndex = 26;
            // 
            // inputNivoi
            // 
            this.inputNivoi.Location = new System.Drawing.Point(249, 324);
            this.inputNivoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputNivoi.Name = "inputNivoi";
            this.inputNivoi.Size = new System.Drawing.Size(160, 22);
            this.inputNivoi.TabIndex = 27;
            // 
            // inputID
            // 
            this.inputID.Location = new System.Drawing.Point(59, 57);
            this.inputID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(160, 22);
            this.inputID.TabIndex = 28;
            // 
            // inputMontazniObjekat
            // 
            this.inputMontazniObjekat.FormattingEnabled = true;
            this.inputMontazniObjekat.Items.AddRange(new object[] {
            "Montazni",
            "NijeMontazni"});
            this.inputMontazniObjekat.Location = new System.Drawing.Point(248, 57);
            this.inputMontazniObjekat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputMontazniObjekat.Name = "inputMontazniObjekat";
            this.inputMontazniObjekat.Size = new System.Drawing.Size(160, 24);
            this.inputMontazniObjekat.TabIndex = 29;
            // 
            // inputTipParkinga
            // 
            this.inputTipParkinga.FormattingEnabled = true;
            this.inputTipParkinga.Items.AddRange(new object[] {
            "Podzemna",
            "Nadzemna"});
            this.inputTipParkinga.Location = new System.Drawing.Point(59, 113);
            this.inputTipParkinga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputTipParkinga.Name = "inputTipParkinga";
            this.inputTipParkinga.Size = new System.Drawing.Size(160, 24);
            this.inputTipParkinga.TabIndex = 30;
            this.inputTipParkinga.SelectedIndexChanged += new System.EventHandler(this.inputTipParkinga_SelectedIndexChanged);
            // 
            // DodajParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 471);
            this.Controls.Add(this.inputTipParkinga);
            this.Controls.Add(this.inputMontazniObjekat);
            this.Controls.Add(this.inputID);
            this.Controls.Add(this.inputNivoi);
            this.Controls.Add(this.inputSpratovi);
            this.Controls.Add(this.inputBrojParkingMesta);
            this.Controls.Add(this.DoVreme);
            this.Controls.Add(this.OdVreme);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelNivoi);
            this.Controls.Add(this.labelSpratovi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textZona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodajParking";
            this.Text = "DodajParking";
            this.Load += new System.EventHandler(this.DodajParking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputBrojParkingMesta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpratovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNivoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textZona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSpratovi;
        private System.Windows.Forms.Label labelNivoi;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker OdVreme;
        private System.Windows.Forms.DateTimePicker DoVreme;
        private System.Windows.Forms.NumericUpDown inputBrojParkingMesta;
        private System.Windows.Forms.NumericUpDown inputSpratovi;
        private System.Windows.Forms.NumericUpDown inputNivoi;
        private System.Windows.Forms.NumericUpDown inputID;
        private System.Windows.Forms.ComboBox inputMontazniObjekat;
        private System.Windows.Forms.ComboBox inputTipParkinga;
    }
}