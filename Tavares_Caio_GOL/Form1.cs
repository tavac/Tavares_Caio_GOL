using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tavares_Caio_GOL
{
	public partial class Form1 : Form
	{
		// The universe array
		bool[,] universe = new bool[10, 10];
		bool[,] scratch = new bool[10, 10];

		//modal dialog data
		decimal NumericUpDownSeed = 0;

		// Drawing colors
		Color gridColor = Color.Black;
		Color cellColor = Color.Gray;

		// The Timer class
		Timer timer = new Timer();

		// Generation count
		int generations = 0;

		bool showHUD = false;
		bool InfiniteUniverse = true; // false = FINITE, true = toroidal
		
		public Form1()
		{
			InitializeComponent();

			graphicsPanel1.BackColor = Properties.Settings.Default.PanelColor;

			// Setup the timer
			timer.Enabled = false;
			timer.Interval = 200; // milliseconds
			timer.Tick += Timer_Tick;

			//timer.Enabled = true; // start timer running
		}

		// Calculate the next generation of cells
		private void NextGeneration()
		{
			//rules and implementing Scratch for next generation
			for (int x = 0; x < universe.GetLength(0); ++x)
			{
				for (int y = 0; y < universe.GetLength(1); ++y)
				{
					if (countNeighbor(x, y) < 2) //rule 1
					{
						scratch[x, y] = false;
					}
					else if (countNeighbor(x, y) > 3) //rule 2
					{
						scratch[x, y] = false;
					}
					else if ((universe[x, y] == true) && (countNeighbor(x, y) == 3 || countNeighbor(x, y) == 2)) //rule 3
					{
						scratch[x, y] = true;
					}
					else if ((universe[x, y] == false) && countNeighbor(x, y) == 3) //rule 4
					{
						scratch[x, y] = true;
					}
				}
			}

			// Increment generation count
			generations++;

			// new generation
			bool[,] temp = universe;
			universe = scratch;
			scratch = temp;

			for (int X = 0; X < universe.GetLength(0); ++X)
			{
				for (int Y = 0; Y < universe.GetLength(1); ++Y)
				{
					scratch[X, Y] = false;
				}
			}
			graphicsPanel1.Invalidate();

			// Update status strip generations
			toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
			LivingCellCounter.Text = "Living Cells = " + (CellCounter()).ToString();
		}

		// The event called by the timer every Interval milliseconds.
		private void Timer_Tick(object sender, EventArgs e)
		{
			NextGeneration();
		}

		private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
		{
			// Calculate the width and height of each cell in pixels
			// CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
			int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
			// CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
			int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

			// A Pen for drawing the grid lines (color, width)
			Pen gridPen = new Pen(gridColor, 1);

			// A Brush for filling living cells interiors (color)
			Brush cellBrush = new SolidBrush(cellColor);

			// Iterate through the universe in the y, top to bottom
			for (int y = 0; y < universe.GetLength(1); y++)
			{
				// Iterate through the universe in the x, left to right
				for (int x = 0; x < universe.GetLength(0); x++)
				{
					// A rectangle to represent each cell in pixels
					Rectangle cellRect = Rectangle.Empty;
					cellRect.X = x * cellWidth;
					cellRect.Y = y * cellHeight;
					cellRect.Width = cellWidth;
					cellRect.Height = cellHeight;


					// finds which cells to draw on
					int neighbors = countNeighbor(x, y);
					if (neighbors > 0)
					{
						Font font = new Font("Arial", 8f);

						StringFormat stringFormat = new StringFormat();
						stringFormat.Alignment = StringAlignment.Center;
						stringFormat.LineAlignment = StringAlignment.Center;
						e.Graphics.DrawString(neighbors.ToString(), font, Brushes.Black, cellRect, stringFormat);
					}


					// Fill the cell with a brush if alive
					if (universe[x, y] == true)
					{
						e.Graphics.FillRectangle(cellBrush, cellRect);
					}

					// Outline the cell with a pen
					e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
				}
			}

			// draw HUD
			if (showHUD == true)
			{
				string HUD_Text = "\tGenerations = " + generations + "\n"
							+ "\tLiving Cells = " + (CellCounter()).ToString() + "\n"
							+ "\tBoundary Type = finite" + "\n"
							+ "\tUniverse Size = " + (universe.GetLength(0)) + ", " + (universe.GetLength(1));

				Rectangle HUDRect = Rectangle.Empty;
				HUDRect.X = 5;
				HUDRect.Y = 5;
				HUDRect.Width = 200;
				HUDRect.Height = 100;

				Font f = new Font("Arial", 12f, FontStyle.Bold);
				StringFormat SF = new StringFormat();
				SF.Alignment = StringAlignment.Center;
				SF.LineAlignment = StringAlignment.Center;
				e.Graphics.DrawString(HUD_Text, f, Brushes.Red, HUDRect, SF);
			}

			// Cleaning up pens and brushes
			gridPen.Dispose();
			cellBrush.Dispose();
		}

		private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
		{

			// If the left mouse button was clicked
			if (e.Button == MouseButtons.Left)
			{
				// Calculate the width and height of each cell in pixels
				int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
				int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

				// Calculate the cell that was clicked in
				// CELL X = MOUSE X / CELL WIDTH
				int x = e.X / cellWidth;
				// CELL Y = MOUSE Y / CELL HEIGHT
				int y = e.Y / cellHeight;

				// Toggle the cell's state
				universe[x, y] = !universe[x, y];

				LivingCellCounter.Text = "Living Cells = " + (CellCounter()).ToString();

				// Tell Windows you need to repaint
				graphicsPanel1.Invalidate();
			}
		}

		private int countNeighbor(int x, int y)
		{
			int count = 0;
			// get 'home' position, check for neighbors

			if (InfiniteUniverse == false) // FINITE
			{
				for (int _x = x - 1; _x <= (x + 1); ++_x)
				{
					for (int _y = y - 1; _y <= (y + 1); ++_y)
					{

						// if it is out of bounds, continue
						if (_x < 0 || _y < 0 || _x > universe.GetLength(0) - 1 || _y > universe.GetLength(1) - 1)
							continue;
						//if it is the 'home' cell, continue
						else if (_x == x && _y == y)
							continue;
						if ((_x >= 0 && _y >= 0) && (x < universe.GetLength(0) - 1 && _y < universe.GetLength(1) - 1))
						{
							// if it is a live cell, add count
							if (universe[_x, _y] == true)
								++count;
						}

					}
				}
			}
			else // TOROIDAL
			{
				for (int _x = x - 1; _x <= (x + 1); ++_x)
				{
					for (int _y = y - 1; _y <= (y + 1); ++_y)
					{
						int temp_X = _x;
						int temp_Y = _y;
						// if it is out of bounds, continue
						if (temp_X < 0 || temp_Y < 0 || temp_X >= universe.GetLength(0) || temp_Y >= universe.GetLength(1))
						{
							if (temp_X < 0) // left side border - push to right side
							{
								temp_X = universe.GetLength(0) - 1;
							}
							else if (temp_X >= universe.GetLength(0)) // right border - push to left side
							{
								temp_X = 0;
							}

							if (temp_Y < 0) // top border - push to bottom
							{
								temp_Y = universe.GetLength(1) - 1;
							}
							else if (temp_Y >= universe.GetLength(1)) // bottom border - push to top side
							{
								temp_Y = 0;
							}

						}
						//if it is the 'home' cell, continue
						if (temp_X == x && temp_Y == y)
							continue;

						if ((temp_X >= 0 && temp_Y >= 0) && (temp_X < universe.GetLength(0) && temp_Y < universe.GetLength(1)))
						{
							// if it is a live cell, add count
							if (universe[temp_X, temp_Y] == true)
								++count;
						}

					}
				}
			}
			return count;
		}

		//private int countNeighborToroidal(int x, int y) // remember to change name back to Toroidal
		//{
		//	int count = 0;
		//	// get 'home' position, check for neighbors

		//	for (int _x = x - 1; _x <= (x + 1); ++_x)
		//	{
		//		for (int _y = y - 1; _y <= (y + 1); ++_y)
		//		{
		//			int temp_X = _x;
		//			int temp_Y = _y;
		//			// if it is out of bounds, continue
		//			if (temp_X < 0 || temp_Y < 0 || temp_X >= universe.GetLength(0) || temp_Y >= universe.GetLength(1))
		//			{
		//				if (temp_X < 0) // left side border - push to right side
		//				{
		//					temp_X = universe.GetLength(0) - 1;
		//				}
		//				else if (temp_X >= universe.GetLength(0)) // right border - push to left side
		//				{
		//					temp_X = 0;
		//				}

		//				if (temp_Y < 0) // top border - push to bottom
		//				{
		//					temp_Y = universe.GetLength(1) - 1;
		//				}
		//				else if (temp_Y >= universe.GetLength(1)) // bottom border - push to top side
		//				{
		//					temp_Y = 0;
		//				}

		//			}
		//			//if it is the 'home' cell, continue
		//			if (temp_X == x && temp_Y == y)
		//				continue;

		//			if ((temp_X >= 0 && temp_Y >= 0) && (temp_X < universe.GetLength(0) && temp_Y < universe.GetLength(1)))
		//			{
		//				// if it is a live cell, add count
		//				if (universe[temp_X, temp_Y] == true)
		//					++count;
		//			}

		//		}
		//	}
		//	return count;
		//}


		private void PlayButton_Click(object sender, EventArgs e)
		{
			timer.Enabled = !timer.Enabled;
		}

		private void NextGenButton_Click(object sender, EventArgs e)
		{
			NextGeneration();
		}

		private void newToolStripButton_Click(object sender, EventArgs e)
		{
			for (int x = 0; x < universe.GetLength(0); ++x)
			{
				for (int y = 0; y < universe.GetLength(1); ++y)
				{
					universe[x, y] = false;
					scratch[x, y] = false;
				}
			}
			graphicsPanel1.Invalidate();
			timer.Enabled = false;
			generations = 0;
			toolStripStatusLabelGenerations.Text = "Generations = " + generations;
			LivingCellCounter.Text = "Living Cells = " + (CellCounter()).ToString();
		}

		private void RandomButton_Click(object sender, EventArgs e)
		{
			Random rnd;

			if (NumericUpDownSeed > 0)
			{
				rnd = new Random((int)NumericUpDownSeed);
				for (int x = 0; x < universe.GetLength(0); ++x)
				{
					for (int y = 0; y < universe.GetLength(1); ++y)
					{
						rnd.Next();
						int z = rnd.Next(0, 2);
						if (z == 0)
							universe[x, y] = true;
						else
							universe[x, y] = false;
					}
				}
			}
			else
			{
				rnd = new Random();
				for (int x = 0; x < universe.GetLength(0); ++x)
				{
					for (int y = 0; y < universe.GetLength(1); ++y)
					{
						rnd.Next();
						int z = rnd.Next(0, 2);
						if (z == 0)
							universe[x, y] = true;
						else
							universe[x, y] = false;
					}
				}
			}
			LivingCellCounter.Text = "Living Cells = " + (CellCounter()).ToString();
			graphicsPanel1.Invalidate();
		}

		private void colorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog dlg = new ColorDialog();
			dlg.Color = graphicsPanel1.BackColor;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				graphicsPanel1.BackColor = dlg.Color;
			}
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog dlg = new SaveFileDialog();

			dlg.FileName = "myGOL";
			dlg.Filter = "All Files|*.*|Cells|*.cells";
			dlg.FilterIndex = 2; dlg.DefaultExt = "cells";
			dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			dlg.AddExtension = true;
			dlg.ValidateNames = true;


			if (DialogResult.OK == dlg.ShowDialog())
			{
				StreamWriter writer = new StreamWriter(dlg.FileName);

				// Write any comments you want to include first.
				// Prefix all comment strings with an exclamation point.
				// Use WriteLine to write the strings to the file. 
				// It appends a CRLF for you.
				writer.WriteLine("!This is my comment.");

				// Iterate through the universe one row at a time.
				for (int y = 0; y < universe.GetLength(1); y++)
				{
					// Create a string to represent the current row.
					String currentRow = string.Empty;

					// Iterate through the current row one cell at a time.
					for (int x = 0; x < universe.GetLength(0); x++)
					{
						// If the universe[x,y] is alive then append 'O' (capital O)
						// to the row string.
						if (universe[x, y] == true)
						{
							currentRow += "O";
						}
						else
						{
							currentRow += ".";
						}
						// Else if the universe[x,y] is dead then append '.' (period)
						// to the row string.
					}

					writer.WriteLine(currentRow);
					// Once the current row has been read through and the 
					// string constructed then write it to the file using WriteLine.
				}

				// After all rows and columns have been written then close the file.
				writer.Close();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.PanelColor = graphicsPanel1.BackColor;
			Properties.Settings.Default.Save();
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Reset();
			graphicsPanel1.BackColor = Properties.Settings.Default.PanelColor;
		}

		private void ReloadTool_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Reload();
			graphicsPanel1.BackColor = Properties.Settings.Default.PanelColor;
		}

		private void cellColorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog dlg = new ColorDialog();

			if (dlg.ShowDialog() == DialogResult.OK)
			{
				cellColor = dlg.Color;
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.Filter = "All Files|*.*|Cells|*.cells";
			dlg.FilterIndex = 2;

			if (DialogResult.OK == dlg.ShowDialog())
			{
				StreamReader reader = new StreamReader(dlg.FileName);

				// Create a couple variables to calculate the width and height
				// of the data in the file.
				int maxWidth = 0;
				int maxHeight = 0;

				// Iterate through the file once to get its size.
				while (!reader.EndOfStream)
				{
					// Read one row at a time.
					string row = reader.ReadLine();

					// If the row begins with '!' then it is a comment
					// and should be ignored.
					if (row.StartsWith("!"))
					{
						continue;
					}

					// If the row is not a comment then it is a row of cells.
					// Increment the maxHeight variable for each row read.
					if (!row.StartsWith("!"))
					{
						maxHeight++;
						maxWidth = row.Length;
					}
					// Get the length of the current row string
					// and adjust the maxWidth variable if necessary.
				}
				// Resize the current universe and scratchPad
				// to the width and height of the file calculated above.
				universe = new bool[maxWidth, maxHeight];
				scratch = new bool[maxWidth, maxHeight];


				// Reset the file pointer back to the beginning of the file.
				reader.BaseStream.Seek(0, SeekOrigin.Begin);

				// Iterate through the file again, this time reading in the cells.
				int yPos = 0;
				while (!reader.EndOfStream)
				{
					// Read one row at a time.
					string row = reader.ReadLine();

					// If the row begins with '!' then
					// it is a comment and should be ignored.
					if (row.StartsWith("!"))
					{
						continue;

					}

					// If the row is not a comment then 
					// it is a row of cells and needs to be iterated through.
					for (int xPos = 0; xPos < row.Length; xPos++)
					{
						// If row[xPos] is a 'O' (capital O) then
						// set the corresponding cell in the universe to alive.
						if (row[xPos] == 'O')
						{
							universe[xPos, yPos] = true;
						}

						// If row[xPos] is a '.' (period) then
						// set the corresponding cell in the universe to dead.
						if (row[xPos] == '.')
						{
							universe[xPos, yPos] = false;
						}
					}
					yPos++;
				}

				// Close the file.
				reader.Close();

				toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
				LivingCellCounter.Text = "Living Cells = " + (CellCounter()).ToString();
				graphicsPanel1.Invalidate();
			}
		}

		private int CellCounter()
		{
			int LivingCells = 0;
			for (int x = 0; x < universe.GetLength(0); ++x)
			{
				for (int y = 0; y < universe.GetLength(1); ++y)
				{
					if (universe[x, y] == true)
						LivingCells++;
				}
			}
			return LivingCells;
		}

		private void seedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SeedDialog mD = new SeedDialog();

			mD.Seed = NumericUpDownSeed;

			if (DialogResult.OK == mD.ShowDialog())
			{
				NumericUpDownSeed = mD.Seed;
				RandomButton_Click(sender, e);
			}
		}

		private void timerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TimerDialog tD = new TimerDialog();

			if (DialogResult.OK == tD.ShowDialog())
			{
				timer.Interval = (int)tD.Timer;
			}

		}

		private void universeSizeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Universe_Size uS = new Universe_Size();

			if (DialogResult.OK == uS.ShowDialog())
			{
				int u_X;
				int u_Y;
				string[] temp = uS.US_Box.Split(',');
				u_X = int.Parse(temp[0]);
				u_Y = int.Parse(temp[1]);

				universe = new bool[u_X, u_Y];
				scratch = new bool[u_X, u_Y];
				graphicsPanel1.Invalidate();
			}
		}

		private void StatusStripView_Click(object sender, EventArgs e)
		{
			statusStrip1.Visible = !statusStrip1.Visible;
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			showHUD = !showHUD;
			graphicsPanel1.Invalidate();
		}

		private void finiteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InfiniteUniverse = false;
			UniverseType_StatusLabel.Text = "Universe Type = Finite";
		}

		private void toroidalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			InfiniteUniverse = true;
			UniverseType_StatusLabel.Text = "Universe Type = Toroidal";
		}
	}
}
