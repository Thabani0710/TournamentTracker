namespace TrackerUI
{
    partial class TournamentDashBoardForm
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
            this.LoadExistingtournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LoadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.LoadTournamentbutton = new System.Windows.Forms.Button();
            this.CreateTournamentbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.HeaderLabel.Location = new System.Drawing.Point(194, 27);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(230, 30);
            this.HeaderLabel.TabIndex = 3;
            this.HeaderLabel.Text = "Tournament Dashboard";
            // 
            // LoadExistingtournamentDropDown
            // 
            this.LoadExistingtournamentDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingtournamentDropDown.FormattingEnabled = true;
            this.LoadExistingtournamentDropDown.Location = new System.Drawing.Point(129, 135);
            this.LoadExistingtournamentDropDown.Name = "LoadExistingtournamentDropDown";
            this.LoadExistingtournamentDropDown.Size = new System.Drawing.Size(360, 33);
            this.LoadExistingtournamentDropDown.TabIndex = 28;
            // 
            // LoadExistingTournamentLabel
            // 
            this.LoadExistingTournamentLabel.AutoSize = true;
            this.LoadExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadExistingTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoadExistingTournamentLabel.Location = new System.Drawing.Point(158, 95);
            this.LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            this.LoadExistingTournamentLabel.Size = new System.Drawing.Size(303, 37);
            this.LoadExistingTournamentLabel.TabIndex = 27;
            this.LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            this.LoadExistingTournamentLabel.UseMnemonic = false;
            // 
            // LoadTournamentbutton
            // 
            this.LoadTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.LoadTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LoadTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.LoadTournamentbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LoadTournamentbutton.Location = new System.Drawing.Point(215, 174);
            this.LoadTournamentbutton.Name = "LoadTournamentbutton";
            this.LoadTournamentbutton.Size = new System.Drawing.Size(189, 37);
            this.LoadTournamentbutton.TabIndex = 67;
            this.LoadTournamentbutton.Text = "Load Tournament";
            this.LoadTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentbutton
            // 
            this.CreateTournamentbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.CreateTournamentbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.CreateTournamentbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CreateTournamentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTournamentbutton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.CreateTournamentbutton.Location = new System.Drawing.Point(202, 266);
            this.CreateTournamentbutton.Name = "CreateTournamentbutton";
            this.CreateTournamentbutton.Size = new System.Drawing.Size(215, 73);
            this.CreateTournamentbutton.TabIndex = 68;
            this.CreateTournamentbutton.Text = "Create Tournament";
            this.CreateTournamentbutton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 373);
            this.Controls.Add(this.CreateTournamentbutton);
            this.Controls.Add(this.LoadTournamentbutton);
            this.Controls.Add(this.LoadExistingtournamentDropDown);
            this.Controls.Add(this.LoadExistingTournamentLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashBoard";
            this.Text = "Tournament DashBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.ComboBox LoadExistingtournamentDropDown;
        private System.Windows.Forms.Label LoadExistingTournamentLabel;
        private System.Windows.Forms.Button LoadTournamentbutton;
        private System.Windows.Forms.Button CreateTournamentbutton;
    }
}