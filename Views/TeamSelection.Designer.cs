namespace EventController.Views
{
    partial class TeamSelection
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
            this.ClearListView = new System.Windows.Forms.ListView();
            this.SessionTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClearListView
            // 
            this.ClearListView.HideSelection = false;
            this.ClearListView.Location = new System.Drawing.Point(12, 98);
            this.ClearListView.Name = "ClearListView";
            this.ClearListView.Size = new System.Drawing.Size(649, 298);
            this.ClearListView.TabIndex = 0;
            this.ClearListView.UseCompatibleStateImageBehavior = false;
            // 
            // SessionTextBox
            // 
            this.SessionTextBox.Location = new System.Drawing.Point(12, 12);
            this.SessionTextBox.Multiline = true;
            this.SessionTextBox.Name = "SessionTextBox";
            this.SessionTextBox.Size = new System.Drawing.Size(650, 80);
            this.SessionTextBox.TabIndex = 1;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(546, 402);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(115, 36);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(434, 402);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(106, 36);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // TeamSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SessionTextBox);
            this.Controls.Add(this.ClearListView);
            this.Name = "TeamSelection";
            this.Text = "TeamSelection";
            this.Load += new System.EventHandler(this.TeamSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ClearListView;
        private System.Windows.Forms.TextBox SessionTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SubmitButton;
    }
}