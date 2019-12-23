namespace sustavZaPreporukuVideoIgara.Forme
{
    partial class SesnaestoPitanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SesnaestoPitanje));
            this.lblDrugoPitanje = new System.Windows.Forms.Label();
            this.cbNe = new System.Windows.Forms.CheckBox();
            this.cbDa = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrojPitanja = new System.Windows.Forms.Label();
            this.btnZavrsi = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDrugoPitanje
            // 
            this.lblDrugoPitanje.AutoSize = true;
            this.lblDrugoPitanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrugoPitanje.Location = new System.Drawing.Point(42, 42);
            this.lblDrugoPitanje.Name = "lblDrugoPitanje";
            this.lblDrugoPitanje.Size = new System.Drawing.Size(377, 29);
            this.lblDrugoPitanje.TabIndex = 26;
            this.lblDrugoPitanje.Text = "Je li ti bitan modding aspekt igre ?";
            // 
            // cbNe
            // 
            this.cbNe.AutoSize = true;
            this.cbNe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNe.Location = new System.Drawing.Point(83, 149);
            this.cbNe.Name = "cbNe";
            this.cbNe.Size = new System.Drawing.Size(59, 29);
            this.cbNe.TabIndex = 38;
            this.cbNe.Text = "Ne";
            this.cbNe.UseVisualStyleBackColor = true;
            this.cbNe.CheckedChanged += new System.EventHandler(this.cbNe_CheckedChanged);
            // 
            // cbDa
            // 
            this.cbDa.AutoSize = true;
            this.cbDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDa.Location = new System.Drawing.Point(83, 105);
            this.cbDa.Name = "cbDa";
            this.cbDa.Size = new System.Drawing.Size(59, 29);
            this.cbDa.TabIndex = 37;
            this.cbDa.Text = "Da";
            this.cbDa.UseVisualStyleBackColor = true;
            this.cbDa.CheckedChanged += new System.EventHandler(this.cbDa_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "Moguće označiti samo 1 opciju. ";
            // 
            // lblBrojPitanja
            // 
            this.lblBrojPitanja.AutoSize = true;
            this.lblBrojPitanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPitanja.Location = new System.Drawing.Point(22, 484);
            this.lblBrojPitanja.Name = "lblBrojPitanja";
            this.lblBrojPitanja.Size = new System.Drawing.Size(84, 29);
            this.lblBrojPitanja.TabIndex = 41;
            this.lblBrojPitanja.Text = "16 / 16";
            // 
            // btnZavrsi
            // 
            this.btnZavrsi.Location = new System.Drawing.Point(656, 481);
            this.btnZavrsi.Name = "btnZavrsi";
            this.btnZavrsi.Size = new System.Drawing.Size(125, 42);
            this.btnZavrsi.TabIndex = 48;
            this.btnZavrsi.Text = "Završi";
            this.btnZavrsi.UseVisualStyleBackColor = true;
            this.btnZavrsi.Click += new System.EventHandler(this.btnZavrsi_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(112, 481);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 42);
            this.btnOdustani.TabIndex = 47;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // SesnaestoPitanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 542);
            this.Controls.Add(this.btnZavrsi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblBrojPitanja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNe);
            this.Controls.Add(this.cbDa);
            this.Controls.Add(this.lblDrugoPitanje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 589);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 589);
            this.Name = "SesnaestoPitanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrugoPitanje;
        private System.Windows.Forms.CheckBox cbNe;
        private System.Windows.Forms.CheckBox cbDa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojPitanja;
        private System.Windows.Forms.Button btnZavrsi;
        private System.Windows.Forms.Button btnOdustani;
    }
}