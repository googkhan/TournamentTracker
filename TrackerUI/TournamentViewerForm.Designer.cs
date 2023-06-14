namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListbox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreLabel = new System.Windows.Forms.Label();
            this.teamOneScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.teamTwoScoreBox = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.versusLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentLabel.Location = new System.Drawing.Point(16, 23);
            this.tournamentLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(291, 65);
            this.tournamentLabel.TabIndex = 0;
            this.tournamentLabel.Text = "Tournament: ";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentName.Location = new System.Drawing.Point(321, 23);
            this.tournamentName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(193, 65);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            this.tournamentName.Click += new System.EventHandler(this.tournamentName_Click);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roundLabel.Location = new System.Drawing.Point(16, 132);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(185, 65);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round: ";
            this.roundLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(332, 129);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(446, 73);
            this.roundDropdown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Segoe UI Light", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(332, 208);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(223, 45);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            this.unplayedOnlyCheckbox.CheckedChanged += new System.EventHandler(this.unplayedOnlyCheckbox_CheckedChanged);
            // 
            // matchupListbox
            // 
            this.matchupListbox.FormattingEnabled = true;
            this.matchupListbox.ItemHeight = 65;
            this.matchupListbox.Location = new System.Drawing.Point(12, 290);
            this.matchupListbox.Name = "matchupListbox";
            this.matchupListbox.Size = new System.Drawing.Size(777, 134);
            this.matchupListbox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamOneName.Location = new System.Drawing.Point(16, 440);
            this.teamOneName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(208, 65);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team1>";
            // 
            // teamOneScoreLabel
            // 
            this.teamOneScoreLabel.AutoSize = true;
            this.teamOneScoreLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamOneScoreLabel.Location = new System.Drawing.Point(272, 437);
            this.teamOneScoreLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.teamOneScoreLabel.Name = "teamOneScoreLabel";
            this.teamOneScoreLabel.Size = new System.Drawing.Size(139, 65);
            this.teamOneScoreLabel.TabIndex = 7;
            this.teamOneScoreLabel.Text = "Score";
            // 
            // teamOneScoreValue
            // 
            this.teamOneScoreValue.Location = new System.Drawing.Point(475, 434);
            this.teamOneScoreValue.Name = "teamOneScoreValue";
            this.teamOneScoreValue.Size = new System.Drawing.Size(209, 71);
            this.teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            this.teamTwoScoreValue.Location = new System.Drawing.Point(475, 593);
            this.teamTwoScoreValue.Name = "teamTwoScoreValue";
            this.teamTwoScoreValue.Size = new System.Drawing.Size(209, 71);
            this.teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreBox
            // 
            this.teamTwoScoreBox.AutoSize = true;
            this.teamTwoScoreBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamTwoScoreBox.Location = new System.Drawing.Point(272, 596);
            this.teamTwoScoreBox.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.teamTwoScoreBox.Name = "teamTwoScoreBox";
            this.teamTwoScoreBox.Size = new System.Drawing.Size(139, 65);
            this.teamTwoScoreBox.TabIndex = 10;
            this.teamTwoScoreBox.Text = "Score";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.teamTwoName.Location = new System.Drawing.Point(16, 599);
            this.teamTwoName.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(216, 65);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<team2>";
            // 
            // versusLabel
            // 
            this.versusLabel.AutoSize = true;
            this.versusLabel.Location = new System.Drawing.Point(152, 520);
            this.versusLabel.Name = "versusLabel";
            this.versusLabel.Size = new System.Drawing.Size(212, 65);
            this.versusLabel.TabIndex = 12;
            this.versusLabel.Text = "⚔️VS⚔️";
            // 
            // scoreButton
            // 
            this.scoreButton.Location = new System.Drawing.Point(715, 473);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(217, 158);
            this.scoreButton.TabIndex = 13;
            this.scoreButton.Text = "Record Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 65F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 693);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.versusLabel);
            this.Controls.Add(this.teamTwoScoreValue);
            this.Controls.Add(this.teamTwoScoreBox);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreValue);
            this.Controls.Add(this.teamOneScoreLabel);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListbox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.tournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(14, 16, 14, 16);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListbox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamOneScoreLabel;
        private System.Windows.Forms.TextBox teamOneScoreValue;
        private System.Windows.Forms.TextBox teamTwoScoreValue;
        private System.Windows.Forms.Label teamTwoScoreBox;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label versusLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

