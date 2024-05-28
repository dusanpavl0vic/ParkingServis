namespace ParkingServis.Forms
{
    partial class IzmeniParking
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
            this.inputTipParkinga = new System.Windows.Forms.ComboBox();
            this.inputMontazniObjekat = new System.Windows.Forms.ComboBox();
            this.inputID = new System.Windows.Forms.NumericUpDown();
            this.inputNivoi = new System.Windows.Forms.NumericUpDown();
            this.inputSpratovi = new System.Windows.Forms.NumericUpDown();
            this.inputBrojParkingMesta = new System.Windows.Forms.NumericUpDown();
            this.DoVreme = new System.Windows.Forms.DateTimePicker();
            this.OdVreme = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textZona = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAdresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNivoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpratovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBrojParkingMesta)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTipParkinga
            // 
            this.inputTipParkinga.FormattingEnabled = true;
            this.inputTipParkinga.Items.AddRange(new object[] {
            "Podzemna",
            "Nadzemna"});
            this.inputTipParkinga.Location = new System.Drawing.Point(193, 86);
            this.inputTipParkinga.Name = "inputTipParkinga";
            this.inputTipParkinga.Size = new System.Drawing.Size(121, 21);
            this.inputTipParkinga.TabIndex = 52;
            // 
            // inputMontazniObjekat
            // 
            this.inputMontazniObjekat.FormattingEnabled = true;
            this.inputMontazniObjekat.Items.AddRange(new object[] {
            "Montazni",
            "NijeMontazni"});
            this.inputMontazniObjekat.Location = new System.Drawing.Point(193, 36);
            this.inputMontazniObjekat.Name = "inputMontazniObjekat";
            this.inputMontazniObjekat.Size = new System.Drawing.Size(121, 21);
            this.inputMontazniObjekat.TabIndex = 51;
            // 
            // inputID
            // 
            this.inputID.Location = new System.Drawing.Point(51, 36);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(120, 20);
            this.inputID.TabIndex = 50;
            this.inputID.ValueChanged += new System.EventHandler(this.inputID_ValueChanged);
            // 
            // inputNivoi
            // 
            this.inputNivoi.Location = new System.Drawing.Point(193, 198);
            this.inputNivoi.Name = "inputNivoi";
            this.inputNivoi.Size = new System.Drawing.Size(120, 20);
            this.inputNivoi.TabIndex = 49;
            // 
            // inputSpratovi
            // 
            this.inputSpratovi.Location = new System.Drawing.Point(193, 143);
            this.inputSpratovi.Name = "inputSpratovi";
            this.inputSpratovi.Size = new System.Drawing.Size(120, 20);
            this.inputSpratovi.TabIndex = 48;
            // 
            // inputBrojParkingMesta
            // 
            this.inputBrojParkingMesta.Location = new System.Drawing.Point(193, 253);
            this.inputBrojParkingMesta.Name = "inputBrojParkingMesta";
            this.inputBrojParkingMesta.Size = new System.Drawing.Size(120, 20);
            this.inputBrojParkingMesta.TabIndex = 47;
            // 
            // DoVreme
            // 
            this.DoVreme.Location = new System.Drawing.Point(51, 309);
            this.DoVreme.Name = "DoVreme";
            this.DoVreme.Size = new System.Drawing.Size(100, 20);
            this.DoVreme.TabIndex = 46;
            // 
            // OdVreme
            // 
            this.OdVreme.Location = new System.Drawing.Point(51, 253);
            this.OdVreme.Name = "OdVreme";
            this.OdVreme.Size = new System.Drawing.Size(100, 20);
            this.OdVreme.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(190, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Nivoi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(190, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Spratovi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(190, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Tip Parkinga";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Naziv";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Broj Parking Mesta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Vreme do";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Vreme od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Adresa";
            // 
            // textZona
            // 
            this.textZona.Location = new System.Drawing.Point(51, 198);
            this.textZona.Name = "textZona";
            this.textZona.Size = new System.Drawing.Size(100, 20);
            this.textZona.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Zona";
            // 
            // textAdresa
            // 
            this.textAdresa.Location = new System.Drawing.Point(51, 143);
            this.textAdresa.Name = "textAdresa";
            this.textAdresa.Size = new System.Drawing.Size(100, 20);
            this.textAdresa.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Montazni Objekat";
            // 
            // textNaziv
            // 
            this.textNaziv.Location = new System.Drawing.Point(51, 86);
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(100, 20);
            this.textNaziv.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(131, 359);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 37);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "Sacuvaj";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // IzmeniParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 425);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inputTipParkinga);
            this.Controls.Add(this.inputMontazniObjekat);
            this.Controls.Add(this.inputID);
            this.Controls.Add(this.inputNivoi);
            this.Controls.Add(this.inputSpratovi);
            this.Controls.Add(this.inputBrojParkingMesta);
            this.Controls.Add(this.DoVreme);
            this.Controls.Add(this.OdVreme);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
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
            this.Name = "IzmeniParking";
            this.Text = "IzmeniParking";
            this.Load += new System.EventHandler(this.IzmeniParking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNivoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSpratovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputBrojParkingMesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox inputTipParkinga;
        private System.Windows.Forms.ComboBox inputMontazniObjekat;
        private System.Windows.Forms.NumericUpDown inputID;
        private System.Windows.Forms.NumericUpDown inputNivoi;
        private System.Windows.Forms.NumericUpDown inputSpratovi;
        private System.Windows.Forms.NumericUpDown inputBrojParkingMesta;
        private System.Windows.Forms.DateTimePicker DoVreme;
        private System.Windows.Forms.DateTimePicker OdVreme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textZona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAdresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
    }
}