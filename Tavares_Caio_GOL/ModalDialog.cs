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
	public partial class ModalDialog : Form
	{
		public ModalDialog()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		public decimal Seed
		{
			get
			{
				return numericUpDownSeed.Value;
			}
			set
			{
				numericUpDownSeed.Value = value;
			}
		}
	}
}
