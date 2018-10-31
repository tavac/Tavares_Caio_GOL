namespace Tavares_Caio_GOL
{
	partial class ModalDialog
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
			this.OKbutton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.numericUpDownSeed = new System.Windows.Forms.NumericUpDown();
			this.labelSeed = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeed)).BeginInit();
			this.SuspendLayout();
			// 
			// OKbutton
			// 
			this.OKbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OKbutton.Location = new System.Drawing.Point(12, 172);
			this.OKbutton.Name = "OKbutton";
			this.OKbutton.Size = new System.Drawing.Size(75, 23);
			this.OKbutton.TabIndex = 0;
			this.OKbutton.Text = "OK";
			this.OKbutton.UseVisualStyleBackColor = true;
			// 
			// CancelButton
			// 
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.Location = new System.Drawing.Point(100, 172);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 1;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			// 
			// numericUpDownSeed
			// 
			this.numericUpDownSeed.Location = new System.Drawing.Point(100, 35);
			this.numericUpDownSeed.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numericUpDownSeed.Name = "numericUpDownSeed";
			this.numericUpDownSeed.ReadOnly = true;
			this.numericUpDownSeed.Size = new System.Drawing.Size(75, 20);
			this.numericUpDownSeed.TabIndex = 2;
			// 
			// labelSeed
			// 
			this.labelSeed.AutoSize = true;
			this.labelSeed.Location = new System.Drawing.Point(33, 39);
			this.labelSeed.Name = "labelSeed";
			this.labelSeed.Size = new System.Drawing.Size(32, 13);
			this.labelSeed.TabIndex = 3;
			this.labelSeed.Text = "Seed";
			// 
			// ModalDialog
			// 
			this.AcceptButton = this.OKbutton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(187, 207);
			this.Controls.Add(this.labelSeed);
			this.Controls.Add(this.numericUpDownSeed);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.OKbutton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ModalDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ModalDialog";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSeed)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OKbutton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.NumericUpDown numericUpDownSeed;
		private System.Windows.Forms.Label labelSeed;
	}
}