namespace EventController.Views
{
	partial class DashBoard
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
			this.PlayerName = new System.Windows.Forms.ComboBox();
			this.Category = new System.Windows.Forms.ComboBox();
			this.ALLTeamsComboBox = new System.Windows.Forms.ComboBox();
			this.SessionDataTxtBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// PlayerName
			// 
			this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PlayerName.FormattingEnabled = true;
			this.PlayerName.Location = new System.Drawing.Point(1708, 505);
			this.PlayerName.Name = "PlayerName";
			this.PlayerName.Size = new System.Drawing.Size(204, 33);
			this.PlayerName.TabIndex = 9;
			this.PlayerName.SelectedIndexChanged += new System.EventHandler(this.PlayerName_SelectedIndexChanged);
			// 
			// Category
			// 
			this.Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Category.FormattingEnabled = true;
			this.Category.Location = new System.Drawing.Point(1708, 337);
			this.Category.Name = "Category";
			this.Category.Size = new System.Drawing.Size(204, 33);
			this.Category.TabIndex = 8;
			this.Category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
			// 
			// ALLTeamsComboBox
			// 
			this.ALLTeamsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ALLTeamsComboBox.FormattingEnabled = true;
			this.ALLTeamsComboBox.Location = new System.Drawing.Point(1708, 202);
			this.ALLTeamsComboBox.Name = "ALLTeamsComboBox";
			this.ALLTeamsComboBox.Size = new System.Drawing.Size(204, 33);
			this.ALLTeamsComboBox.TabIndex = 7;
			this.ALLTeamsComboBox.SelectedIndexChanged += new System.EventHandler(this.ALLTeamsComboBox_SelectedIndexChanged);
			// 
			// SessionDataTxtBox
			// 
			this.SessionDataTxtBox.Location = new System.Drawing.Point(13, 34);
			this.SessionDataTxtBox.Name = "SessionDataTxtBox";
			this.SessionDataTxtBox.ReadOnly = true;
			this.SessionDataTxtBox.Size = new System.Drawing.Size(247, 20);
			this.SessionDataTxtBox.TabIndex = 10;
			// 
			// DashBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1924, 1061);
			this.Controls.Add(this.SessionDataTxtBox);
			this.Controls.Add(this.PlayerName);
			this.Controls.Add(this.Category);
			this.Controls.Add(this.ALLTeamsComboBox);
			this.Name = "DashBoard";
			this.Text = "DashBoard";
			this.Load += new System.EventHandler(this.DashBoard_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox PlayerName;
		private System.Windows.Forms.ComboBox Category;
		private System.Windows.Forms.ComboBox ALLTeamsComboBox;
		private System.Windows.Forms.TextBox SessionDataTxtBox;
	}
}