using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tavares_Caio_GOL
{
	public partial class Form1 : Form
	{
		// The universe array
		bool[,] universe = new bool[75, 75];
		bool[,] scratch = new bool[75, 75];

		//modal dialog data
		decimal NumericUpDownSeed = 0;

		// Drawing colors
		Color gridColor = Color.Black;
		Color cellColor = Color.Gray;

		// The Timer class
		Timer timer = new Timer();

		// Generation count
		int generations = 0;

		public Form1()
		{
			InitializeComponent();

			// Setup the timer
			timer.Enabled = false;
			timer.Interval = 50; // milliseconds
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

				// Tell Windows you need to repaint
				graphicsPanel1.Invalidate();
			}
		}

		private int countNeighbor(int x, int y)
		{
			int count = 0;
			// get 'home' position, check for neighbors

			for (int _x = x - 1; _x <= (x + 1); ++_x)
			{
				for (int _y = y - 1; _y <= (y + 1); ++_y)
				{
					// if it is out of bounds, continue
					if (_x < 0 || _y < 0 || _x > universe.GetLength(0)-1 || _y > universe.GetLength(1)-1)
						continue;
					//if it is the 'home' cell, continue
					else if (_x == x && _y == y)
						continue;
					if ((_x >= 0 && _y >= 0) && (x < universe.GetLength(0)-1 && _y < universe.GetLength(1)-1))
					{
						// if it is a live cell, add count
						if (universe[_x, _y] == true)
							++count;
					}
				}
			}
			return count;
		}

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
		}

		private void RandomButton_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
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

		private void modalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ModalDialog mD = new ModalDialog();

			mD.Seed = NumericUpDownSeed;

			if (DialogResult.OK == mD.ShowDialog())
			{
				NumericUpDownSeed = mD.Seed;
			}
		}
	}
}
