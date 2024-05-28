namespace ParkingServis.Forms
{
    partial class IzmeniParkingMesto
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
            this.comboTrenutniStatus = new System.Windows.Forms.ComboBox();
            this.comboTipParkingMesta = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericRedniBroj = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericSprat = new System.Windows.Forms.NumericUpDown();
            this.textZona = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textNazivUlice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericID = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericRedniBroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSprat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).BeginInit();
            this.SuspendLayout();
            // 
            // comboTrenutniStatus
            // 
            this.comboTrenutniStatus.FormattingEnabled = true;
            this.comboTrenutniStatus.Items.AddRange(new object[] {
            "Zauzeto",
            "Slobodno"});
            this.comboTrenutniStatus.Location = new System.Drawing.Point(35, 144);
            this.comboTrenutniStatus.Name = "comboTrenutniStatus";
            this.comboTrenutniStatus.Size = new System.Drawing.Size(121, 21);
            this.comboTrenutniStatus.TabIndex = 40;
            // 
            // comboTipParkingMesta
            // 
            this.comboTipParkingMesta.FormattingEnabled = true;
            this.comboTipParkingMesta.Items.AddRange(new object[] {
            "NaUlici",
            "JavnoParkingMesto"});
            this.comboTipParkingMesta.Location = new System.Drawing.Point(35, 196);
            this.comboTipParkingMesta.Name = "comboTipParkingMesta";
            this.comboTipParkingMesta.Size = new System.Drawing.Size(121, 21);
            this.comboTipParkingMesta.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(238, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Redni Broj";
            // 
            // numericRedniBroj
            // 
            this.numericRedniBroj.Location = new System.Drawing.Point(241, 248);
            this.numericRedniBroj.Name = "numericRedniBroj";
            this.numericRedniBroj.Size = new System.Drawing.Size(120, 20);
            this.numericRedniBroj.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Sprat";
            // 
            // numericSprat
            // 
            this.numericSprat.Location = new System.Drawing.Point(241, 196);
            this.numericSprat.Name = "numericSprat";
            this.numericSprat.Size = new System.Drawing.Size(120, 20);
            this.numericSprat.TabIndex = 35;
            // 
            // textZona
            // 
            this.textZona.Location = new System.Drawing.Point(241, 140);
            this.textZona.Name = "textZona";
            this.textZona.Size = new System.Drawing.Size(100, 20);
            this.textZona.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Zona";
            // 
            // textNazivUlice
            // 
            this.textNazivUlice.Location = new System.Drawing.Point(241, 92);
            this.textNazivUlice.Name = "textNazivUlice";
            this.textNazivUlice.Size = new System.Drawing.Size(100, 20);
            this.textNazivUlice.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Naziv Ulice";
            // 
            // numericID
            // 
            this.numericID.Location = new System.Drawing.Point(35, 92);
            this.numericID.Name = "numericID";
            this.numericID.Size = new System.Drawing.Size(120, 20);
            this.numericID.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tip Parking Mesta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Trenutni Status";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(156, 346);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 37);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Sacuvaj";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID";
            // 
            // IzmeniParkingMesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 428);
            this.Controls.Add(this.comboTrenutniStatus);
            this.Controls.Add(this.comboTipParkingMesta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericRedniBroj);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericSprat);
            this.Controls.Add(this.textZona);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textNazivUlice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Name = "IzmeniParkingMesto";
            this.Text = "IzmeniParkingMesto";
            this.Load += new System.EventHandler(this.IzmeniParkingMesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericRedniBroj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSprat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTrenutniStatus;
        private System.Windows.Forms.ComboBox comboTipParkingMesta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericRedniBroj;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericSprat;
        private System.Windows.Forms.TextBox textZona;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNazivUlice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
    }
}