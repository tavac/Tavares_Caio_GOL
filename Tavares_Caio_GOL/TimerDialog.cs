﻿using System;
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
	public partial class TimerDialog : Form
	{
		public TimerDialog()
		{
			InitializeComponent();
		}

		public decimal Timer
		{
			get
			{
				return TimerNumericUpDown1.Value;
			}
			set
			{
				TimerNumericUpDown1.Value = value;
			}
		}

		private void TimerNumericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
