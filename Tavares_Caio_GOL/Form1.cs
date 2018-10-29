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
		bool[,] universe = new bool[20, 20];
		bool[,] scratch = new bool[20, 20];

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
			timer.Interval = 100; // milliseconds
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
					if (countNeighbor(x, y) > 3) //rule 2
					{
						scratch[x, y] = false;
					}
					if (countNeighbor(x, y) <= 3 && countNeighbor(x, y) >= 2) //rule 3
					{
						scratch[x, y] = true;
					}
					if (universe[x, y] == false && countNeighbor(x, y) == 3) //rule 4
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

			if (cellOnBorder(x, y) == false)
			{
				if (universe[x - 1, y - 1] == true) //top left
					count++;
				if (universe[x + 1, y + 1] == true) //bottom right
					count++;
				if (universe[x - 1, y] == true) //middle left
					count++;
				if (universe[x + 1, y] == true) //middle right
					count++;
				if (universe[x, y - 1] == true) //middle top
					count++;
				if (universe[x, y + 1] == true) //middle bottom
					count++;
				if (universe[x + 1, y - 1] == true) //top right
					count++;
				if (universe[x - 1, y + 1] == true) //bottom left
					count++;
			}
			else
			{

			}
			
			return count;
		}

		private bool cellOnBorder(int x, int y)
		{
			
			if (x == universe.GetLength(0) - 1)
			{
				return true;
			}
			if (y == universe.GetLength(1) - 1)
			{
				return true;
			}
			if (x == 0)
			{
				return true;
			}
			if (y == 0)
			{
				return true;
			}
			return false;
		}

		private void PlayButton_Click(object sender, EventArgs e)
		{
			timer.Enabled = !timer.Enabled;
		}
	}
}
