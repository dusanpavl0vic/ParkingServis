namespace ParkingServis.Forms
{
    partial class DodajZakupForm
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
            this.dateOdVreme = new System.Windows.Forms.DateTimePicker();
            this.dateDoVreme = new System.Windows.Forms.DateTimePicker();
            this.dateDatumPotpisa = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericId = new System.Windows.Forms.NumericUpDown();
            this.numericIdOsobe = new System.Windows.Forms.NumericUpDown();
            this.buttonOdaberiOsobu = new System.Windows.Forms.Button();
            this.buttonOdaberiVozilo = new System.Windows.Forms.Button();
            this.numericIdVozila = new System.Windows.Forms.NumericUpDown();
            this.buttonOdaberiParkingMesto = new System.Windows.Forms.Button();
            this.numericIdParkingMesta = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdOsobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdVozila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdParkingMesta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // dateOdVreme
            // 
            this.dateOdVreme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateOdVreme.Location = new System.Drawing.Point(69, 124);
            this.dateOdVreme.Margin = new System.Windows.Forms.Padding(4);
            this.dateOdVreme.Name = "dateOdVreme";
            this.dateOdVreme.ShowUpDown = true;
            this.dateOdVreme.Size = new System.Drawing.Size(200, 22);
            this.dateOdVreme.TabIndex = 25;
            // 
            // dateDoVreme
            // 
            this.dateDoVreme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateDoVreme.Location = new System.Drawing.Point(69, 191);
            this.dateDoVreme.Margin = new System.Windows.Forms.Padding(4);
            this.dateDoVreme.Name = "dateDoVreme";
            this.dateDoVreme.ShowUpDown = true;
            this.dateDoVreme.Size = new System.Drawing.Size(200, 22);
            this.dateDoVreme.TabIndex = 26;
            // 
            // dateDatumPotpisa
            // 
            this.dateDatumPotpisa.Location = new System.Drawing.Point(69, 254);
            this.dateDatumPotpisa.Name = "dateDatumPotpisa";
            this.dateDatumPotpisa.Size = new System.Drawing.Size(200, 22);
            this.dateDatumPotpisa.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 46);
            this.button1.TabIndex = 28;
            this.button1.Text = "Sacuvaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Datum Potpisa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Vreme Do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Vreme Od";
            // 
            // numericId
            // 
            this.numericId.Location = new System.Drawing.Point(69, 66);
            this.numericId.Name = "numericId";
            this.numericId.Size = new System.Drawing.Size(200, 22);
            this.numericId.TabIndex = 32;
            // 
            // numericIdOsobe
            // 
            this.numericIdOsobe.Location = new System.Drawing.Point(57, 316);
            this.numericIdOsobe.Name = "numericIdOsobe";
            this.numericIdOsobe.Size = new System.Drawing.Size(111, 22);
            this.numericIdOsobe.TabIndex = 33;
            // 
            // buttonOdaberiOsobu
            // 
            this.buttonOdaberiOsobu.Location = new System.Drawing.Point(188, 310);
            this.buttonOdaberiOsobu.Name = "buttonOdaberiOsobu";
            this.buttonOdaberiOsobu.Size = new System.Drawing.Size(107, 33);
            this.buttonOdaberiOsobu.TabIndex = 34;
            this.buttonOdaberiOsobu.Text = "Odaberi";
            this.buttonOdaberiOsobu.UseVisualStyleBackColor = true;
            this.buttonOdaberiOsobu.Click += new System.EventHandler(this.buttonOdaberiOsobu_Click);
            // 
            // buttonOdaberiVozilo
            // 
            this.buttonOdaberiVozilo.Location = new System.Drawing.Point(188, 366);
            this.buttonOdaberiVozilo.Name = "buttonOdaberiVozilo";
            this.buttonOdaberiVozilo.Size = new System.Drawing.Size(107, 33);
            this.buttonOdaberiVozilo.TabIndex = 36;
            this.buttonOdaberiVozilo.Text = "Odaberi";
            this.buttonOdaberiVozilo.UseVisualStyleBackColor = true;
            this.buttonOdaberiVozilo.Click += new System.EventHandler(this.buttonOdaberiVozilo_Click);
            // 
            // numericIdVozila
            // 
            this.numericIdVozila.Location = new System.Drawing.Point(57, 372);
            this.numericIdVozila.Name = "numericIdVozila";
            this.numericIdVozila.Size = new System.Drawing.Size(111, 22);
            this.numericIdVozila.TabIndex = 35;
            // 
            // buttonOdaberiParkingMesto
            // 
            this.buttonOdaberiParkingMesto.Location = new System.Drawing.Point(188, 424);
            this.buttonOdaberiParkingMesto.Name = "buttonOdaberiParkingMesto";
            this.buttonOdaberiParkingMesto.Size = new System.Drawing.Size(107, 33);
            this.buttonOdaberiParkingMesto.TabIndex = 38;
            this.buttonOdaberiParkingMesto.Text = "Odaberi";
            this.buttonOdaberiParkingMesto.UseVisualStyleBackColor = true;
            this.buttonOdaberiParkingMesto.Click += new System.EventHandler(this.buttonOdaberiParkingMesto_Click);
            // 
            // numericIdParkingMesta
            // 
            this.numericIdParkingMesta.Location = new System.Drawing.Point(57, 430);
            this.numericIdParkingMesta.Name = "numericIdParkingMesta";
            this.numericIdParkingMesta.Size = new System.Drawing.Size(111, 22);
            this.numericIdParkingMesta.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Id Osobe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Id Vozila";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Id Parking Mesta";
            // 
            // DodajZakupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 567);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonOdaberiParkingMesto);
            this.Controls.Add(this.numericIdParkingMesta);
            this.Controls.Add(this.buttonOdaberiVozilo);
            this.Controls.Add(this.numericIdVozila);
            this.Controls.Add(this.buttonOdaberiOsobu);
            this.Controls.Add(this.numericIdOsobe);
            this.Controls.Add(this.numericId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateDatumPotpisa);
            this.Controls.Add(this.dateDoVreme);
            this.Controls.Add(this.dateOdVreme);
            this.Controls.Add(this.label1);
            this.Name = "DodajZakupForm";
            this.Text = "Dodaj Zakup";
            ((System.ComponentModel.ISupportInitialize)(this.numericId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdOsobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdVozila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIdParkingMesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateOdVreme;
        private System.Windows.Forms.DateTimePicker dateDoVreme;
        private System.Windows.Forms.DateTimePicker dateDatumPotpisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericId;
        private System.Windows.Forms.NumericUpDown numericIdOsobe;
        private System.Windows.Forms.Button buttonOdaberiOsobu;
        private System.Windows.Forms.Button buttonOdaberiVozilo;
        private System.Windows.Forms.NumericUpDown numericIdVozila;
        private System.Windows.Forms.Button buttonOdaberiParkingMesto;
        private System.Windows.Forms.NumericUpDown numericIdParkingMesta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}