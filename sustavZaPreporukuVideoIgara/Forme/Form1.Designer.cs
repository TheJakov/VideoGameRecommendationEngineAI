namespace sustavZaPreporukuVideoIgara
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxGamepad = new System.Windows.Forms.PictureBox();
            this.lblGlavniNaslov = new System.Windows.Forms.Label();
            this.lblAutori = new System.Windows.Forms.Label();
            this.lblFromGamers = new System.Windows.Forms.Label();
            this.lblFromGamers2 = new System.Windows.Forms.Label();
            this.btnSpreman = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamepad)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGamepad
            // 
            this.pictureBoxGamepad.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGamepad.Image")));
            this.pictureBoxGamepad.Location = new System.Drawing.Point(316, 126);
            this.pictureBoxGamepad.Name = "pictureBoxGamepad";
            this.pictureBoxGamepad.Size = new System.Drawing.Size(176, 147);
            this.pictureBoxGamepad.TabIndex = 0;
            this.pictureBoxGamepad.TabStop = false;
            // 
            // lblGlavniNaslov
            // 
            this.lblGlavniNaslov.AutoSize = true;
            this.lblGlavniNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGlavniNaslov.Location = new System.Drawing.Point(166, 33);
            this.lblGlavniNaslov.Name = "lblGlavniNaslov";
            this.lblGlavniNaslov.Size = new System.Drawing.Size(474, 36);
            this.lblGlavniNaslov.TabIndex = 1;
            this.lblGlavniNaslov.Text = "Sustav za preporuku video igara";
            // 
            // lblAutori
            // 
            this.lblAutori.AutoSize = true;
            this.lblAutori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutori.Location = new System.Drawing.Point(262, 83);
            this.lblAutori.Name = "lblAutori";
            this.lblAutori.Size = new System.Drawing.Size(273, 29);
            this.lblAutori.TabIndex = 2;
            this.lblAutori.Text = "by Jakov, Karlo i Fabijan";
            // 
            // lblFromGamers
            // 
            this.lblFromGamers.AutoSize = true;
            this.lblFromGamers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromGamers.Location = new System.Drawing.Point(122, 286);
            this.lblFromGamers.Name = "lblFromGamers";
            this.lblFromGamers.Size = new System.Drawing.Size(555, 29);
            this.lblFromGamers.TabIndex = 3;
            this.lblFromGamers.Text = "Ovaj sustav je izrađen od strane igrača video igara ";
            // 
            // lblFromGamers2
            // 
            this.lblFromGamers2.AutoSize = true;
            this.lblFromGamers2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromGamers2.Location = new System.Drawing.Point(262, 327);
            this.lblFromGamers2.Name = "lblFromGamers2";
            this.lblFromGamers2.Size = new System.Drawing.Size(285, 29);
            this.lblFromGamers2.TabIndex = 4;
            this.lblFromGamers2.Text = "za igrače video igara ! ❤ ";
            // 
            // btnSpreman
            // 
            this.btnSpreman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpreman.Location = new System.Drawing.Point(221, 417);
            this.btnSpreman.Name = "btnSpreman";
            this.btnSpreman.Size = new System.Drawing.Size(375, 74);
            this.btnSpreman.TabIndex = 1;
            this.btnSpreman.Text = "Spreman sam pronaći novu igru !";
            this.btnSpreman.UseVisualStyleBackColor = true;
            this.btnSpreman.Click += new System.EventHandler(this.btnSpreman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 542);
            this.Controls.Add(this.btnSpreman);
            this.Controls.Add(this.lblFromGamers2);
            this.Controls.Add(this.lblFromGamers);
            this.Controls.Add(this.lblAutori);
            this.Controls.Add(this.lblGlavniNaslov);
            this.Controls.Add(this.pictureBoxGamepad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 589);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 589);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sustav za preporuku video igara";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamepad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxGamepad;
        private System.Windows.Forms.Label lblGlavniNaslov;
        private System.Windows.Forms.Label lblAutori;
        private System.Windows.Forms.Label lblFromGamers;
        private System.Windows.Forms.Label lblFromGamers2;
        private System.Windows.Forms.Button btnSpreman;
    }
}

