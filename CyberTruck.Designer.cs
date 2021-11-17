
namespace CSC240_06_03_CarDealer_bpc
{
    partial class CyberTruck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CyberTruck));
            this.UxCyberTruckTitleLabel = new System.Windows.Forms.Label();
            this.UxTeslaCyberPicture = new System.Windows.Forms.PictureBox();
            this.UxTeslaTruckDetailsLabel = new System.Windows.Forms.Label();
            this.UxCyberTruckDetailButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UxTeslaCyberPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // UxCyberTruckTitleLabel
            // 
            this.UxCyberTruckTitleLabel.AutoSize = true;
            this.UxCyberTruckTitleLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UxCyberTruckTitleLabel.Font = new System.Drawing.Font("Bauhaus 93", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxCyberTruckTitleLabel.Location = new System.Drawing.Point(0, -1);
            this.UxCyberTruckTitleLabel.Name = "UxCyberTruckTitleLabel";
            this.UxCyberTruckTitleLabel.Size = new System.Drawing.Size(630, 67);
            this.UxCyberTruckTitleLabel.TabIndex = 0;
            this.UxCyberTruckTitleLabel.Text = "2022 Tesla Cybertruck";
            // 
            // UxTeslaCyberPicture
            // 
            this.UxTeslaCyberPicture.Image = ((System.Drawing.Image)(resources.GetObject("UxTeslaCyberPicture.Image")));
            this.UxTeslaCyberPicture.Location = new System.Drawing.Point(0, 602);
            this.UxTeslaCyberPicture.Name = "UxTeslaCyberPicture";
            this.UxTeslaCyberPicture.Size = new System.Drawing.Size(688, 454);
            this.UxTeslaCyberPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UxTeslaCyberPicture.TabIndex = 1;
            this.UxTeslaCyberPicture.TabStop = false;
            // 
            // UxTeslaTruckDetailsLabel
            // 
            this.UxTeslaTruckDetailsLabel.AutoSize = true;
            this.UxTeslaTruckDetailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.UxTeslaTruckDetailsLabel.Font = new System.Drawing.Font("Bauhaus 93", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxTeslaTruckDetailsLabel.ForeColor = System.Drawing.Color.Coral;
            this.UxTeslaTruckDetailsLabel.Location = new System.Drawing.Point(261, 266);
            this.UxTeslaTruckDetailsLabel.Name = "UxTeslaTruckDetailsLabel";
            this.UxTeslaTruckDetailsLabel.Size = new System.Drawing.Size(1106, 78);
            this.UxTeslaTruckDetailsLabel.TabIndex = 2;
            this.UxTeslaTruckDetailsLabel.Text = "Price: $39,900 (pre-customization)\r\n";
            // 
            // UxCyberTruckDetailButton
            // 
            this.UxCyberTruckDetailButton.BackColor = System.Drawing.Color.White;
            this.UxCyberTruckDetailButton.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxCyberTruckDetailButton.Location = new System.Drawing.Point(0, 581);
            this.UxCyberTruckDetailButton.Name = "UxCyberTruckDetailButton";
            this.UxCyberTruckDetailButton.Size = new System.Drawing.Size(688, 97);
            this.UxCyberTruckDetailButton.TabIndex = 3;
            this.UxCyberTruckDetailButton.Text = "Click here for info.";
            this.UxCyberTruckDetailButton.UseVisualStyleBackColor = false;
            this.UxCyberTruckDetailButton.Click += new System.EventHandler(this.UxCyberTruckDetailButton_Click);
            // 
            // CyberTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1420, 1057);
            this.Controls.Add(this.UxCyberTruckDetailButton);
            this.Controls.Add(this.UxTeslaTruckDetailsLabel);
            this.Controls.Add(this.UxTeslaCyberPicture);
            this.Controls.Add(this.UxCyberTruckTitleLabel);
            this.Name = "CyberTruck";
            this.Text = "2022 Tesla Cybertruck";
            ((System.ComponentModel.ISupportInitialize)(this.UxTeslaCyberPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxCyberTruckTitleLabel;
        private System.Windows.Forms.PictureBox UxTeslaCyberPicture;
        private System.Windows.Forms.Label UxTeslaTruckDetailsLabel;
        private System.Windows.Forms.Button UxCyberTruckDetailButton;
    }
}