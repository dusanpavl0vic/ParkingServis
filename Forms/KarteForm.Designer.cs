namespace ParkingServis
{
    partial class KarteForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonIzbrisi = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listaKarta = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonIzmeni);
            this.groupBox2.Controls.Add(this.buttonIzbrisi);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Location = new System.Drawing.Point(408, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 153);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podaci o pretplatnim kartama";
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Location = new System.Drawing.Point(6, 63);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(209, 38);
            this.buttonIzmeni.TabIndex = 2;
            this.buttonIzmeni.Text = "Izmeni podatke o kartama";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            // 
            // buttonIzbrisi
            // 
            this.buttonIzbrisi.Location = new System.Drawing.Point(6, 107);
            this.buttonIzbrisi.Name = "buttonIzbrisi";
            this.buttonIzbrisi.Size = new System.Drawing.Size(209, 38);
            this.buttonIzbrisi.TabIndex = 1;
            this.buttonIzbrisi.Text = "Obrisi kartu";
            this.buttonIzbrisi.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(209, 38);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Dodaj kartu";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listaKarta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 397);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Pretplatnih Karata";
            // 
            // listaKarta
            // 
            this.listaKarta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5});
            this.listaKarta.FullRowSelect = true;
            this.listaKarta.HideSelection = false;
            this.listaKarta.Location = new System.Drawing.Point(7, 21);
            this.listaKarta.Name = "listaKarta";
            this.listaKarta.Size = new System.Drawing.Size(347, 365);
            this.listaKarta.TabIndex = 1;
            this.listaKarta.UseCompatibleStateImageBehavior = false;
            this.listaKarta.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SerijskiBroj";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Datum";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vazi od";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vazi do";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(408, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 64);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Podaci o iskoriscenim kartama";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 38);
            this.button3.TabIndex = 0;
            this.button3.Text = "Iskoriscene karte";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // KarteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 417);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "KarteForm";
            this.Text = "Pregled karta";
            this.Load += new System.EventHandler(this.KarteForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonIzbrisi;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listaKarta;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
    }
}