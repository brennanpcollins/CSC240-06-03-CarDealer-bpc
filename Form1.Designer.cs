
namespace CSC240_06_03_CarDealer_bpc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UxCarDealerLabel = new System.Windows.Forms.Label();
            this.UxSecondLabel = new System.Windows.Forms.Label();
            this.UxAcuraNSXCheck = new System.Windows.Forms.CheckBox();
            this.UxCyberTruckCheck = new System.Windows.Forms.CheckBox();
            this.UxCorvetteCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UxCarDealerLabel
            // 
            this.UxCarDealerLabel.AutoSize = true;
            this.UxCarDealerLabel.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxCarDealerLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.UxCarDealerLabel.Location = new System.Drawing.Point(241, 79);
            this.UxCarDealerLabel.Name = "UxCarDealerLabel";
            this.UxCarDealerLabel.Size = new System.Drawing.Size(857, 74);
            this.UxCarDealerLabel.TabIndex = 0;
            this.UxCarDealerLabel.Text = "Brennan\'s Car Dealership";
            // 
            // UxSecondLabel
            // 
            this.UxSecondLabel.AutoSize = true;
            this.UxSecondLabel.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxSecondLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.UxSecondLabel.Location = new System.Drawing.Point(272, 186);
            this.UxSecondLabel.Name = "UxSecondLabel";
            this.UxSecondLabel.Size = new System.Drawing.Size(772, 55);
            this.UxSecondLabel.TabIndex = 1;
            this.UxSecondLabel.Text = "Pick from our selected models!";
            // 
            // UxAcuraNSXCheck
            // 
            this.UxAcuraNSXCheck.AutoSize = true;
            this.UxAcuraNSXCheck.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.UxAcuraNSXCheck.ForeColor = System.Drawing.Color.SteelBlue;
            this.UxAcuraNSXCheck.Location = new System.Drawing.Point(272, 349);
            this.UxAcuraNSXCheck.Name = "UxAcuraNSXCheck";
            this.UxAcuraNSXCheck.Size = new System.Drawing.Size(384, 56);
            this.UxAcuraNSXCheck.TabIndex = 2;
            this.UxAcuraNSXCheck.Text = "2021 Acura NSX";
            this.UxAcuraNSXCheck.UseVisualStyleBackColor = true;
            this.UxAcuraNSXCheck.CheckedChanged += new System.EventHandler(this.UxAcuraNSXCheck_CheckedChanged);
            // 
            // UxCyberTruckCheck
            // 
            this.UxCyberTruckCheck.AutoSize = true;
            this.UxCyberTruckCheck.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UxCyberTruckCheck.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.UxCyberTruckCheck.Location = new System.Drawing.Point(272, 444);
            this.UxCyberTruckCheck.Name = "UxCyberTruckCheck";
            this.UxCyberTruckCheck.Size = new System.Drawing.Size(541, 58);
            this.UxCyberTruckCheck.TabIndex = 3;
            this.UxCyberTruckCheck.Text = "2022 Tesla Cybertruck";
            this.UxCyberTruckCheck.UseVisualStyleBackColor = true;
            this.UxCyberTruckCheck.CheckedChanged += new System.EventHandler(this.UxCyberTruckCheck_CheckedChanged);
            // 
            // UxCorvetteCheck
            // 
            this.UxCorvetteCheck.AutoSize = true;
            this.UxCorvetteCheck.Font = new System.Drawing.Font("Harlow Solid Italic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.UxCorvetteCheck.ForeColor = System.Drawing.Color.DodgerBlue;
            this.UxCorvetteCheck.Location = new System.Drawing.Point(272, 540);
            this.UxCorvetteCheck.Name = "UxCorvetteCheck";
            this.UxCorvetteCheck.Size = new System.Drawing.Size(494, 65);
            this.UxCorvetteCheck.TabIndex = 4;
            this.UxCorvetteCheck.Text = "2021 Chevrolet Corvette";
            this.UxCorvetteCheck.UseVisualStyleBackColor = true;
            this.UxCorvetteCheck.CheckedChanged += new System.EventHandler(this.UxCorvetteCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1315, 876);
            this.Controls.Add(this.UxCorvetteCheck);
            this.Controls.Add(this.UxCyberTruckCheck);
            this.Controls.Add(this.UxAcuraNSXCheck);
            this.Controls.Add(this.UxSecondLabel);
            this.Controls.Add(this.UxCarDealerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UxCarDealerLabel;
        private System.Windows.Forms.Label UxSecondLabel;
        private System.Windows.Forms.CheckBox UxAcuraNSXCheck;
        private System.Windows.Forms.CheckBox UxCyberTruckCheck;
        private System.Windows.Forms.CheckBox UxCorvetteCheck;
    }
}

