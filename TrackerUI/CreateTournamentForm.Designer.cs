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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.torunamentNameLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.createTeamButton = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.teamsplayerLabel = new System.Windows.Forms.Label();
            this.deleteTeamsPlayersButton = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentLabel.Location = new System.Drawing.Point(55, 39);
            this.tournamentLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(173, 25);
            this.tournamentLabel.TabIndex = 1;
            this.tournamentLabel.Text = "Create Tournament";
            this.tournamentLabel.Click += new System.EventHandler(this.tournamentLabel_Click);
            // 
            // torunamentNameLabel
            // 
            this.torunamentNameLabel.AutoSize = true;
            this.torunamentNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.torunamentNameLabel.Location = new System.Drawing.Point(55, 149);
            this.torunamentNameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.torunamentNameLabel.Name = "torunamentNameLabel";
            this.torunamentNameLabel.Size = new System.Drawing.Size(168, 25);
            this.torunamentNameLabel.TabIndex = 2;
            this.torunamentNameLabel.Text = "Tournament Name";
            this.torunamentNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(60, 177);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(349, 33);
            this.tournamentNameValue.TabIndex = 9;
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(60, 290);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(349, 33);
            this.entryFeeValue.TabIndex = 11;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.entryFeeLabel.Location = new System.Drawing.Point(55, 262);
            this.entryFeeLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(89, 25);
            this.entryFeeLabel.TabIndex = 10;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropdown
            // 
            this.selectTeamDropdown.FormattingEnabled = true;
            this.selectTeamDropdown.Location = new System.Drawing.Point(60, 417);
            this.selectTeamDropdown.Name = "selectTeamDropdown";
            this.selectTeamDropdown.Size = new System.Drawing.Size(349, 33);
            this.selectTeamDropdown.TabIndex = 13;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.selectTeamLabel.Location = new System.Drawing.Point(55, 389);
            this.selectTeamLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(120, 25);
            this.selectTeamLabel.TabIndex = 12;
            this.selectTeamLabel.Text = "Select Team: ";
            // 
            // createTeamButton
            // 
            this.createTeamButton.AutoSize = true;
            this.createTeamButton.Location = new System.Drawing.Point(250, 389);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(159, 25);
            this.createTeamButton.TabIndex = 14;
            this.createTeamButton.TabStop = true;
            this.createTeamButton.Text = "Create New Team";
            // 
            // addTeamButton
            // 
            this.addTeamButton.Location = new System.Drawing.Point(133, 518);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(191, 53);
            this.addTeamButton.TabIndex = 15;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 25;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(510, 147);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(260, 179);
            this.tournamentPlayersListBox.TabIndex = 16;
            // 
            // teamsplayerLabel
            // 
            this.teamsplayerLabel.AutoSize = true;
            this.teamsplayerLabel.Location = new System.Drawing.Point(505, 119);
            this.teamsplayerLabel.Name = "teamsplayerLabel";
            this.teamsplayerLabel.Size = new System.Drawing.Size(141, 25);
            this.teamsplayerLabel.TabIndex = 17;
            this.teamsplayerLabel.Text = "Teams / Players";
            this.teamsplayerLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // deleteTeamsPlayersButton
            // 
            this.deleteTeamsPlayersButton.Location = new System.Drawing.Point(776, 177);
            this.deleteTeamsPlayersButton.Name = "deleteTeamsPlayersButton";
            this.deleteTeamsPlayersButton.Size = new System.Drawing.Size(106, 79);
            this.deleteTeamsPlayersButton.TabIndex = 18;
            this.deleteTeamsPlayersButton.Text = "Delete Selected";
            this.deleteTeamsPlayersButton.UseVisualStyleBackColor = true;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(776, 433);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(106, 115);
            this.deleteSelectedPrizeButton.TabIndex = 21;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Location = new System.Drawing.Point(505, 375);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(62, 25);
            this.prizesLabel.TabIndex = 20;
            this.prizesLabel.Text = "Prizes";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 25;
            this.prizesListBox.Location = new System.Drawing.Point(510, 403);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(260, 179);
            this.prizesListBox.TabIndex = 19;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(305, 601);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(312, 53);
            this.createTournamentButton.TabIndex = 22;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 666);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteTeamsPlayersButton);
            this.Controls.Add(this.teamsplayerLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.selectTeamDropdown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.torunamentNameLabel);
            this.Controls.Add(this.tournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.Label torunamentNameLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropdown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel createTeamButton;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label teamsplayerLabel;
        private System.Windows.Forms.Button deleteTeamsPlayersButton;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button createTournamentButton;
    }
}