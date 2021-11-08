
namespace CSC240_06_03_CarDealer_bpc
{
    partial class AcuraNSX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcuraNSX));
            this.UxNSXDescriptionLabel = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.UxAcuraImage = new System.Windows.Forms.PictureBox();
            this.UxNSXDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UxAcuraImage)).BeginInit();
            this.SuspendLayout();
            // 
            // UxNSXDescriptionLabel
            // 
            this.UxNSXDescriptionLabel.AutoSize = true;
            this.UxNSXDescriptionLabel.Font = new System.Drawing.Font("Forte", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxNSXDescriptionLabel.Location = new System.Drawing.Point(-6, -4);
            this.UxNSXDescriptionLabel.Name = "UxNSXDescriptionLabel";
            this.UxNSXDescriptionLabel.Size = new System.Drawing.Size(481, 65);
            this.UxNSXDescriptionLabel.TabIndex = 0;
            this.UxNSXDescriptionLabel.Text = "2021 Acura NSX   ";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // UxAcuraImage
            // 
            this.UxAcuraImage.Image = ((System.Drawing.Image)(resources.GetObject("UxAcuraImage.Image")));
            this.UxAcuraImage.Location = new System.Drawing.Point(31, 378);
            this.UxAcuraImage.Name = "UxAcuraImage";
            this.UxAcuraImage.Size = new System.Drawing.Size(603, 343);
            this.UxAcuraImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UxAcuraImage.TabIndex = 1;
            this.UxAcuraImage.TabStop = false;
            // 
            // UxNSXDetails
            // 
            this.UxNSXDetails.AutoSize = true;
            this.UxNSXDetails.BackColor = System.Drawing.Color.Transparent;
            this.UxNSXDetails.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxNSXDetails.ForeColor = System.Drawing.Color.Black;
            this.UxNSXDetails.Location = new System.Drawing.Point(640, 265);
            this.UxNSXDetails.Name = "UxNSXDetails";
            this.UxNSXDetails.Size = new System.Drawing.Size(572, 416);
            this.UxNSXDetails.TabIndex = 2;
            this.UxNSXDetails.Text = "Price: $157,500 USD\r\n\r\n\r\n\r\nThis new car is the remake \r\nof the classic NSX model." +
    " \r\nGet this new beauty while \r\nyou can! ";
            // 
            // AcuraNSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1198, 794);
            this.Controls.Add(this.UxNSXDetails);
            this.Controls.Add(this.UxAcuraImage);
            this.Controls.Add(this.UxNSXDescriptionLabel);
            this.Name = "AcuraNSX";
            this.Text = "AcuraNSX";
            ((System.ComponentModel.ISupportInitialize)(this.UxAcuraImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxNSXDescriptionLabel;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PictureBox UxAcuraImage;
        private System.Windows.Forms.Label UxNSXDetails;
    }
}