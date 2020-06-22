namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.TeamName = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.AdNewMemberBox = new System.Windows.Forms.GroupBox();
            this.createMemberbutton = new System.Windows.Forms.Button();
            this.cellPhoneValue = new System.Windows.Forms.TextBox();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.removeSelectedMemberButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.AdNewMemberBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(196, 20);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(168, 40);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Create Team";
            // 
            // TeamName
            // 
            this.TeamName.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.TeamName.Location = new System.Drawing.Point(40, 115);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(360, 36);
            this.TeamName.TabIndex = 13;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamNameLabel.Location = new System.Drawing.Point(34, 80);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(140, 32);
            this.TeamNameLabel.TabIndex = 12;
            this.TeamNameLabel.Text = "Team Name:";
            this.TeamNameLabel.UseMnemonic = false;
            // 
            // SelectTeamMemberLabel
            // 
            this.SelectTeamMemberLabel.AutoSize = true;
            this.SelectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamMemberLabel.Location = new System.Drawing.Point(33, 170);
            this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
            this.SelectTeamMemberLabel.Size = new System.Drawing.Size(253, 37);
            this.SelectTeamMemberLabel.TabIndex = 25;
            this.SelectTeamMemberLabel.Text = "Select Team Member";
            this.SelectTeamMemberLabel.UseMnemonic = false;
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addMemberButton.Location = new System.Drawing.Point(120, 249);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(153, 45);
            this.addMemberButton.TabIndex = 28;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // selectTeamMemberDropDown
            // 
            this.selectTeamMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTeamMemberDropDown.FormattingEnabled = true;
            this.selectTeamMemberDropDown.Location = new System.Drawing.Point(40, 210);
            this.selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            this.selectTeamMemberDropDown.Size = new System.Drawing.Size(360, 33);
            this.selectTeamMemberDropDown.TabIndex = 26;
            // 
            // AdNewMemberBox
            // 
            this.AdNewMemberBox.Controls.Add(this.createMemberbutton);
            this.AdNewMemberBox.Controls.Add(this.cellPhoneValue);
            this.AdNewMemberBox.Controls.Add(this.CellphoneLabel);
            this.AdNewMemberBox.Controls.Add(this.emailValue);
            this.AdNewMemberBox.Controls.Add(this.label1);
            this.AdNewMemberBox.Controls.Add(this.lastNameValue);
            this.AdNewMemberBox.Controls.Add(this.emailLabel);
            this.AdNewMemberBox.Controls.Add(this.firstNameValue);
            this.AdNewMemberBox.Controls.Add(this.FirstNameLabel);
            this.AdNewMemberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AdNewMemberBox.Location = new System.Drawing.Point(40, 315);
            this.AdNewMemberBox.Name = "AdNewMemberBox";
            this.AdNewMemberBox.Size = new System.Drawing.Size(360, 269);
            this.AdNewMemberBox.TabIndex = 29;
            this.AdNewMemberBox.TabStop = false;
            this.AdNewMemberBox.Text = "Add New Member";
            // 
            // createMemberbutton
            // 
            this.createMemberbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.createMemberbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createMemberbutton.Location = new System.Drawing.Point(86, 226);
            this.createMemberbutton.Name = "createMemberbutton";
            this.createMemberbutton.Size = new System.Drawing.Size(153, 37);
            this.createMemberbutton.TabIndex = 66;
            this.createMemberbutton.Text = "Create Member";
            this.createMemberbutton.UseVisualStyleBackColor = true;
            this.createMemberbutton.Click += new System.EventHandler(this.createMemberbutton_Click);
            // 
            // cellPhoneValue
            // 
            this.cellPhoneValue.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.cellPhoneValue.Location = new System.Drawing.Point(169, 173);
            this.cellPhoneValue.Name = "cellPhoneValue";
            this.cellPhoneValue.Size = new System.Drawing.Size(172, 34);
            this.cellPhoneValue.TabIndex = 65;
            // 
            // CellphoneLabel
            // 
            this.CellphoneLabel.AutoSize = true;
            this.CellphoneLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.CellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CellphoneLabel.Location = new System.Drawing.Point(6, 173);
            this.CellphoneLabel.Name = "CellphoneLabel";
            this.CellphoneLabel.Size = new System.Drawing.Size(116, 32);
            this.CellphoneLabel.TabIndex = 64;
            this.CellphoneLabel.Text = "Cellphone";
            this.CellphoneLabel.UseMnemonic = false;
            // 
            // emailValue
            // 
            this.emailValue.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.emailValue.Location = new System.Drawing.Point(169, 133);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(172, 34);
            this.emailValue.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 62;
            this.label1.Text = "Last Name";
            this.label1.UseMnemonic = false;
            // 
            // lastNameValue
            // 
            this.lastNameValue.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lastNameValue.Location = new System.Drawing.Point(169, 96);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(172, 34);
            this.lastNameValue.TabIndex = 61;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.emailLabel.Location = new System.Drawing.Point(9, 136);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(69, 32);
            this.emailLabel.TabIndex = 60;
            this.emailLabel.Text = "Email";
            this.emailLabel.UseMnemonic = false;
            // 
            // firstNameValue
            // 
            this.firstNameValue.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.firstNameValue.Location = new System.Drawing.Point(169, 58);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(172, 34);
            this.firstNameValue.TabIndex = 59;
            this.firstNameValue.TextChanged += new System.EventHandler(this.TeamOneScoreTextBox_TextChanged);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.FirstNameLabel.Location = new System.Drawing.Point(6, 58);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(123, 32);
            this.FirstNameLabel.TabIndex = 58;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.UseMnemonic = false;
            this.FirstNameLabel.Click += new System.EventHandler(this.ScoreTeamOneLabel_Click);
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.Font = new System.Drawing.Font("Segoe UI Light", 22F);
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 40;
            this.teamMembersListBox.Location = new System.Drawing.Point(551, 80);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(345, 482);
            this.teamMembersListBox.TabIndex = 30;
            // 
            // removeSelectedMemberButton
            // 
            this.removeSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.removeSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.removeSelectedMemberButton.Location = new System.Drawing.Point(933, 249);
            this.removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            this.removeSelectedMemberButton.Size = new System.Drawing.Size(144, 70);
            this.removeSelectedMemberButton.TabIndex = 31;
            this.removeSelectedMemberButton.Text = "Remove Selected ";
            this.removeSelectedMemberButton.UseVisualStyleBackColor = true;
            this.removeSelectedMemberButton.Click += new System.EventHandler(this.removeSelectedMemberButton_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTeamButton.Location = new System.Drawing.Point(343, 608);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(215, 46);
            this.CreateTeamButton.TabIndex = 33;
            this.CreateTeamButton.Text = "Create Team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1266, 720);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.removeSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.AdNewMemberBox);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropDown);
            this.Controls.Add(this.SelectTeamMemberLabel);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.AdNewMemberBox.ResumeLayout(false);
            this.AdNewMemberBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.TextBox TeamName;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label SelectTeamMemberLabel;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropDown;
        private System.Windows.Forms.GroupBox AdNewMemberBox;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button createMemberbutton;
        private System.Windows.Forms.TextBox cellPhoneValue;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button removeSelectedMemberButton;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}