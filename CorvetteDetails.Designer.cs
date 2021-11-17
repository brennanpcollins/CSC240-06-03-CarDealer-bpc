
namespace CSC240_06_03_CarDealer_bpc
{
    partial class CorvetteDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorvetteDetails));
            this.UxCorvDetPictureBox1 = new System.Windows.Forms.PictureBox();
            this.UxCorvDetPictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UxCorvDetPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UxCorvDetPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // UxCorvDetPictureBox1
            // 
            this.UxCorvDetPictureBox1.BackColor = System.Drawing.Color.Ivory;
            this.UxCorvDetPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("UxCorvDetPictureBox1.Image")));
            this.UxCorvDetPictureBox1.Location = new System.Drawing.Point(-1, 625);
            this.UxCorvDetPictureBox1.Name = "UxCorvDetPictureBox1";
            this.UxCorvDetPictureBox1.Size = new System.Drawing.Size(1426, 376);
            this.UxCorvDetPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UxCorvDetPictureBox1.TabIndex = 0;
            this.UxCorvDetPictureBox1.TabStop = false;
            // 
            // UxCorvDetPictureBox2
            // 
            this.UxCorvDetPictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UxCorvDetPictureBox2.Location = new System.Drawing.Point(134, -3);
            this.UxCorvDetPictureBox2.Name = "UxCorvDetPictureBox2";
            this.UxCorvDetPictureBox2.Size = new System.Drawing.Size(274, 1064);
            this.UxCorvDetPictureBox2.TabIndex = 1;
            this.UxCorvDetPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harlow Solid Italic", 19.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(389, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1019, 603);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // CorvetteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1420, 1057);
            this.Controls.Add(this.UxCorvDetPictureBox1);
            this.Controls.Add(this.UxCorvDetPictureBox2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "CorvetteDetails";
            this.Text = "Corvette Information Tab";
            ((System.ComponentModel.ISupportInitialize)(this.UxCorvDetPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UxCorvDetPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UxCorvDetPictureBox1;
        private System.Windows.Forms.PictureBox UxCorvDetPictureBox2;
        private System.Windows.Forms.Label label1;
    }
}