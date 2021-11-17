
namespace CSC240_06_03_CarDealer_bpc
{
    partial class AcuraDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcuraDetails));
            this.UxAcuraDetailspictureBox1 = new System.Windows.Forms.PictureBox();
            this.UxAcuraDetailspictureBox2 = new System.Windows.Forms.PictureBox();
            this.UxAcuraDetails2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UxAcuraDetailspictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UxAcuraDetailspictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // UxAcuraDetailspictureBox1
            // 
            this.UxAcuraDetailspictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UxAcuraDetailspictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("UxAcuraDetailspictureBox1.Image")));
            this.UxAcuraDetailspictureBox1.Location = new System.Drawing.Point(0, 603);
            this.UxAcuraDetailspictureBox1.Name = "UxAcuraDetailspictureBox1";
            this.UxAcuraDetailspictureBox1.Size = new System.Drawing.Size(1423, 319);
            this.UxAcuraDetailspictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UxAcuraDetailspictureBox1.TabIndex = 0;
            this.UxAcuraDetailspictureBox1.TabStop = false;
            // 
            // UxAcuraDetailspictureBox2
            // 
            this.UxAcuraDetailspictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UxAcuraDetailspictureBox2.Location = new System.Drawing.Point(129, -2);
            this.UxAcuraDetailspictureBox2.Name = "UxAcuraDetailspictureBox2";
            this.UxAcuraDetailspictureBox2.Size = new System.Drawing.Size(285, 1066);
            this.UxAcuraDetailspictureBox2.TabIndex = 1;
            this.UxAcuraDetailspictureBox2.TabStop = false;
            // 
            // UxAcuraDetails2Label
            // 
            this.UxAcuraDetails2Label.AutoSize = true;
            this.UxAcuraDetails2Label.Font = new System.Drawing.Font("Forte", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxAcuraDetails2Label.Location = new System.Drawing.Point(388, 78);
            this.UxAcuraDetails2Label.Name = "UxAcuraDetails2Label";
            this.UxAcuraDetails2Label.Size = new System.Drawing.Size(760, 522);
            this.UxAcuraDetails2Label.TabIndex = 2;
            this.UxAcuraDetails2Label.Text = "> Price: $157,500 \r\n\r\n> Fuel Economy: 21/22 mpg\r\n> Engine: 3.5 L 573 HP V 6\r\n> Po" +
    "wer: 573 hp\r\n> Top Speed: 191 mph\r\n> 0-60 Time: 2.9 seconds\r\n\r\n> Color Selection" +
    " Shown Below:";
            this.UxAcuraDetails2Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // AcuraDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1420, 1057);
            this.Controls.Add(this.UxAcuraDetailspictureBox1);
            this.Controls.Add(this.UxAcuraDetailspictureBox2);
            this.Controls.Add(this.UxAcuraDetails2Label);
            this.Name = "AcuraDetails";
            this.Text = "Acura NSX Information Tab";
            ((System.ComponentModel.ISupportInitialize)(this.UxAcuraDetailspictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UxAcuraDetailspictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox UxAcuraDetailspictureBox1;
        private System.Windows.Forms.PictureBox UxAcuraDetailspictureBox2;
        private System.Windows.Forms.Label UxAcuraDetails2Label;
    }
}