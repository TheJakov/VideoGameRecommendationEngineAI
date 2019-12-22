namespace sustavZaPreporukuVideoIgara.Forme
{
    partial class DvanaestoPitanje
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
            this.lblDrugoPitanje = new System.Windows.Forms.Label();
            this.cb2010 = new System.Windows.Forms.CheckBox();
            this.cb2000 = new System.Windows.Forms.CheckBox();
            this.cb90 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrojPitanja = new System.Windows.Forms.Label();
            this.btnSljedece = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDrugoPitanje
            // 
            this.lblDrugoPitanje.AutoSize = true;
            this.lblDrugoPitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrugoPitanje.Location = new System.Drawing.Point(42, 42);
            this.lblDrugoPitanje.Name = "lblDrugoPitanje";
            this.lblDrugoPitanje.Size = new System.Drawing.Size(503, 29);
            this.lblDrugoPitanje.TabIndex = 23;
            this.lblDrugoPitanje.Text = "Koje je tvoje željeno razdoblje nastanka igre ?";
            // 
            // cb2010
            // 
            this.cb2010.AutoSize = true;
            this.cb2010.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2010.Location = new System.Drawing.Point(94, 191);
            this.cb2010.Name = "cb2010";
            this.cb2010.Size = new System.Drawing.Size(259, 29);
            this.cb2010.TabIndex = 35;
            this.cb2010.Text = "Nakon 2010  (2010-2019)";
            this.cb2010.UseVisualStyleBackColor = true;
            // 
            // cb2000
            // 
            this.cb2000.AutoSize = true;
            this.cb2000.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2000.Location = new System.Drawing.Point(94, 147);
            this.cb2000.Name = "cb2000";
            this.cb2000.Size = new System.Drawing.Size(251, 29);
            this.cb2000.TabIndex = 34;
            this.cb2000.Text = "Dvijetisućite (2000-2009)";
            this.cb2000.UseVisualStyleBackColor = true;
            // 
            // cb90
            // 
            this.cb90.AutoSize = true;
            this.cb90.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb90.Location = new System.Drawing.Point(94, 103);
            this.cb90.Name = "cb90";
            this.cb90.Size = new System.Drawing.Size(198, 29);
            this.cb90.TabIndex = 33;
            this.cb90.Text = "Devedesete (90-e)";
            this.cb90.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Moguće označiti samo 1 opciju. ";
            // 
            // lblBrojPitanja
            // 
            this.lblBrojPitanja.AutoSize = true;
            this.lblBrojPitanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPitanja.Location = new System.Drawing.Point(22, 484);
            this.lblBrojPitanja.Name = "lblBrojPitanja";
            this.lblBrojPitanja.Size = new System.Drawing.Size(84, 29);
            this.lblBrojPitanja.TabIndex = 37;
            this.lblBrojPitanja.Text = "12 / 17";
            // 
            // btnSljedece
            // 
            this.btnSljedece.Location = new System.Drawing.Point(656, 481);
            this.btnSljedece.Name = "btnSljedece";
            this.btnSljedece.Size = new System.Drawing.Size(125, 42);
            this.btnSljedece.TabIndex = 40;
            this.btnSljedece.Text = "Sljedeće";
            this.btnSljedece.UseVisualStyleBackColor = true;
            this.btnSljedece.Click += new System.EventHandler(this.btnSljedece_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(112, 481);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 42);
            this.btnOdustani.TabIndex = 39;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // DvanaestoPitanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 542);
            this.Controls.Add(this.btnSljedece);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblBrojPitanja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb2010);
            this.Controls.Add(this.cb2000);
            this.Controls.Add(this.cb90);
            this.Controls.Add(this.lblDrugoPitanje);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 589);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 589);
            this.Name = "DvanaestoPitanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Razdoblje nastanka igre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrugoPitanje;
        private System.Windows.Forms.CheckBox cb2010;
        private System.Windows.Forms.CheckBox cb2000;
        private System.Windows.Forms.CheckBox cb90;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojPitanja;
        private System.Windows.Forms.Button btnSljedece;
        private System.Windows.Forms.Button btnOdustani;
    }
}