namespace ParkingServis.Forms
{
    partial class DodajIskoriscenuKartu
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateVremeIzvrsenja = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOdVreme = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDateDo = new System.Windows.Forms.DateTimePicker();
            this.numericVoziloId = new System.Windows.Forms.NumericUpDown();
            this.buttonIDVozila = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonIDPArkingMesta = new System.Windows.Forms.Button();
            this.numericParkingMestoId = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonIDKarte = new System.Windows.Forms.Button();
            this.numericKartaId = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVoziloId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericParkingMestoId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKartaId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(63, 55);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(187, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // dateVremeIzvrsenja
            // 
            this.dateVremeIzvrsenja.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateVremeIzvrsenja.Location = new System.Drawing.Point(63, 113);
            this.dateVremeIzvrsenja.Margin = new System.Windows.Forms.Padding(4);
            this.dateVremeIzvrsenja.Name = "dateVremeIzvrsenja";
            this.dateVremeIzvrsenja.ShowUpDown = true;
            this.dateVremeIzvrsenja.Size = new System.Drawing.Size(187, 22);
            this.dateVremeIzvrsenja.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Vreme Izvrsene Kontrole";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Vreme Od";
            // 
            // dateOdVreme
            // 
            this.dateOdVreme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateOdVreme.Location = new System.Drawing.Point(63, 173);
            this.dateOdVreme.Margin = new System.Windows.Forms.Padding(4);
            this.dateOdVreme.Name = "dateOdVreme";
            this.dateOdVreme.ShowUpDown = true;
            this.dateOdVreme.Size = new System.Drawing.Size(187, 22);
            this.dateOdVreme.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Vreme Do";
            // 
            // dateDateDo
            // 
            this.dateDateDo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateDateDo.Location = new System.Drawing.Point(63, 239);
            this.dateDateDo.Margin = new System.Windows.Forms.Padding(4);
            this.dateDateDo.Name = "dateDateDo";
            this.dateDateDo.ShowUpDown = true;
            this.dateDateDo.Size = new System.Drawing.Size(187, 22);
            this.dateDateDo.TabIndex = 29;
            // 
            // numericVoziloId
            // 
            this.numericVoziloId.Location = new System.Drawing.Point(50, 298);
            this.numericVoziloId.Name = "numericVoziloId";
            this.numericVoziloId.Size = new System.Drawing.Size(120, 22);
            this.numericVoziloId.TabIndex = 31;
            // 
            // buttonIDVozila
            // 
            this.buttonIDVozila.Location = new System.Drawing.Point(187, 297);
            this.buttonIDVozila.Name = "buttonIDVozila";
            this.buttonIDVozila.Size = new System.Drawing.Size(75, 23);
            this.buttonIDVozila.TabIndex = 32;
            this.buttonIDVozila.Text = "Odaberi";
            this.buttonIDVozila.UseVisualStyleBackColor = true;
            this.buttonIDVozila.Click += new System.EventHandler(this.buttonIDOsobe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "ID Vozila";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "ID Parking Mesta";
            // 
            // buttonIDPArkingMesta
            // 
            this.buttonIDPArkingMesta.Location = new System.Drawing.Point(187, 350);
            this.buttonIDPArkingMesta.Name = "buttonIDPArkingMesta";
            this.buttonIDPArkingMesta.Size = new System.Drawing.Size(75, 23);
            this.buttonIDPArkingMesta.TabIndex = 35;
            this.buttonIDPArkingMesta.Text = "Odaberi";
            this.buttonIDPArkingMesta.UseVisualStyleBackColor = true;
            this.buttonIDPArkingMesta.Click += new System.EventHandler(this.buttonIDPArkingMesta_Click);
            // 
            // numericParkingMestoId
            // 
            this.numericParkingMestoId.Location = new System.Drawing.Point(50, 351);
            this.numericParkingMestoId.Name = "numericParkingMestoId";
            this.numericParkingMestoId.Size = new System.Drawing.Size(120, 22);
            this.numericParkingMestoId.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "ID Karte";
            // 
            // buttonIDKarte
            // 
            this.buttonIDKarte.Location = new System.Drawing.Point(187, 404);
            this.buttonIDKarte.Name = "buttonIDKarte";
            this.buttonIDKarte.Size = new System.Drawing.Size(75, 23);
            this.buttonIDKarte.TabIndex = 38;
            this.buttonIDKarte.Text = "Odaberi";
            this.buttonIDKarte.UseVisualStyleBackColor = true;
            this.buttonIDKarte.Click += new System.EventHandler(this.buttonIDKarte_Click);
            // 
            // numericKartaId
            // 
            this.numericKartaId.Location = new System.Drawing.Point(50, 405);
            this.numericKartaId.Name = "numericKartaId";
            this.numericKartaId.Size = new System.Drawing.Size(120, 22);
            this.numericKartaId.TabIndex = 37;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(95, 464);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 42);
            this.buttonSave.TabIndex = 40;
            this.buttonSave.Text = "Odaberi";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // DodajIskoriscenuKartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 528);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonIDKarte);
            this.Controls.Add(this.numericKartaId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonIDPArkingMesta);
            this.Controls.Add(this.numericParkingMestoId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonIDVozila);
            this.Controls.Add(this.numericVoziloId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateDateDo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateOdVreme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateVremeIzvrsenja);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "DodajIskoriscenuKartu";
            this.Text = "DodajIskoriscenuKartu";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericVoziloId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericParkingMestoId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKartaId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateVremeIzvrsenja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateOdVreme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDateDo;
        private System.Windows.Forms.NumericUpDown numericVoziloId;
        private System.Windows.Forms.Button buttonIDVozila;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonIDPArkingMesta;
        private System.Windows.Forms.NumericUpDown numericParkingMestoId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonIDKarte;
        private System.Windows.Forms.NumericUpDown numericKartaId;
        private System.Windows.Forms.Button buttonSave;
    }
}