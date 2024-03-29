﻿namespace Tavares_Caio_GOL
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.universeSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ResetTool = new System.Windows.Forms.ToolStripMenuItem();
			this.ReloadTool = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
			this.LivingCellCounter = new System.Windows.Forms.ToolStripStatusLabel();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.PlayButton = new System.Windows.Forms.ToolStripButton();
			this.NextGenButton = new System.Windows.Forms.ToolStripButton();
			this.RandomButton = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.StatusStripView = new System.Windows.Forms.ToolStripButton();
			this.viewHUDbutton = new System.Windows.Forms.ToolStripButton();
			this.graphicsPanel1 = new Tavares_Caio_GOL.GraphicsPanel();
			this.UniverseType = new System.Windows.Forms.ToolStripSplitButton();
			this.finiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toroidalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.UniverseType_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ShowNeighborButton = new System.Windows.Forms.ToolStripButton();
			this.cellColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1073, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripButton_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.toolStripSeparator3,
            this.ResetTool,
            this.ReloadTool});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cellColorToolStripMenuItem,
            this.backgroundColorToolStripMenuItem,
            this.seedToolStripMenuItem,
            this.timerToolStripMenuItem,
            this.universeSizeToolStripMenuItem});
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			this.customizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.customizeToolStripMenuItem.Text = "&Customize";
			// 
			// cellColorToolStripMenuItem
			// 
			this.cellColorToolStripMenuItem.Name = "cellColorToolStripMenuItem";
			this.cellColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.cellColorToolStripMenuItem.Text = "Cell Color";
			this.cellColorToolStripMenuItem.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
			// 
			// backgroundColorToolStripMenuItem
			// 
			this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
			this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.backgroundColorToolStripMenuItem.Text = "Background Color";
			this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
			// 
			// seedToolStripMenuItem
			// 
			this.seedToolStripMenuItem.Name = "seedToolStripMenuItem";
			this.seedToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.seedToolStripMenuItem.Text = "Seed";
			this.seedToolStripMenuItem.Click += new System.EventHandler(this.seedToolStripMenuItem_Click);
			// 
			// timerToolStripMenuItem
			// 
			this.timerToolStripMenuItem.AccessibleName = "TimerDialog";
			this.timerToolStripMenuItem.Name = "timerToolStripMenuItem";
			this.timerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.timerToolStripMenuItem.Text = "Timer";
			this.timerToolStripMenuItem.Click += new System.EventHandler(this.timerToolStripMenuItem_Click);
			// 
			// universeSizeToolStripMenuItem
			// 
			this.universeSizeToolStripMenuItem.Name = "universeSizeToolStripMenuItem";
			this.universeSizeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.universeSizeToolStripMenuItem.Text = "&Universe Size";
			this.universeSizeToolStripMenuItem.Click += new System.EventHandler(this.universeSizeToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(127, 6);
			// 
			// ResetTool
			// 
			this.ResetTool.Name = "ResetTool";
			this.ResetTool.Size = new System.Drawing.Size(130, 22);
			this.ResetTool.Text = "&Reset";
			this.ResetTool.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// ReloadTool
			// 
			this.ReloadTool.Name = "ReloadTool";
			this.ReloadTool.Size = new System.Drawing.Size(130, 22);
			this.ReloadTool.Text = "&Reload";
			this.ReloadTool.Click += new System.EventHandler(this.ReloadTool_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.LivingCellCounter,
            this.UniverseType_StatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 657);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1073, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelGenerations
			// 
			this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
			this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(90, 17);
			this.toolStripStatusLabelGenerations.Text = "Generations = 0";
			// 
			// LivingCellCounter
			// 
			this.LivingCellCounter.Name = "LivingCellCounter";
			this.LivingCellCounter.Size = new System.Drawing.Size(87, 17);
			this.LivingCellCounter.Text = "Living Cells = 0";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.cellColorToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(171, 48);
			// 
			// colorToolStripMenuItem
			// 
			this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			this.colorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
			this.colorToolStripMenuItem.Text = "Background Color";
			this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(24, 24);
			this.newToolStripButton.Text = "&New";
			this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(24, 24);
			this.openToolStripButton.Text = "&Open";
			this.openToolStripButton.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(24, 24);
			this.saveToolStripButton.Text = "&Save";
			this.saveToolStripButton.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
			// 
			// PlayButton
			// 
			this.PlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new System.Drawing.Size(69, 24);
			this.PlayButton.Text = "&PlayButton";
			this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// NextGenButton
			// 
			this.NextGenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.NextGenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NextGenButton.Name = "NextGenButton";
			this.NextGenButton.Size = new System.Drawing.Size(56, 24);
			this.NextGenButton.Text = "&NextGen";
			this.NextGenButton.Click += new System.EventHandler(this.NextGenButton_Click);
			// 
			// RandomButton
			// 
			this.RandomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.RandomButton.Image = ((System.Drawing.Image)(resources.GetObject("RandomButton.Image")));
			this.RandomButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.RandomButton.Name = "RandomButton";
			this.RandomButton.Size = new System.Drawing.Size(56, 24);
			this.RandomButton.Text = "&Random";
			this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.PlayButton,
            this.NextGenButton,
            this.RandomButton,
            this.toolStripSeparator2,
            this.StatusStripView,
            this.viewHUDbutton,
            this.UniverseType,
            this.ShowNeighborButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1073, 27);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// StatusStripView
			// 
			this.StatusStripView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.StatusStripView.Image = ((System.Drawing.Image)(resources.GetObject("StatusStripView.Image")));
			this.StatusStripView.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.StatusStripView.Name = "StatusStripView";
			this.StatusStripView.Size = new System.Drawing.Size(98, 24);
			this.StatusStripView.Text = "View Status Strip";
			this.StatusStripView.Click += new System.EventHandler(this.StatusStripView_Click);
			// 
			// viewHUDbutton
			// 
			this.viewHUDbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.viewHUDbutton.Image = ((System.Drawing.Image)(resources.GetObject("viewHUDbutton.Image")));
			this.viewHUDbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.viewHUDbutton.Name = "viewHUDbutton";
			this.viewHUDbutton.Size = new System.Drawing.Size(64, 24);
			this.viewHUDbutton.Text = "View HUD";
			this.viewHUDbutton.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// graphicsPanel1
			// 
			this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
			this.graphicsPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.graphicsPanel1.ContextMenuStrip = this.contextMenuStrip1;
			this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.graphicsPanel1.Location = new System.Drawing.Point(0, 51);
			this.graphicsPanel1.Name = "graphicsPanel1";
			this.graphicsPanel1.Size = new System.Drawing.Size(1073, 606);
			this.graphicsPanel1.TabIndex = 3;
			this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
			this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
			// 
			// UniverseType
			// 
			this.UniverseType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.UniverseType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finiteToolStripMenuItem,
            this.toroidalToolStripMenuItem});
			this.UniverseType.Image = ((System.Drawing.Image)(resources.GetObject("UniverseType.Image")));
			this.UniverseType.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.UniverseType.Name = "UniverseType";
			this.UniverseType.Size = new System.Drawing.Size(96, 24);
			this.UniverseType.Text = "Universe Type";
			// 
			// finiteToolStripMenuItem
			// 
			this.finiteToolStripMenuItem.Name = "finiteToolStripMenuItem";
			this.finiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.finiteToolStripMenuItem.Text = "Finite";
			this.finiteToolStripMenuItem.Click += new System.EventHandler(this.finiteToolStripMenuItem_Click);
			// 
			// toroidalToolStripMenuItem
			// 
			this.toroidalToolStripMenuItem.Name = "toroidalToolStripMenuItem";
			this.toroidalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.toroidalToolStripMenuItem.Text = "Toroidal";
			this.toroidalToolStripMenuItem.Click += new System.EventHandler(this.toroidalToolStripMenuItem_Click);
			// 
			// UniverseType_StatusLabel
			// 
			this.UniverseType_StatusLabel.Name = "UniverseType_StatusLabel";
			this.UniverseType_StatusLabel.Size = new System.Drawing.Size(123, 17);
			this.UniverseType_StatusLabel.Text = "Universe Type = Finite";
			// 
			// ShowNeighborButton
			// 
			this.ShowNeighborButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ShowNeighborButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowNeighborButton.Image")));
			this.ShowNeighborButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ShowNeighborButton.Name = "ShowNeighborButton";
			this.ShowNeighborButton.Size = new System.Drawing.Size(93, 24);
			this.ShowNeighborButton.Text = "Show Neighbor";
			this.ShowNeighborButton.Click += new System.EventHandler(this.ShowNeighborButton_Click);
			// 
			// cellColorToolStripMenuItem1
			// 
			this.cellColorToolStripMenuItem1.Name = "cellColorToolStripMenuItem1";
			this.cellColorToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.cellColorToolStripMenuItem1.Text = "Cell Color";
			this.cellColorToolStripMenuItem1.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1073, 679);
			this.Controls.Add(this.graphicsPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.contextMenuStrip1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private GraphicsPanel graphicsPanel1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
		private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem ResetTool;
		private System.Windows.Forms.ToolStripMenuItem ReloadTool;
		private System.Windows.Forms.ToolStripStatusLabel LivingCellCounter;
		private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem seedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem timerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem universeSizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton PlayButton;
		private System.Windows.Forms.ToolStripButton NextGenButton;
		private System.Windows.Forms.ToolStripButton RandomButton;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton StatusStripView;
		private System.Windows.Forms.ToolStripButton viewHUDbutton;
		private System.Windows.Forms.ToolStripSplitButton UniverseType;
		private System.Windows.Forms.ToolStripMenuItem finiteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toroidalToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel UniverseType_StatusLabel;
		private System.Windows.Forms.ToolStripButton ShowNeighborButton;
		private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem1;
	}
}

