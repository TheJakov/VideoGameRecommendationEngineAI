namespace sustavZaPreporukuVideoIgara.Forme
{
    partial class CetvrtoPitanje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CetvrtoPitanje));
            this.lblDrugoPitanje = new System.Windows.Forms.Label();
            this.cbCoop = new System.Windows.Forms.CheckBox();
            this.cbMp = new System.Windows.Forms.CheckBox();
            this.cbSp = new System.Windows.Forms.CheckBox();
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
            this.lblDrugoPitanje.Size = new System.Drawing.Size(440, 29);
            this.lblDrugoPitanje.TabIndex = 15;
            this.lblDrugoPitanje.Text = "Koju komponentu igra mora sadržavati ?";
            // 
            // cbCoop
            // 
            this.cbCoop.AutoSize = true;
            this.cbCoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCoop.Location = new System.Drawing.Point(91, 210);
            this.cbCoop.Name = "cbCoop";
            this.cbCoop.Size = new System.Drawing.Size(89, 29);
            this.cbCoop.TabIndex = 20;
            this.cbCoop.Text = "Co-op";
            this.cbCoop.UseVisualStyleBackColor = true;
            // 
            // cbMp
            // 
            this.cbMp.AutoSize = true;
            this.cbMp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMp.Location = new System.Drawing.Point(91, 163);
            this.cbMp.Name = "cbMp";
            this.cbMp.Size = new System.Drawing.Size(128, 29);
            this.cbMp.TabIndex = 19;
            this.cbMp.Text = "Multiplayer";
            this.cbMp.UseVisualStyleBackColor = true;
            // 
            // cbSp
            // 
            this.cbSp.AutoSize = true;
            this.cbSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSp.Location = new System.Drawing.Point(91, 114);
            this.cbSp.Name = "cbSp";
            this.cbSp.Size = new System.Drawing.Size(251, 29);
            this.cbSp.TabIndex = 18;
            this.cbSp.Text = "Singleplayer (Campaign)";
            this.cbSp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Moguće označiti više opcija. ";
            // 
            // lblBrojPitanja
            // 
            this.lblBrojPitanja.AutoSize = true;
            this.lblBrojPitanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPitanja.Location = new System.Drawing.Point(22, 484);
            this.lblBrojPitanja.Name = "lblBrojPitanja";
            this.lblBrojPitanja.Size = new System.Drawing.Size(71, 29);
            this.lblBrojPitanja.TabIndex = 22;
            this.lblBrojPitanja.Text = "4 / 17";
            // 
            // btnSljedece
            // 
            this.btnSljedece.Location = new System.Drawing.Point(654, 481);
            this.btnSljedece.Name = "btnSljedece";
            this.btnSljedece.Size = new System.Drawing.Size(125, 42);
            this.btnSljedece.TabIndex = 24;
            this.btnSljedece.Text = "Sljedeće";
            this.btnSljedece.UseVisualStyleBackColor = true;
            this.btnSljedece.Click += new System.EventHandler(this.btnSljedece_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(110, 481);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(125, 42);
            this.btnOdustani.TabIndex = 23;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // CetvrtoPitanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 542);
            this.Controls.Add(this.btnSljedece);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblBrojPitanja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCoop);
            this.Controls.Add(this.cbMp);
            this.Controls.Add(this.cbSp);
            this.Controls.Add(this.lblDrugoPitanje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 589);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 589);
            this.Name = "CetvrtoPitanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Komponente igre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrugoPitanje;
        private System.Windows.Forms.CheckBox cbCoop;
        private System.Windows.Forms.CheckBox cbMp;
        private System.Windows.Forms.CheckBox cbSp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrojPitanja;
        private System.Windows.Forms.Button btnSljedece;
        private System.Windows.Forms.Button btnOdustani;
    }
}