namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.RoundLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.TextBox();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.entryfeeLabel = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.SelectTeamLabel = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.AddTeamButton = new System.Windows.Forms.Button();
            this.CreatePrizeButton = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.TournamentPlayersLabel = new System.Windows.Forms.Label();
            this.prizeslabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.DeleteSelectedTeamPlayerButton = new System.Windows.Forms.Button();
            this.deleteselectedPrizebutton = new System.Windows.Forms.Button();
            this.CreateTournamentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(269, 20);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(251, 40);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.RoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RoundLabel.Location = new System.Drawing.Point(20, 85);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(207, 32);
            this.RoundLabel.TabIndex = 10;
            this.RoundLabel.Text = "Tournament Name:";
            this.RoundLabel.UseMnemonic = false;
            // 
            // TournamentName
            // 
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.TournamentName.Location = new System.Drawing.Point(26, 120);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(354, 36);
            this.TournamentName.TabIndex = 11;
            this.TournamentName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.EntryFeeValue.Location = new System.Drawing.Point(166, 182);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(79, 31);
            this.EntryFeeValue.TabIndex = 20;
            this.EntryFeeValue.Text = "0";
            this.EntryFeeValue.TextChanged += new System.EventHandler(this.teamtwoScoreTextBox_TextChanged);
            // 
            // entryfeeLabel
            // 
            this.entryfeeLabel.AutoSize = true;
            this.entryfeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryfeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.entryfeeLabel.Location = new System.Drawing.Point(19, 173);
            this.entryfeeLabel.Name = "entryfeeLabel";
            this.entryfeeLabel.Size = new System.Drawing.Size(124, 37);
            this.entryfeeLabel.TabIndex = 19;
            this.entryfeeLabel.Text = "Entry Fee";
            this.entryfeeLabel.UseMnemonic = false;
            this.entryfeeLabel.Click += new System.EventHandler(this.teamTwoScoreLabel_Click);
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(20, 273);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(360, 33);
            this.SelectTeamDropDown.TabIndex = 22;
            // 
            // SelectTeamLabel
            // 
            this.SelectTeamLabel.AutoSize = true;
            this.SelectTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.SelectTeamLabel.Location = new System.Drawing.Point(19, 233);
            this.SelectTeamLabel.Name = "SelectTeamLabel";
            this.SelectTeamLabel.Size = new System.Drawing.Size(150, 37);
            this.SelectTeamLabel.TabIndex = 21;
            this.SelectTeamLabel.Text = "Select Team";
            this.SelectTeamLabel.UseMnemonic = false;
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.CreateNewTeamLink.Location = new System.Drawing.Point(224, 245);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(144, 25);
            this.CreateNewTeamLink.TabIndex = 23;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create New Team";
            // 
            // AddTeamButton
            // 
            this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddTeamButton.Location = new System.Drawing.Point(79, 324);
            this.AddTeamButton.Name = "AddTeamButton";
            this.AddTeamButton.Size = new System.Drawing.Size(166, 55);
            this.AddTeamButton.TabIndex = 24;
            this.AddTeamButton.Text = "Add Team";
            this.AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreatePrizeButton.Location = new System.Drawing.Point(79, 413);
            this.CreatePrizeButton.Name = "CreatePrizeButton";
            this.CreatePrizeButton.Size = new System.Drawing.Size(166, 55);
            this.CreatePrizeButton.TabIndex = 25;
            this.CreatePrizeButton.Text = "Create Prize";
            this.CreatePrizeButton.UseVisualStyleBackColor = true;
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentPlayersListBox.Font = new System.Drawing.Font("Segoe UI Light", 22F);
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 40;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(474, 120);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(345, 162);
            this.TournamentPlayersListBox.TabIndex = 26;
            // 
            // TournamentPlayersLabel
            // 
            this.TournamentPlayersLabel.AutoSize = true;
            this.TournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.TournamentPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentPlayersLabel.Location = new System.Drawing.Point(468, 85);
            this.TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            this.TournamentPlayersLabel.Size = new System.Drawing.Size(174, 32);
            this.TournamentPlayersLabel.TabIndex = 27;
            this.TournamentPlayersLabel.Text = "Teams / Players:";
            this.TournamentPlayersLabel.UseMnemonic = false;
            // 
            // prizeslabel
            // 
            this.prizeslabel.AutoSize = true;
            this.prizeslabel.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.prizeslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.prizeslabel.Location = new System.Drawing.Point(491, 292);
            this.prizeslabel.Name = "prizeslabel";
            this.prizeslabel.Size = new System.Drawing.Size(174, 32);
            this.prizeslabel.TabIndex = 29;
            this.prizeslabel.Text = "Teams / Players:";
            this.prizeslabel.UseMnemonic = false;
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.Font = new System.Drawing.Font("Segoe UI Light", 22F);
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 40;
            this.prizesListBox.Location = new System.Drawing.Point(474, 327);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(345, 162);
            this.prizesListBox.TabIndex = 28;
            // 
            // DeleteSelectedTeamPlayerButton
            // 
            this.DeleteSelectedTeamPlayerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.DeleteSelectedTeamPlayerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DeleteSelectedTeamPlayerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.DeleteSelectedTeamPlayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSelectedTeamPlayerButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedTeamPlayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.DeleteSelectedTeamPlayerButton.Location = new System.Drawing.Point(856, 173);
            this.DeleteSelectedTeamPlayerButton.Name = "DeleteSelectedTeamPlayerButton";
            this.DeleteSelectedTeamPlayerButton.Size = new System.Drawing.Size(144, 77);
            this.DeleteSelectedTeamPlayerButton.TabIndex = 30;
            this.DeleteSelectedTeamPlayerButton.Text = "Delete Selected ";
            this.DeleteSelectedTeamPlayerButton.UseVisualStyleBackColor = true;
            // 
            // deleteselectedPrizebutton
            // 
            this.deleteselectedPrizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteselectedPrizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteselectedPrizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteselectedPrizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteselectedPrizebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteselectedPrizebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteselectedPrizebutton.Location = new System.Drawing.Point(856, 393);
            this.deleteselectedPrizebutton.Name = "deleteselectedPrizebutton";
            this.deleteselectedPrizebutton.Size = new System.Drawing.Size(144, 75);
            this.deleteselectedPrizebutton.TabIndex = 31;
            this.deleteselectedPrizebutton.Text = "Delete Selected";
            this.deleteselectedPrizebutton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentbutton
            // 
            this.CreateTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentbutton.Location = new System.Drawing.Point(319, 537);
            this.CreateTournamentbutton.Name = "CreateTournamentbutton";
            this.CreateTournamentbutton.Size = new System.Drawing.Size(215, 73);
            this.CreateTournamentbutton.TabIndex = 32;
            this.CreateTournamentbutton.Text = "Create Tournament";
            this.CreateTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 639);
            this.Controls.Add(this.CreateTournamentbutton);
            this.Controls.Add(this.deleteselectedPrizebutton);
            this.Controls.Add(this.DeleteSelectedTeamPlayerButton);
            this.Controls.Add(this.prizeslabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.TournamentPlayersLabel);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.CreatePrizeButton);
            this.Controls.Add(this.AddTeamButton);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.SelectTeamLabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.entryfeeLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.TextBox TournamentName;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label entryfeeLabel;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label SelectTeamLabel;
        private System.Windows.Forms.LinkLabel CreateNewTeamLink;
        private System.Windows.Forms.Button AddTeamButton;
        private System.Windows.Forms.Button CreatePrizeButton;
        private System.Windows.Forms.ListBox TournamentPlayersListBox;
        private System.Windows.Forms.Label TournamentPlayersLabel;
        private System.Windows.Forms.Label prizeslabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button DeleteSelectedTeamPlayerButton;
        private System.Windows.Forms.Button deleteselectedPrizebutton;
        private System.Windows.Forms.Button CreateTournamentbutton;
    }
}