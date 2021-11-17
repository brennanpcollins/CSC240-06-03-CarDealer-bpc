
namespace CSC240_06_03_CarDealer_bpc
{
    partial class HelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpScreen));
            this.UxHelpPictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UxHelpPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UxHelpPictureBox1
            // 
            this.UxHelpPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("UxHelpPictureBox1.Image")));
            this.UxHelpPictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.UxHelpPictureBox1.Name = "UxHelpPictureBox1";
            this.UxHelpPictureBox1.Size = new System.Drawing.Size(1426, 1071);
            this.UxHelpPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UxHelpPictureBox1.TabIndex = 0;
            this.UxHelpPictureBox1.TabStop = false;
            // 
            // HelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 1057);
            this.Controls.Add(this.UxHelpPictureBox1);
            this.Name = "HelpScreen";
            this.Text = "Helpful Information";
            ((System.ComponentModel.ISupportInitialize)(this.UxHelpPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UxHelpPictureBox1;
    }
}