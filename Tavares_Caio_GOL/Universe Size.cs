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
	public partial class Universe_Size : Form
	{
		public Universe_Size()
		{
			InitializeComponent();
		}

		public string US_Box
		{
			get
			{
				return UniverseSizeBox.Text;
			}
			set
			{
				UniverseSizeBox.Text = value;
			}
		}

		private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{

		}
	}
}
