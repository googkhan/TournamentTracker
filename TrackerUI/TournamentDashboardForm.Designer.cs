namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentButton = new System.Windows.Forms.Button();
            this.loadExistingTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentLabel = new System.Windows.Forms.Label();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tournamentDashboardLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(437, 9);
            this.tournamentDashboardLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(523, 65);
            this.tournamentDashboardLabel.TabIndex = 11;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentButton
            // 
            this.loadExistingTournamentButton.Location = new System.Drawing.Point(570, 338);
            this.loadExistingTournamentButton.Name = "loadExistingTournamentButton";
            this.loadExistingTournamentButton.Size = new System.Drawing.Size(191, 53);
            this.loadExistingTournamentButton.TabIndex = 21;
            this.loadExistingTournamentButton.Text = "Load Tournament";
            this.loadExistingTournamentButton.UseVisualStyleBackColor = true;
            // 
            // loadExistingTournamentDropdown
            // 
            this.loadExistingTournamentDropdown.FormattingEnabled = true;
            this.loadExistingTournamentDropdown.Location = new System.Drawing.Point(448, 239);
            this.loadExistingTournamentDropdown.Name = "loadExistingTournamentDropdown";
            this.loadExistingTournamentDropdown.Size = new System.Drawing.Size(476, 33);
            this.loadExistingTournamentDropdown.TabIndex = 20;
            // 
            // loadExistingTournamentLabel
            // 
            this.loadExistingTournamentLabel.AutoSize = true;
            this.loadExistingTournamentLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.loadExistingTournamentLabel.Location = new System.Drawing.Point(565, 180);
            this.loadExistingTournamentLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.loadExistingTournamentLabel.Name = "loadExistingTournamentLabel";
            this.loadExistingTournamentLabel.Size = new System.Drawing.Size(229, 25);
            this.loadExistingTournamentLabel.TabIndex = 19;
            this.loadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.Location = new System.Drawing.Point(570, 449);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(191, 53);
            this.createTournamentButton.TabIndex = 22;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1397, 696);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadExistingTournamentButton);
            this.Controls.Add(this.loadExistingTournamentDropdown);
            this.Controls.Add(this.loadExistingTournamentLabel);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentDashboardLabel;
        private System.Windows.Forms.Button loadExistingTournamentButton;
        private System.Windows.Forms.ComboBox loadExistingTournamentDropdown;
        private System.Windows.Forms.Label loadExistingTournamentLabel;
        private System.Windows.Forms.Button createTournamentButton;
    }
}