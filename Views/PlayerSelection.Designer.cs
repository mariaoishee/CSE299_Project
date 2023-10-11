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
			this.SubmitButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.PlayerSessionDetailsBox = new System.Windows.Forms.TextBox();
			this.PlayerListViewBox = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.BasePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// SubmitButton
			// 
			this.SubmitButton.Location = new System.Drawing.Point(629, 640);
			this.SubmitButton.Name = "SubmitButton";
			this.SubmitButton.Size = new System.Drawing.Size(111, 46);
			this.SubmitButton.TabIndex = 1;
			this.SubmitButton.Text = "Submit";
			this.SubmitButton.UseVisualStyleBackColor = true;
			this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
			// 
			// ClearButton
			// 
			this.ClearButton.Location = new System.Drawing.Point(494, 640);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(118, 46);
			this.ClearButton.TabIndex = 0;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = true;
			this.ClearButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 40;
			this.label1.Text = "Session Details";
			// 
			// PlayerSessionDetailsBox
			// 
			this.PlayerSessionDetailsBox.Location = new System.Drawing.Point(11, 42);
			this.PlayerSessionDetailsBox.Multiline = true;
			this.PlayerSessionDetailsBox.Name = "PlayerSessionDetailsBox";
			this.PlayerSessionDetailsBox.ReadOnly = true;
			this.PlayerSessionDetailsBox.Size = new System.Drawing.Size(741, 102);
			this.PlayerSessionDetailsBox.TabIndex = 39;
			// 
			// PlayerListViewBox
			// 
			this.PlayerListViewBox.CheckBoxes = true;
			this.PlayerListViewBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.BasePrice});
			this.PlayerListViewBox.FullRowSelect = true;
			this.PlayerListViewBox.GridLines = true;
			this.PlayerListViewBox.HideSelection = false;
			this.PlayerListViewBox.Location = new System.Drawing.Point(12, 159);
			this.PlayerListViewBox.Name = "PlayerListViewBox";
			this.PlayerListViewBox.Size = new System.Drawing.Size(741, 467);
			this.PlayerListViewBox.TabIndex = 38;
			this.PlayerListViewBox.UseCompatibleStateImageBehavior = false;
			this.PlayerListViewBox.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Player ID";
			this.columnHeader1.Width = 106;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Player Name";
			this.columnHeader2.Width = 124;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "DOB";
			this.columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Batting Hand";
			this.columnHeader5.Width = 150;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Bowling Skill";
			this.columnHeader6.Width = 150;
			// 
			// BasePrice
			// 
			this.BasePrice.Text = "Country";
			this.BasePrice.Width = 105;
			// 
			// PlayerSelection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(769, 711);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.PlayerSessionDetailsBox);
			this.Controls.Add(this.PlayerListViewBox);
			this.Controls.Add(this.SubmitButton);
			this.Controls.Add(this.ClearButton);
			this.Name = "PlayerSelection";
			this.Text = "PlayerSelection";
			this.Load += new System.EventHandler(this.PlayerSelection_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button SubmitButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox PlayerSessionDetailsBox;
		private System.Windows.Forms.ListView PlayerListViewBox;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader BasePrice;
	}
}