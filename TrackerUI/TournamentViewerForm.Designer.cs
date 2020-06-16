namespace TrackerUI
{
    partial class Tournament_Viewer_Form
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
            this.ScoreButton = new System.Windows.Forms.Button();
            this.versuslabel = new System.Windows.Forms.Label();
            this.teamtwoScoreTextBox = new System.Windows.Forms.TextBox();
            this.teamTwoScoreLabel = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.TeamOneScoreTextBox = new System.Windows.Forms.TextBox();
            this.ScoreTeamOneLabel = new System.Windows.Forms.Label();
            this.Team1 = new System.Windows.Forms.Label();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.UnplayedOnlycheckbox = new System.Windows.Forms.CheckBox();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.RoundLabel = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.Label();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScoreButton
            // 
            this.ScoreButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ScoreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ScoreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ScoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScoreButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ScoreButton.Location = new System.Drawing.Point(701, 362);
            this.ScoreButton.Name = "ScoreButton";
            this.ScoreButton.Size = new System.Drawing.Size(166, 55);
            this.ScoreButton.TabIndex = 62;
            this.ScoreButton.Text = "Score";
            this.ScoreButton.UseVisualStyleBackColor = true;
            // 
            // versuslabel
            // 
            this.versuslabel.AutoSize = true;
            this.versuslabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versuslabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.versuslabel.Location = new System.Drawing.Point(544, 362);
            this.versuslabel.Name = "versuslabel";
            this.versuslabel.Size = new System.Drawing.Size(67, 37);
            this.versuslabel.TabIndex = 61;
            this.versuslabel.Text = "-VS-";
            this.versuslabel.UseMnemonic = false;
            // 
            // teamtwoScoreTextBox
            // 
            this.teamtwoScoreTextBox.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.teamtwoScoreTextBox.Location = new System.Drawing.Point(582, 468);
            this.teamtwoScoreTextBox.Name = "teamtwoScoreTextBox";
            this.teamtwoScoreTextBox.Size = new System.Drawing.Size(61, 31);
            this.teamtwoScoreTextBox.TabIndex = 60;
            // 
            // teamTwoScoreLabel
            // 
            this.teamTwoScoreLabel.AutoSize = true;
            this.teamTwoScoreLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoScoreLabel.Location = new System.Drawing.Point(483, 462);
            this.teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            this.teamTwoScoreLabel.Size = new System.Drawing.Size(76, 37);
            this.teamTwoScoreLabel.TabIndex = 59;
            this.teamTwoScoreLabel.Text = "score";
            this.teamTwoScoreLabel.UseMnemonic = false;
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoName.Location = new System.Drawing.Point(483, 411);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(158, 37);
            this.teamTwoName.TabIndex = 58;
            this.teamTwoName.Text = "<team two>";
            this.teamTwoName.UseMnemonic = false;
            // 
            // TeamOneScoreTextBox
            // 
            this.TeamOneScoreTextBox.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.TeamOneScoreTextBox.Location = new System.Drawing.Point(582, 314);
            this.TeamOneScoreTextBox.Name = "TeamOneScoreTextBox";
            this.TeamOneScoreTextBox.Size = new System.Drawing.Size(61, 31);
            this.TeamOneScoreTextBox.TabIndex = 57;
            // 
            // ScoreTeamOneLabel
            // 
            this.ScoreTeamOneLabel.AutoSize = true;
            this.ScoreTeamOneLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreTeamOneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ScoreTeamOneLabel.Location = new System.Drawing.Point(483, 308);
            this.ScoreTeamOneLabel.Name = "ScoreTeamOneLabel";
            this.ScoreTeamOneLabel.Size = new System.Drawing.Size(76, 37);
            this.ScoreTeamOneLabel.TabIndex = 56;
            this.ScoreTeamOneLabel.Text = "score";
            this.ScoreTeamOneLabel.UseMnemonic = false;
            // 
            // Team1
            // 
            this.Team1.AutoSize = true;
            this.Team1.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Team1.Location = new System.Drawing.Point(483, 257);
            this.Team1.Name = "Team1";
            this.Team1.Size = new System.Drawing.Size(160, 37);
            this.Team1.TabIndex = 55;
            this.Team1.Text = "<team one>";
            this.Team1.UseMnemonic = false;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.Font = new System.Drawing.Font("Segoe UI Light", 22F);
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 40;
            this.matchupListBox.Location = new System.Drawing.Point(53, 257);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(345, 242);
            this.matchupListBox.TabIndex = 54;
            // 
            // UnplayedOnlycheckbox
            // 
            this.UnplayedOnlycheckbox.AutoSize = true;
            this.UnplayedOnlycheckbox.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.UnplayedOnlycheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.UnplayedOnlycheckbox.Location = new System.Drawing.Point(205, 167);
            this.UnplayedOnlycheckbox.Name = "UnplayedOnlycheckbox";
            this.UnplayedOnlycheckbox.Size = new System.Drawing.Size(144, 29);
            this.UnplayedOnlycheckbox.TabIndex = 53;
            this.UnplayedOnlycheckbox.Text = "Unplayed Only";
            this.UnplayedOnlycheckbox.UseVisualStyleBackColor = true;
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(142, 128);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(256, 33);
            this.RoundDropDown.TabIndex = 52;
            // 
            // RoundLabel
            // 
            this.RoundLabel.AutoSize = true;
            this.RoundLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.RoundLabel.Location = new System.Drawing.Point(46, 121);
            this.RoundLabel.Name = "RoundLabel";
            this.RoundLabel.Size = new System.Drawing.Size(90, 37);
            this.RoundLabel.TabIndex = 51;
            this.RoundLabel.Text = "Round";
            this.RoundLabel.UseMnemonic = false;
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSize = true;
            this.TournamentName.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TournamentName.Location = new System.Drawing.Point(254, 28);
            this.TournamentName.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(118, 40);
            this.TournamentName.TabIndex = 50;
            this.TournamentName.Text = "<none>";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(46, 28);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(177, 40);
            this.HeaderLabel.TabIndex = 49;
            this.HeaderLabel.Text = "Tournament: ";
            // 
            // Tournament_Viewer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 555);
            this.Controls.Add(this.ScoreButton);
            this.Controls.Add(this.versuslabel);
            this.Controls.Add(this.teamtwoScoreTextBox);
            this.Controls.Add(this.teamTwoScoreLabel);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.TeamOneScoreTextBox);
            this.Controls.Add(this.ScoreTeamOneLabel);
            this.Controls.Add(this.Team1);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnplayedOnlycheckbox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.RoundLabel);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Name = "Tournament_Viewer_Form";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ScoreButton;
        private System.Windows.Forms.Label versuslabel;
        private System.Windows.Forms.TextBox teamtwoScoreTextBox;
        private System.Windows.Forms.Label teamTwoScoreLabel;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.TextBox TeamOneScoreTextBox;
        private System.Windows.Forms.Label ScoreTeamOneLabel;
        private System.Windows.Forms.Label Team1;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.CheckBox UnplayedOnlycheckbox;
        private System.Windows.Forms.ComboBox RoundDropDown;
        private System.Windows.Forms.Label RoundLabel;
        private System.Windows.Forms.Label TournamentName;
        private System.Windows.Forms.Label HeaderLabel;
    }
}