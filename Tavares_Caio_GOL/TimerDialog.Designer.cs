namespace Tavares_Caio_GOL
{
	partial class TimerDialog
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
			this.OK = new System.Windows.Forms.Button();
			this.Cancel = new System.Windows.Forms.Button();
			this.TimerNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.TimerLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.TimerNumericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// OK
			// 
			this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.OK.Location = new System.Drawing.Point(12, 120);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(75, 23);
			this.OK.TabIndex = 0;
			this.OK.Text = "OK";
			this.OK.UseVisualStyleBackColor = true;
			// 
			// Cancel
			// 
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel.Location = new System.Drawing.Point(106, 120);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 1;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			// 
			// TimerNumericUpDown1
			// 
			this.TimerNumericUpDown1.AccessibleName = "TimerNumericUpDown1";
			this.TimerNumericUpDown1.Location = new System.Drawing.Point(48, 65);
			this.TimerNumericUpDown1.Name = "TimerNumericUpDown1";
			this.TimerNumericUpDown1.Size = new System.Drawing.Size(94, 20);
			this.TimerNumericUpDown1.TabIndex = 2;
			this.TimerNumericUpDown1.ValueChanged += new System.EventHandler(this.TimerNumericUpDown1_ValueChanged);
			// 
			// TimerLabel
			// 
			this.TimerLabel.AutoSize = true;
			this.TimerLabel.Location = new System.Drawing.Point(45, 37);
			this.TimerLabel.Name = "TimerLabel";
			this.TimerLabel.Size = new System.Drawing.Size(97, 13);
			this.TimerLabel.TabIndex = 3;
			this.TimerLabel.Text = "Timer (Miliseconds)";
			// 
			// TimerDialog
			// 
			this.AcceptButton = this.OK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel;
			this.ClientSize = new System.Drawing.Size(197, 162);
			this.Controls.Add(this.TimerLabel);
			this.Controls.Add(this.TimerNumericUpDown1);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.OK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TimerDialog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "TimerDialog";
			((System.ComponentModel.ISupportInitialize)(this.TimerNumericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.NumericUpDown TimerNumericUpDown1;
		private System.Windows.Forms.Label TimerLabel;
	}
}