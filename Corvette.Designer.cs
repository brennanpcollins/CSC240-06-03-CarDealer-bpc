
namespace CSC240_06_03_CarDealer_bpc
{
    partial class Corvette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corvette));
            this.UxCorvetteTitlelabel = new System.Windows.Forms.Label();
            this.UxCorvettePicture = new System.Windows.Forms.PictureBox();
            this.UxCorvetteDetailLabel = new System.Windows.Forms.Label();
            this.UxCorvetteInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UxCorvettePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // UxCorvetteTitlelabel
            // 
            this.UxCorvetteTitlelabel.AutoSize = true;
            this.UxCorvetteTitlelabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.UxCorvetteTitlelabel.Font = new System.Drawing.Font("Harlow Solid Italic", 22.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.UxCorvetteTitlelabel.Location = new System.Drawing.Point(-2, -1);
            this.UxCorvetteTitlelabel.Name = "UxCorvetteTitlelabel";
            this.UxCorvetteTitlelabel.Size = new System.Drawing.Size(569, 75);
            this.UxCorvetteTitlelabel.TabIndex = 0;
            this.UxCorvetteTitlelabel.Text = "2021 Chevrolet Corvette";
            // 
            // UxCorvettePicture
            // 
            this.UxCorvettePicture.Image = ((System.Drawing.Image)(resources.GetObject("UxCorvettePicture.Image")));
            this.UxCorvettePicture.Location = new System.Drawing.Point(-2, 652);
            this.UxCorvettePicture.Name = "UxCorvettePicture";
            this.UxCorvettePicture.Size = new System.Drawing.Size(647, 409);
            this.UxCorvettePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UxCorvettePicture.TabIndex = 1;
            this.UxCorvettePicture.TabStop = false;
            // 
            // UxCorvetteDetailLabel
            // 
            this.UxCorvetteDetailLabel.AutoSize = true;
            this.UxCorvetteDetailLabel.BackColor = System.Drawing.Color.Transparent;
            this.UxCorvetteDetailLabel.Font = new System.Drawing.Font("Harlow Solid Italic", 28.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxCorvetteDetailLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.UxCorvetteDetailLabel.Location = new System.Drawing.Point(465, 550);
            this.UxCorvetteDetailLabel.Name = "UxCorvetteDetailLabel";
            this.UxCorvetteDetailLabel.Size = new System.Drawing.Size(492, 95);
            this.UxCorvetteDetailLabel.TabIndex = 2;
            this.UxCorvetteDetailLabel.Text = "Price: $59,900";
            // 
            // UxCorvetteInfoButton
            // 
            this.UxCorvetteInfoButton.BackColor = System.Drawing.Color.White;
            this.UxCorvetteInfoButton.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxCorvetteInfoButton.Location = new System.Drawing.Point(-2, 648);
            this.UxCorvetteInfoButton.Name = "UxCorvetteInfoButton";
            this.UxCorvetteInfoButton.Size = new System.Drawing.Size(647, 113);
            this.UxCorvetteInfoButton.TabIndex = 3;
            this.UxCorvetteInfoButton.Text = "Click here for info.";
            this.UxCorvetteInfoButton.UseVisualStyleBackColor = false;
            this.UxCorvetteInfoButton.Click += new System.EventHandler(this.UxCorvetteInfoButton_Click);
            // 
            // Corvette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1420, 1057);
            this.Controls.Add(this.UxCorvetteInfoButton);
            this.Controls.Add(this.UxCorvetteDetailLabel);
            this.Controls.Add(this.UxCorvettePicture);
            this.Controls.Add(this.UxCorvetteTitlelabel);
            this.Name = "Corvette";
            this.Text = "2021 Chevrolet Corvette";
            ((System.ComponentModel.ISupportInitialize)(this.UxCorvettePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxCorvetteTitlelabel;
        private System.Windows.Forms.PictureBox UxCorvettePicture;
        private System.Windows.Forms.Label UxCorvetteDetailLabel;
        private System.Windows.Forms.Button UxCorvetteInfoButton;
    }
}