namespace EventController.Views
{
    partial class PlayerSelection
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SessionTextBox = new System.Windows.Forms.TextBox();
            this.ClearListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(540, 431);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(118, 32);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(423, 431);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(111, 32);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SessionTextBox
            // 
            this.SessionTextBox.Location = new System.Drawing.Point(12, 12);
            this.SessionTextBox.Multiline = true;
            this.SessionTextBox.Name = "SessionTextBox";
            this.SessionTextBox.Size = new System.Drawing.Size(646, 63);
            this.SessionTextBox.TabIndex = 2;
            this.SessionTextBox.TextChanged += new System.EventHandler(this.SessionTextBox_TextChanged);
            // 
            // ClearListView
            // 
            this.ClearListView.HideSelection = false;
            this.ClearListView.Location = new System.Drawing.Point(12, 81);
            this.ClearListView.Name = "ClearListView";
            this.ClearListView.Size = new System.Drawing.Size(646, 344);
            this.ClearListView.TabIndex = 3;
            this.ClearListView.UseCompatibleStateImageBehavior = false;
            this.ClearListView.SelectedIndexChanged += new System.EventHandler(this.ClearListView_SelectedIndexChanged);
            // 
            // PlayerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 475);
            this.Controls.Add(this.ClearListView);
            this.Controls.Add(this.SessionTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ClearButton);
            this.Name = "PlayerSelection";
            this.Text = "PlayerSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox SessionTextBox;
        private System.Windows.Forms.ListView ClearListView;
    }
}