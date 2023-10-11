namespace EventController.Views
{
	partial class TeamLotterySelection
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
			this.label5 = new System.Windows.Forms.Label();
			this.SequenceNo = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TeamComboBox = new System.Windows.Forms.ComboBox();
			this.RoundOrderComboBox = new System.Windows.Forms.ComboBox();
			this.RoundOrderComboBox1 = new System.Windows.Forms.ComboBox();
			this.listView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Lottary = new System.Windows.Forms.Button();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(534, 71);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 17);
			this.label5.TabIndex = 25;
			this.label5.Text = "Sequence";
			// 
			// SequenceNo
			// 
			this.SequenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.SequenceNo.FormattingEnabled = true;
			this.SequenceNo.IntegralHeight = false;
			this.SequenceNo.ItemHeight = 20;
			this.SequenceNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.SequenceNo.Location = new System.Drawing.Point(537, 98);
			this.SequenceNo.Name = "SequenceNo";
			this.SequenceNo.Size = new System.Drawing.Size(77, 28);
			this.SequenceNo.TabIndex = 24;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(728, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 17);
			this.label4.TabIndex = 23;
			this.label4.Text = "Team Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(425, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 17);
			this.label3.TabIndex = 22;
			this.label3.Text = "Round No.";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(51, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 17);
			this.label2.TabIndex = 21;
			this.label2.Text = "Category";
			// 
			// TeamComboBox
			// 
			this.TeamComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.TeamComboBox.FormattingEnabled = true;
			this.TeamComboBox.IntegralHeight = false;
			this.TeamComboBox.ItemHeight = 20;
			this.TeamComboBox.Location = new System.Drawing.Point(731, 98);
			this.TeamComboBox.Name = "TeamComboBox";
			this.TeamComboBox.Size = new System.Drawing.Size(489, 28);
			this.TeamComboBox.TabIndex = 20;
			// 
			// RoundOrderComboBox
			// 
			this.RoundOrderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.RoundOrderComboBox.FormattingEnabled = true;
			this.RoundOrderComboBox.IntegralHeight = false;
			this.RoundOrderComboBox.ItemHeight = 20;
			this.RoundOrderComboBox.Location = new System.Drawing.Point(428, 98);
			this.RoundOrderComboBox.Name = "RoundOrderComboBox";
			this.RoundOrderComboBox.Size = new System.Drawing.Size(77, 28);
			this.RoundOrderComboBox.TabIndex = 19;
			// 
			// RoundOrderComboBox1
			// 
			this.RoundOrderComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.RoundOrderComboBox1.FormattingEnabled = true;
			this.RoundOrderComboBox1.IntegralHeight = false;
			this.RoundOrderComboBox1.ItemHeight = 20;
			this.RoundOrderComboBox1.Location = new System.Drawing.Point(54, 98);
			this.RoundOrderComboBox1.Name = "RoundOrderComboBox1";
			this.RoundOrderComboBox1.Size = new System.Drawing.Size(351, 28);
			this.RoundOrderComboBox1.TabIndex = 18;
			// 
			// listView
			// 
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView.FullRowSelect = true;
			this.listView.GridLines = true;
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(28, 177);
			this.listView.Name = "listView";
			this.listView.Size = new System.Drawing.Size(1352, 427);
			this.listView.TabIndex = 26;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Serial";
			this.columnHeader1.Width = 76;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Team Name";
			this.columnHeader2.Width = 950;
			// 
			// Lottary
			// 
			this.Lottary.Location = new System.Drawing.Point(1226, 98);
			this.Lottary.Name = "Lottary";
			this.Lottary.Size = new System.Drawing.Size(126, 28);
			this.Lottary.TabIndex = 27;
			this.Lottary.Text = "Add";
			this.Lottary.UseVisualStyleBackColor = true;
			this.Lottary.Click += new System.EventHandler(this.Lottary_Click);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "TeamID";
			this.columnHeader3.Width = 360;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1190, 644);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(162, 83);
			this.button1.TabIndex = 28;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(999, 644);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(162, 83);
			this.button2.TabIndex = 29;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// TeamLotterySelection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1392, 760);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Lottary);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.SequenceNo);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TeamComboBox);
			this.Controls.Add(this.RoundOrderComboBox);
			this.Controls.Add(this.RoundOrderComboBox1);
			this.Name = "TeamLotterySelection";
			this.Text = "TeamLotterySelection";
			this.Load += new System.EventHandler(this.TeamLotterySelection_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox SequenceNo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox TeamComboBox;
		private System.Windows.Forms.ComboBox RoundOrderComboBox;
		private System.Windows.Forms.ComboBox RoundOrderComboBox1;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Button Lottary;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}