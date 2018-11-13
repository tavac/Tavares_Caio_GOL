namespace Tavares_Caio_GOL
{
	partial class Universe_Size
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
			this.AcceptButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.UniverseSizeLabel = new System.Windows.Forms.Label();
			this.UniverseSizeBox = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AcceptButton
			// 
			this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.AcceptButton.Location = new System.Drawing.Point(12, 122);
			this.AcceptButton.Name = "AcceptButton";
			this.AcceptButton.Size = new System.Drawing.Size(75, 23);
			this.AcceptButton.TabIndex = 0;
			this.AcceptButton.Text = "Accept";
			this.AcceptButton.UseVisualStyleBackColor = true;
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(111, 122);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// UniverseSizeLabel
			// 
			this.UniverseSizeLabel.AutoSize = true;
			this.UniverseSizeLabel.Location = new System.Drawing.Point(44, 38);
			this.UniverseSizeLabel.Name = "UniverseSizeLabel";
			this.UniverseSizeLabel.Size = new System.Drawing.Size(107, 13);
			this.UniverseSizeLabel.TabIndex = 3;
			this.UniverseSizeLabel.Text = "Universe Size ( X, Y )";
			// 
			// UniverseSizeBox
			// 
			this.UniverseSizeBox.Location = new System.Drawing.Point(47, 63);
			this.UniverseSizeBox.Mask = "000,000";
			this.UniverseSizeBox.Name = "UniverseSizeBox";
			this.UniverseSizeBox.Size = new System.Drawing.Size(104, 20);
			this.UniverseSizeBox.TabIndex = 4;
			this.UniverseSizeBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.AliceBlue;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(66, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Max 400,400";
			// 
			// Universe_Size
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(198, 157);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UniverseSizeBox);
			this.Controls.Add(this.UniverseSizeLabel);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.AcceptButton);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Universe_Size";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Universe_Size";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AcceptButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Label UniverseSizeLabel;
		private System.Windows.Forms.MaskedTextBox UniverseSizeBox;
		private System.Windows.Forms.Label label1;
	}
}