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
using System.Drawing.Text;

namespace WindowsForms
{
	public partial class Font : Form
	{
		public string FontFile { get; set; }
		public System.Drawing.Font NewFont { get; set; }
		public System.Drawing.Font OldFont { get; set; }

		public Font(System.Drawing.Font oldFont)
		{
			InitializeComponent();

			if (Directory.GetCurrentDirectory().Contains("bin"))
			{
			Directory.SetCurrentDirectory("..\\..\\Fonts");
			}

			string currentDirectory = Directory.GetCurrentDirectory();

			foreach (string i in Directory.GetFiles(currentDirectory))
			{
				if (i.Split('\\').Last().Contains(".ttf") || i.Split('\\').Last().Contains(".otf") || i.Split('\\').Last().Contains(".TTF"))
				{
					this.cbFont.Items.Add(i.Split('\\').Last());
				}
			}

			numericUpDown1 = new NumericUpDown();

			cbFont.SelectedIndex = 0;
			OldFont = oldFont;
			cbFont.SelectedItem = oldFont.Name;
			lblExample.Font = OldFont;
			numericUpDown1.Value = (decimal)oldFont.Size;

		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			//NewFont.Size = (int)numericUpDown1.Value;
			OldFont = NewFont;
			FontFile = cbFont.SelectedItem.ToString();
			this.Close();
		}

		private void cbFont_SelectionChangeCommitted_1(object sender, EventArgs e)
		{
			PrivateFontCollection pfc = new PrivateFontCollection();

			pfc.AddFontFile(cbFont.SelectedItem.ToString());
			//pfc.AddFontFile(FontFile);

			NewFont = new System.Drawing.Font(pfc.Families[0], (int)numericUpDown1.Value);
			//NewFont = new System.Drawing.Font(pfc.Families[0], lblExample.Font.Size);
			lblExample.Font = NewFont;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			cbFont_SelectionChangeCommitted_1(sender, e);
		}
	}
}
