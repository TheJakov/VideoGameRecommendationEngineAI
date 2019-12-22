namespace sustavZaPreporukuVideoIgara.Forme
{
    partial class DevetoPitanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevetoPitanje));
            this.lblDrugoPitanje = new System.Windows.Forms.Label();
            this.cbJakoVazno = new System.Windows.Forms.CheckBox();
            this.cbVazno = new System.Windows.Forms.CheckBox();
            this.cbSvejedno = new System.Windows.Forms.CheckBox();
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
            this.lblDrugoPitanje.Size = new System.Drawing.Size(676, 29);
            this.lblDrugoPitanje.TabIndex = 20;
            this.lblDrugoPitanje.Text = "Koliko ti je bitno prilagođavanje (eng. customization) kod igre?";
            // 
            // cbJakoVazno
            // 
            this.cbJakoVazno.AutoSize = true;
            this.cbJakoVazno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJakoVazno.Location = new System.Drawing.Point(92, 197);
            this.cbJakoVazno.Name = "cbJakoVazno";
            this.cbJakoVazno.Size = new System.Drawing.Size(135, 29);
            this.cbJakoVazno.TabIndex = 25;
            this.cbJakoVazno.Text = "Jako važno";
            this.cbJakoVazno.UseVisualStyleBackColor = true;
            // 
            // cbVazno
            // 
            this.cbVazno.AutoSize = true;
            this.cbVazno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVazno.Location = new System.Drawing.Point(92, 153);
            this.cbVazno.Name = "cbVazno";
            this.cbVazno.Size = new System.Drawing.Size(91, 29);
            this.cbVazno.TabIndex = 24;
            this.cbVazno.Text = "Važno";
            this.cbVazno.UseVisualStyleBackColor = true;
            // 
            // cbSvejedno
            // 
            this.cbSvejedno.AutoSize = true;
            this.cbSvejedno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSvejedno.Location = new System.Drawing.Point(92, 109);
            this.cbSvejedno.Name = "cbSvejedno";
            this.cbSvejedno.Size = new System.Drawing.Size(117, 29);
            this.cbSvejedno.TabIndex = 23;
            this.cbSvejedno.Text = "Svejedno";
            this.cbSvejedno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Moguće označiti samo 1 opciju. ";
            // 
            // lblBrojPitanja
            // 
            this.lblBrojPitanja.AutoSize = true;
            this.lblBrojPitanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPitanja.Location = new System.Drawing.Point(22, 484);
            this.lblBrojPitanja.Name = "lblBrojPitanja";
            this.lblBrojPitanja.Size = new System.Drawing.Size(71, 29);
            this.lblBrojPitanja.TabIndex = 29;
            this.lblBrojPitanja.Text = "9 / 17";
            // 
            // btnSljedece
            // 
            this.btnSljedece.Location = new System.Drawing.Point(656, 481);
            this.btnSljedece.Name = "btnSljedece";
            this.btnSljedece.Size = new System.Drawing.Size(125, 42);
            this.btnSljedece.TabIndex = 34;
            this.btnSljedece.Text = "Sljedeće";
            this.btnSljedece.UseVisualStyleBackColor = true;
            this.btnSljedece.Click += new System.EventHandler(this.btnSljedece_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(112, 481);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 42);
            this.btnOdustani.TabIndex = 33;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // DevetoPitanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 542);
            this.Controls.Add(this.btnSljedece);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblBrojPitanja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbJakoVazno);
            this.Controls.Add(this.cbVazno);
            this.Controls.Add(this.cbSvejedno);
            this.Controls.Add(this.lblDrugoPitanje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 589);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 589);
            this.Name = "DevetoPitanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prilagođavanje (eng. customization)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrugoPitanje;
        private System.Windows.Forms.CheckBox cbJakoVazno;
        private System.Windows.Forms.CheckBox cbVazno;
        private System.Windows.Forms.CheckBox cbSvejedno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojPitanja;
        private System.Windows.Forms.Button btnSljedece;
        private System.Windows.Forms.Button btnOdustani;
    }
}