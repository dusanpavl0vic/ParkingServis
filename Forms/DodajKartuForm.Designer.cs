namespace ParkingServis.Forms
{
    partial class DodajKartuForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericSerijskiBroj = new System.Windows.Forms.NumericUpDown();
            this.dateDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOdVreme = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateDoVreme = new System.Windows.Forms.DateTimePicker();
            this.numericIDOsobe = new System.Windows.Forms.NumericUpDown();
            this.numericIDVozila = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonIdOsobe = new System.Windows.Forms.Button();
            this.buttonIDVozila = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSerijskiBroj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDOsobe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDVozila)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(123, 462);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(129, 48);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Sacuvaj";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Serijski Broj";
            // 
            // numericSerijskiBroj
            // 
            this.numericSerijskiBroj.Location = new System.Drawing.Point(44, 54);
            this.numericSerijskiBroj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericSerijskiBroj.Name = "numericSerijskiBroj";
            this.numericSerijskiBroj.Size = new System.Drawing.Size(160, 22);
            this.numericSerijskiBroj.TabIndex = 3;
            // 
            // dateDatum
            // 
            this.dateDatum.Location = new System.Drawing.Point(44, 118);
            this.dateDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDatum.Name = "dateDatum";
            this.dateDatum.Size = new System.Drawing.Size(285, 22);
            this.dateDatum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "OdVreme";
            // 
            // dateOdVreme
            // 
            this.dateOdVreme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateOdVreme.Location = new System.Drawing.Point(44, 186);
            this.dateOdVreme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateOdVreme.Name = "dateOdVreme";
            this.dateOdVreme.ShowUpDown = true;
            this.dateOdVreme.Size = new System.Drawing.Size(285, 22);
            this.dateOdVreme.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "DoVreme";
            // 
            // dateDoVreme
            // 
            this.dateDoVreme.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateDoVreme.Location = new System.Drawing.Point(44, 256);
            this.dateDoVreme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDoVreme.Name = "dateDoVreme";
            this.dateDoVreme.ShowUpDown = true;
            this.dateDoVreme.Size = new System.Drawing.Size(285, 22);
            this.dateDoVreme.TabIndex = 10;
            // 
            // numericIDOsobe
            // 
            this.numericIDOsobe.Location = new System.Drawing.Point(44, 327);
            this.numericIDOsobe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericIDOsobe.Name = "numericIDOsobe";
            this.numericIDOsobe.Size = new System.Drawing.Size(160, 22);
            this.numericIDOsobe.TabIndex = 11;
            // 
            // numericIDVozila
            // 
            this.numericIDVozila.Location = new System.Drawing.Point(44, 402);
            this.numericIDVozila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericIDVozila.Name = "numericIDVozila";
            this.numericIDVozila.Size = new System.Drawing.Size(160, 22);
            this.numericIDVozila.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 308);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "IDOsobe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 383);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "IDVozila";
            // 
            // buttonIdOsobe
            // 
            this.buttonIdOsobe.Location = new System.Drawing.Point(231, 324);
            this.buttonIdOsobe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIdOsobe.Name = "buttonIdOsobe";
            this.buttonIdOsobe.Size = new System.Drawing.Size(100, 28);
            this.buttonIdOsobe.TabIndex = 15;
            this.buttonIdOsobe.Text = "Odaberi";
            this.buttonIdOsobe.UseVisualStyleBackColor = true;
            this.buttonIdOsobe.Click += new System.EventHandler(this.buttonIdOsobe_Click);
            // 
            // buttonIDVozila
            // 
            this.buttonIDVozila.Location = new System.Drawing.Point(231, 399);
            this.buttonIDVozila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonIDVozila.Name = "buttonIDVozila";
            this.buttonIDVozila.Size = new System.Drawing.Size(100, 28);
            this.buttonIDVozila.TabIndex = 16;
            this.buttonIDVozila.Text = "Odaberi";
            this.buttonIDVozila.UseVisualStyleBackColor = true;
            this.buttonIDVozila.Click += new System.EventHandler(this.buttonIDVozila_Click);
            // 
            // DodajKartuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 538);
            this.Controls.Add(this.buttonIDVozila);
            this.Controls.Add(this.buttonIdOsobe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericIDVozila);
            this.Controls.Add(this.numericIDOsobe);
            this.Controls.Add(this.dateDoVreme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateOdVreme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateDatum);
            this.Controls.Add(this.numericSerijskiBroj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DodajKartuForm";
            this.Text = "DodajKartuForm";
            this.Load += new System.EventHandler(this.DodajKartuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSerijskiBroj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDOsobe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericIDVozila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericSerijskiBroj;
        private System.Windows.Forms.DateTimePicker dateDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateOdVreme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateDoVreme;
        private System.Windows.Forms.NumericUpDown numericIDOsobe;
        private System.Windows.Forms.NumericUpDown numericIDVozila;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonIdOsobe;
        private System.Windows.Forms.Button buttonIDVozila;
    }
}