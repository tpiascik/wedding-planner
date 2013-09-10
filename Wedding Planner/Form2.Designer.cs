namespace Wedding_Planner
{
    partial class Form2
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
            this.numGuestLabel = new System.Windows.Forms.Label();
            this.cppLabel = new System.Windows.Forms.Label();
            this.flowerLabel = new System.Windows.Forms.Label();
            this.photoLabel = new System.Windows.Forms.Label();
            this.hallLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.limoLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numGuestLabel
            // 
            this.numGuestLabel.AutoSize = true;
            this.numGuestLabel.Location = new System.Drawing.Point(32, 20);
            this.numGuestLabel.Name = "numGuestLabel";
            this.numGuestLabel.Size = new System.Drawing.Size(43, 13);
            this.numGuestLabel.TabIndex = 0;
            this.numGuestLabel.Text = "Guests:";
            // 
            // cppLabel
            // 
            this.cppLabel.AutoSize = true;
            this.cppLabel.Location = new System.Drawing.Point(111, 20);
            this.cppLabel.Name = "cppLabel";
            this.cppLabel.Size = new System.Drawing.Size(77, 13);
            this.cppLabel.TabIndex = 1;
            this.cppLabel.Text = "Cost Per Plate:";
            // 
            // flowerLabel
            // 
            this.flowerLabel.AutoSize = true;
            this.flowerLabel.Location = new System.Drawing.Point(42, 120);
            this.flowerLabel.Name = "flowerLabel";
            this.flowerLabel.Size = new System.Drawing.Size(65, 13);
            this.flowerLabel.TabIndex = 2;
            this.flowerLabel.Text = "Flower Cost:";
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Location = new System.Drawing.Point(9, 150);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(98, 13);
            this.photoLabel.TabIndex = 3;
            this.photoLabel.Text = "Photographer Cost:";
            // 
            // hallLabel
            // 
            this.hallLabel.AutoSize = true;
            this.hallLabel.Location = new System.Drawing.Point(55, 180);
            this.hallLabel.Name = "hallLabel";
            this.hallLabel.Size = new System.Drawing.Size(52, 13);
            this.hallLabel.TabIndex = 4;
            this.hallLabel.Text = "Hall Cost:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(38, 230);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(69, 13);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "Total Cost:";
            // 
            // limoLabel
            // 
            this.limoLabel.AutoSize = true;
            this.limoLabel.Location = new System.Drawing.Point(51, 90);
            this.limoLabel.Name = "limoLabel";
            this.limoLabel.Size = new System.Drawing.Size(56, 13);
            this.limoLabel.TabIndex = 6;
            this.limoLabel.Text = "Limo Cost:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(71, 295);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 366);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.limoLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.hallLabel);
            this.Controls.Add(this.photoLabel);
            this.Controls.Add(this.flowerLabel);
            this.Controls.Add(this.cppLabel);
            this.Controls.Add(this.numGuestLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numGuestLabel;
        private System.Windows.Forms.Label cppLabel;
        private System.Windows.Forms.Label flowerLabel;
        private System.Windows.Forms.Label photoLabel;
        private System.Windows.Forms.Label hallLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label limoLabel;
        private System.Windows.Forms.Button backButton;
    }
}