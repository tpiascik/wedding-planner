namespace Wedding_Planner
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.plusOneLabel = new System.Windows.Forms.Label();
            this.plusOneName = new System.Windows.Forms.TextBox();
            this.plusOneChoice = new System.Windows.Forms.ComboBox();
            this.foodLabel = new System.Windows.Forms.Label();
            this.foodChoice = new System.Windows.Forms.ComboBox();
            this.addGuestButton = new System.Windows.Forms.Button();
            this.groupChoice = new System.Windows.Forms.ComboBox();
            this.groupLabel = new System.Windows.Forms.Label();
            this.foodChoicePlusOne = new System.Windows.Forms.ComboBox();
            this.foodLabel2 = new System.Windows.Forms.Label();
            this.guestLabel = new System.Windows.Forms.Label();
            this.listGuests = new System.Windows.Forms.ListBox();
            this.byGroup = new System.Windows.Forms.Button();
            this.numGuestLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SeatGuest = new System.Windows.Forms.Button();
            this.seatGuestatTable = new System.Windows.Forms.ComboBox();
            this.tablePic = new System.Windows.Forms.PictureBox();
            this.billButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablePic)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(95, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(97, 20);
            this.nameBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(5, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(43, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // plusOneLabel
            // 
            this.plusOneLabel.AutoSize = true;
            this.plusOneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusOneLabel.Location = new System.Drawing.Point(198, 15);
            this.plusOneLabel.Name = "plusOneLabel";
            this.plusOneLabel.Size = new System.Drawing.Size(62, 13);
            this.plusOneLabel.TabIndex = 3;
            this.plusOneLabel.Text = "Plus One:";
            this.plusOneLabel.Visible = false;
            // 
            // plusOneName
            // 
            this.plusOneName.Location = new System.Drawing.Point(288, 12);
            this.plusOneName.Name = "plusOneName";
            this.plusOneName.Size = new System.Drawing.Size(97, 20);
            this.plusOneName.TabIndex = 2;
            this.plusOneName.Visible = false;
            // 
            // plusOneChoice
            // 
            this.plusOneChoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.plusOneChoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.plusOneChoice.FormattingEnabled = true;
            this.plusOneChoice.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.plusOneChoice.Location = new System.Drawing.Point(95, 38);
            this.plusOneChoice.Name = "plusOneChoice";
            this.plusOneChoice.Size = new System.Drawing.Size(97, 21);
            this.plusOneChoice.TabIndex = 4;
            this.plusOneChoice.SelectedIndexChanged += new System.EventHandler(this.plusOneChoice_SelectedIndexChanged);
            // 
            // foodLabel
            // 
            this.foodLabel.AutoSize = true;
            this.foodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel.Location = new System.Drawing.Point(5, 71);
            this.foodLabel.Name = "foodLabel";
            this.foodLabel.Size = new System.Drawing.Size(39, 13);
            this.foodLabel.TabIndex = 5;
            this.foodLabel.Text = "Food:";
            // 
            // foodChoice
            // 
            this.foodChoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.foodChoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.foodChoice.FormattingEnabled = true;
            this.foodChoice.Items.AddRange(new object[] {
            "Beef",
            "Chicken",
            "Fish",
            "Vegitarian"});
            this.foodChoice.Location = new System.Drawing.Point(95, 68);
            this.foodChoice.Name = "foodChoice";
            this.foodChoice.Size = new System.Drawing.Size(97, 21);
            this.foodChoice.TabIndex = 6;
            // 
            // addGuestButton
            // 
            this.addGuestButton.Location = new System.Drawing.Point(52, 155);
            this.addGuestButton.Name = "addGuestButton";
            this.addGuestButton.Size = new System.Drawing.Size(75, 23);
            this.addGuestButton.TabIndex = 7;
            this.addGuestButton.Text = "Add Guest";
            this.addGuestButton.UseVisualStyleBackColor = true;
            this.addGuestButton.Click += new System.EventHandler(this.addGuestButton_Click);
            // 
            // groupChoice
            // 
            this.groupChoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.groupChoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.groupChoice.FormattingEnabled = true;
            this.groupChoice.Items.AddRange(new object[] {
            "Friends",
            "Family",
            "Work",
            "Forced",
            "Friend of Family",
            "Extra Family"});
            this.groupChoice.Location = new System.Drawing.Point(95, 95);
            this.groupChoice.Name = "groupChoice";
            this.groupChoice.Size = new System.Drawing.Size(97, 21);
            this.groupChoice.TabIndex = 9;
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLabel.Location = new System.Drawing.Point(5, 98);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(45, 13);
            this.groupLabel.TabIndex = 8;
            this.groupLabel.Text = "Group:";
            // 
            // foodChoicePlusOne
            // 
            this.foodChoicePlusOne.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.foodChoicePlusOne.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.foodChoicePlusOne.FormattingEnabled = true;
            this.foodChoicePlusOne.Items.AddRange(new object[] {
            "Beef",
            "Chicken",
            "Fish"});
            this.foodChoicePlusOne.Location = new System.Drawing.Point(288, 38);
            this.foodChoicePlusOne.Name = "foodChoicePlusOne";
            this.foodChoicePlusOne.Size = new System.Drawing.Size(97, 21);
            this.foodChoicePlusOne.TabIndex = 11;
            this.foodChoicePlusOne.Visible = false;
            // 
            // foodLabel2
            // 
            this.foodLabel2.AutoSize = true;
            this.foodLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodLabel2.Location = new System.Drawing.Point(198, 41);
            this.foodLabel2.Name = "foodLabel2";
            this.foodLabel2.Size = new System.Drawing.Size(39, 13);
            this.foodLabel2.TabIndex = 10;
            this.foodLabel2.Text = "Food:";
            this.foodLabel2.Visible = false;
            // 
            // guestLabel
            // 
            this.guestLabel.AutoSize = true;
            this.guestLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestLabel.Location = new System.Drawing.Point(5, 41);
            this.guestLabel.Name = "guestLabel";
            this.guestLabel.Size = new System.Drawing.Size(62, 13);
            this.guestLabel.TabIndex = 12;
            this.guestLabel.Text = "Plus One:";
            // 
            // listGuests
            // 
            this.listGuests.FormattingEnabled = true;
            this.listGuests.Location = new System.Drawing.Point(265, 83);
            this.listGuests.Name = "listGuests";
            this.listGuests.Size = new System.Drawing.Size(120, 95);
            this.listGuests.TabIndex = 13;
            this.listGuests.SelectedIndexChanged += new System.EventHandler(this.listGuests_SelectedIndexChanged);
            // 
            // byGroup
            // 
            this.byGroup.Location = new System.Drawing.Point(173, 221);
            this.byGroup.Name = "byGroup";
            this.byGroup.Size = new System.Drawing.Size(75, 23);
            this.byGroup.TabIndex = 14;
            this.byGroup.Text = "Group";
            this.byGroup.UseVisualStyleBackColor = true;
            this.byGroup.Click += new System.EventHandler(this.byGroup_Click);
            // 
            // numGuestLabel
            // 
            this.numGuestLabel.AutoSize = true;
            this.numGuestLabel.Location = new System.Drawing.Point(418, 12);
            this.numGuestLabel.Name = "numGuestLabel";
            this.numGuestLabel.Size = new System.Drawing.Size(52, 13);
            this.numGuestLabel.TabIndex = 15;
            this.numGuestLabel.Text = "Guests: 0";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(269, 223);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 16;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.Location = new System.Drawing.Point(441, 83);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(37, 15);
            this.infoLabel.TabIndex = 17;
            this.infoLabel.Text = "label1";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(421, 317);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(514, 317);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 19;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SeatGuest
            // 
            this.SeatGuest.Location = new System.Drawing.Point(514, 78);
            this.SeatGuest.Name = "SeatGuest";
            this.SeatGuest.Size = new System.Drawing.Size(75, 23);
            this.SeatGuest.TabIndex = 20;
            this.SeatGuest.Text = "Seat";
            this.SeatGuest.UseVisualStyleBackColor = true;
            this.SeatGuest.Visible = false;
            this.SeatGuest.Click += new System.EventHandler(this.SeatGuest_Click);
            // 
            // seatGuestatTable
            // 
            this.seatGuestatTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.seatGuestatTable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.seatGuestatTable.FormattingEnabled = true;
            this.seatGuestatTable.Items.AddRange(new object[] {
            "Table 1",
            "Table 2",
            "Table 3",
            "Table 4",
            "Table 5",
            "Table 6",
            "Table 7",
            "Table 8",
            "Table 9",
            "Table 10"});
            this.seatGuestatTable.Location = new System.Drawing.Point(514, 116);
            this.seatGuestatTable.Name = "seatGuestatTable";
            this.seatGuestatTable.Size = new System.Drawing.Size(97, 21);
            this.seatGuestatTable.TabIndex = 21;
            this.seatGuestatTable.Visible = false;
            // 
            // tablePic
            // 
            this.tablePic.Image = global::Wedding_Planner.Properties.Resources.table;
            this.tablePic.Location = new System.Drawing.Point(437, 155);
            this.tablePic.Name = "tablePic";
            this.tablePic.Size = new System.Drawing.Size(150, 150);
            this.tablePic.TabIndex = 22;
            this.tablePic.TabStop = false;
            this.tablePic.Click += new System.EventHandler(this.tablePic_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(55, 269);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(75, 23);
            this.billButton.TabIndex = 23;
            this.billButton.Text = "Finances";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 366);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.tablePic);
            this.Controls.Add(this.seatGuestatTable);
            this.Controls.Add(this.SeatGuest);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.numGuestLabel);
            this.Controls.Add(this.byGroup);
            this.Controls.Add(this.listGuests);
            this.Controls.Add(this.guestLabel);
            this.Controls.Add(this.foodChoicePlusOne);
            this.Controls.Add(this.foodLabel2);
            this.Controls.Add(this.groupChoice);
            this.Controls.Add(this.groupLabel);
            this.Controls.Add(this.addGuestButton);
            this.Controls.Add(this.foodChoice);
            this.Controls.Add(this.foodLabel);
            this.Controls.Add(this.plusOneChoice);
            this.Controls.Add(this.plusOneLabel);
            this.Controls.Add(this.plusOneName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label plusOneLabel;
        private System.Windows.Forms.TextBox plusOneName;
        private System.Windows.Forms.ComboBox plusOneChoice;
        private System.Windows.Forms.Label foodLabel;
        private System.Windows.Forms.ComboBox foodChoice;
        private System.Windows.Forms.Button addGuestButton;
        private System.Windows.Forms.ComboBox groupChoice;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ComboBox foodChoicePlusOne;
        private System.Windows.Forms.Label foodLabel2;
        private System.Windows.Forms.Label guestLabel;
        private System.Windows.Forms.ListBox listGuests;
        private System.Windows.Forms.Button byGroup;
        private System.Windows.Forms.Label numGuestLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SeatGuest;
        private System.Windows.Forms.ComboBox seatGuestatTable;
        private System.Windows.Forms.PictureBox tablePic;
        private System.Windows.Forms.Button billButton;
    }
}

