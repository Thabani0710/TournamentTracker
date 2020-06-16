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
            this.TeamMemberButton = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.AdNewMemberBox = new System.Windows.Forms.GroupBox();
            this.TeamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.lastNameTag = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cellphonetag = new System.Windows.Forms.TextBox();
            this.CellphoneLabel = new System.Windows.Forms.Label();
            this.createMemberbutton = new System.Windows.Forms.Button();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedMemberButton = new System.Windows.Forms.Button();
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
            // TeamMemberButton
            // 
            this.TeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.TeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.TeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.TeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeamMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamMemberButton.Location = new System.Drawing.Point(120, 249);
            this.TeamMemberButton.Name = "TeamMemberButton";
            this.TeamMemberButton.Size = new System.Drawing.Size(153, 45);
            this.TeamMemberButton.TabIndex = 28;
            this.TeamMemberButton.Text = "Add Member";
            this.TeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(40, 210);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(360, 33);
            this.SelectTeamMemberDropDown.TabIndex = 26;
            // 
            // AdNewMemberBox
            // 
            this.AdNewMemberBox.Controls.Add(this.createMemberbutton);
            this.AdNewMemberBox.Controls.Add(this.cellphonetag);
            this.AdNewMemberBox.Controls.Add(this.CellphoneLabel);
            this.AdNewMemberBox.Controls.Add(this.EmailValue);
            this.AdNewMemberBox.Controls.Add(this.label1);
            this.AdNewMemberBox.Controls.Add(this.lastNameTag);
            this.AdNewMemberBox.Controls.Add(this.emailLabel);
            this.AdNewMemberBox.Controls.Add(this.TeamOneScoreTextBox);
            this.AdNewMemberBox.Controls.Add(this.FirstNameLabel);
            this.AdNewMemberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AdNewMemberBox.Location = new System.Drawing.Point(40, 315);
            this.AdNewMemberBox.Name = "AdNewMemberBox";
            this.AdNewMemberBox.Size = new System.Drawing.Size(360, 269);
            this.AdNewMemberBox.TabIndex = 29;
            this.AdNewMemberBox.TabStop = false;
            this.AdNewMemberBox.Text = "Add New Member";
            // 
            // TeamOneScoreTextBox
            // 
            this.TeamOneScoreTextBox.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.TeamOneScoreTextBox.Location = new System.Drawing.Point(169, 58);
            this.TeamOneScoreTextBox.Name = "TeamOneScoreTextBox";
            this.TeamOneScoreTextBox.Size = new System.Drawing.Size(172, 34);
            this.TeamOneScoreTextBox.TabIndex = 59;
            this.TeamOneScoreTextBox.TextChanged += new System.EventHandler(this.TeamOneScoreTextBox_TextChanged);
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
            // lastNameTag
            // 
            this.lastNameTag.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lastNameTag.Location = new System.Drawing.Point(169, 96);
            this.lastNameTag.Name = "lastNameTag";
            this.lastNameTag.Size = new System.Drawing.Size(172, 34);
            this.lastNameTag.TabIndex = 61;
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
            // EmailValue
            // 
            this.EmailValue.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.EmailValue.Location = new System.Drawing.Point(169, 133);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(172, 34);
            this.EmailValue.TabIndex = 63;
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
            // cellphonetag
            // 
            this.cellphonetag.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.cellphonetag.Location = new System.Drawing.Point(169, 173);
            this.cellphonetag.Name = "cellphonetag";
            this.cellphonetag.Size = new System.Drawing.Size(172, 34);
            this.cellphonetag.TabIndex = 65;
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
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TeamMembersListBox.Font = new System.Drawing.Font("Segoe UI Light", 22F);
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 40;
            this.TeamMembersListBox.Location = new System.Drawing.Point(551, 80);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(345, 482);
            this.TeamMembersListBox.TabIndex = 30;
            // 
            // DeleteSelectedMemberButton
            // 
            this.DeleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteSelectedMemberButton.Location = new System.Drawing.Point(933, 249);
            this.DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            this.DeleteSelectedMemberButton.Size = new System.Drawing.Size(144, 70);
            this.DeleteSelectedMemberButton.TabIndex = 31;
            this.DeleteSelectedMemberButton.Text = "Delete Selected ";
            this.DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
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
            this.ClientSize = new System.Drawing.Size(1121, 820);
            this.Controls.Add(this.CreateTeamButton);
            this.Controls.Add(this.DeleteSelectedMemberButton);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AdNewMemberBox);
            this.Controls.Add(this.TeamMemberButton);
            this.Controls.Add(this.SelectTeamMemberDropDown);
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
        private System.Windows.Forms.Button TeamMemberButton;
        private System.Windows.Forms.ComboBox SelectTeamMemberDropDown;
        private System.Windows.Forms.GroupBox AdNewMemberBox;
        private System.Windows.Forms.TextBox TeamOneScoreTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button createMemberbutton;
        private System.Windows.Forms.TextBox cellphonetag;
        private System.Windows.Forms.Label CellphoneLabel;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTag;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button DeleteSelectedMemberButton;
        private System.Windows.Forms.Button CreateTeamButton;
    }
}