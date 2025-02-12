namespace BugedMate
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
            this.Label1 = new System.Windows.Forms.Label();
            this.btnERNEXP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEROR = new System.Windows.Forms.Button();
            this.btnGOAL = new System.Windows.Forms.Button();
            this.btnBUDGET = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label1.Location = new System.Drawing.Point(528, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(248, 37);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "BUDGET MATE";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnERNEXP
            // 
            this.btnERNEXP.BackColor = System.Drawing.Color.Green;
            this.btnERNEXP.Image = global::BugedMate.Properties.Resources._6_removebg_preview;
            this.btnERNEXP.Location = new System.Drawing.Point(12, 14);
            this.btnERNEXP.Name = "btnERNEXP";
            this.btnERNEXP.Size = new System.Drawing.Size(119, 51);
            this.btnERNEXP.TabIndex = 6;
            this.btnERNEXP.UseVisualStyleBackColor = false;
            this.btnERNEXP.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BugedMate.Properties.Resources.Budget_Mate_logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(159, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 396);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnEROR
            // 
            this.btnEROR.BackColor = System.Drawing.Color.Green;
            this.btnEROR.Image = global::BugedMate.Properties.Resources._9_removebg_preview;
            this.btnEROR.Location = new System.Drawing.Point(387, 12);
            this.btnEROR.Name = "btnEROR";
            this.btnEROR.Size = new System.Drawing.Size(119, 51);
            this.btnEROR.TabIndex = 3;
            this.btnEROR.UseVisualStyleBackColor = false;
            this.btnEROR.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnGOAL
            // 
            this.btnGOAL.BackColor = System.Drawing.Color.Green;
            this.btnGOAL.Image = global::BugedMate.Properties.Resources._8_removebg_preview;
            this.btnGOAL.Location = new System.Drawing.Point(262, 12);
            this.btnGOAL.Name = "btnGOAL";
            this.btnGOAL.Size = new System.Drawing.Size(119, 51);
            this.btnGOAL.TabIndex = 2;
            this.btnGOAL.UseVisualStyleBackColor = false;
            this.btnGOAL.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBUDGET
            // 
            this.btnBUDGET.BackColor = System.Drawing.Color.Green;
            this.btnBUDGET.Image = global::BugedMate.Properties.Resources._7_removebg_preview;
            this.btnBUDGET.Location = new System.Drawing.Point(137, 12);
            this.btnBUDGET.Name = "btnBUDGET";
            this.btnBUDGET.Size = new System.Drawing.Size(119, 51);
            this.btnBUDGET.TabIndex = 1;
            this.btnBUDGET.UseVisualStyleBackColor = false;
            this.btnBUDGET.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.btnERNEXP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnEROR);
            this.Controls.Add(this.btnGOAL);
            this.Controls.Add(this.btnBUDGET);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBUDGET;
        private System.Windows.Forms.Button btnGOAL;
        private System.Windows.Forms.Button btnEROR;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnERNEXP;
    }
}

