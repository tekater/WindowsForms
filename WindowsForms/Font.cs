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
		public System.Drawing.Font NewFont { get; set; }
		public System.Drawing.Font OldFont { get; set; }
		public Font()
		{
			InitializeComponent();

			Directory.SetCurrentDirectory("..\\..\\Fonts");
			string currentDirectory = Directory.GetCurrentDirectory();
			/*MessageBox.Show
				(
				this,
				currentDirectory,
				"Current Directory",
				MessageBoxButtons.OK
				);*/

			foreach (string i in Directory.GetFiles(currentDirectory))
			{
				if (i.Split('\\').Last().Contains(".ttf") || i.Split('\\').Last().Contains(".otf"))
				{
				this.cbFont.Items.Add(i.Split('\\').Last());
				}
			}
		}
		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			OldFont = NewFont;
			this.Close();
		}

		private void cbFont_SelectionChangeCommitted_1(object sender, EventArgs e)
		{
			PrivateFontCollection pfc = new PrivateFontCollection();

			pfc.AddFontFile(cbFont.SelectedItem.ToString());

			NewFont = new System.Drawing.Font(pfc.Families[0], lblExample.Font.Size);
			lblExample.Font = NewFont;
		}
	}
}
