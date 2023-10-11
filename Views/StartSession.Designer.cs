namespace EventController.Views
{
    partial class StartSession
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
            this.SessionTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTextBox = new System.Windows.Forms.TextBox();
            this.TeamTextBox = new System.Windows.Forms.TextBox();
            this.PlayerButton = new System.Windows.Forms.Button();
            this.TeamButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SessionTextBox
            // 
            this.SessionTextBox.Location = new System.Drawing.Point(12, 12);
            this.SessionTextBox.Multiline = true;
            this.SessionTextBox.Name = "SessionTextBox";
            this.SessionTextBox.Size = new System.Drawing.Size(568, 67);
            this.SessionTextBox.TabIndex = 0;
            this.SessionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PlayerTextBox
            // 
            this.PlayerTextBox.Location = new System.Drawing.Point(319, 142);
            this.PlayerTextBox.Multiline = true;
            this.PlayerTextBox.Name = "PlayerTextBox";
            this.PlayerTextBox.Size = new System.Drawing.Size(261, 288);
            this.PlayerTextBox.TabIndex = 1;
            // 
            // TeamTextBox
            // 
            this.TeamTextBox.Location = new System.Drawing.Point(12, 142);
            this.TeamTextBox.Multiline = true;
            this.TeamTextBox.Name = "TeamTextBox";
            this.TeamTextBox.Size = new System.Drawing.Size(269, 288);
            this.TeamTextBox.TabIndex = 2;
            // 
            // PlayerButton
            // 
            this.PlayerButton.Location = new System.Drawing.Point(343, 97);
            this.PlayerButton.Name = "PlayerButton";
            this.PlayerButton.Size = new System.Drawing.Size(221, 36);
            this.PlayerButton.TabIndex = 3;
            this.PlayerButton.Text = "Player Confirmation";
            this.PlayerButton.UseVisualStyleBackColor = true;
            // 
            // TeamButton
            // 
            this.TeamButton.Location = new System.Drawing.Point(24, 97);
            this.TeamButton.Name = "TeamButton";
            this.TeamButton.Size = new System.Drawing.Size(231, 36);
            this.TeamButton.TabIndex = 4;
            this.TeamButton.Text = "Team Confirmation";
            this.TeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(46, 439);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(177, 41);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create New Session";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(245, 439);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(273, 41);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start Session";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // StartSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 492);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.TeamButton);
            this.Controls.Add(this.PlayerButton);
            this.Controls.Add(this.TeamTextBox);
            this.Controls.Add(this.PlayerTextBox);
            this.Controls.Add(this.SessionTextBox);
            this.Name = "StartSession";
            this.Text = "StartSession";
            this.Load += new System.EventHandler(this.StartSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SessionTextBox;
        private System.Windows.Forms.TextBox PlayerTextBox;
        private System.Windows.Forms.TextBox TeamTextBox;
        private System.Windows.Forms.Button PlayerButton;
        private System.Windows.Forms.Button TeamButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button StartButton;
    }
}