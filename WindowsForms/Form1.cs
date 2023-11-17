using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class Form1 : Form
	{
		bool visible_controls;
		bool show_date;

		const string font_file_default = "7Led-8RoJ.ttf";
		string font_file;
		int size;
		Color foreground;
		Color background;


		WindowsForms.Font choose_font;

		public Form1()
		{
			/*this.Location = new System.Drawing.Point
				(
				System.Windows.Forms.Screen.PrimaryScreen.Bounds.Right - this.Width - 50,
				System.Windows.Forms.Screen.PrimaryScreen.Bounds.Top + 50
				);*/

			InitializeComponent();

			visible_controls = false;
			show_date = false;

			btnHideControls.Visible = false;
			btnClose.Visible = false;


			choose_font = new WindowsForms.Font(label1.Font);

			/*StreamReader sr = new StreamReader("Settings.cfg");

			string font_file = sr.ReadLine();
			int size = Convert.ToInt32(sr.ReadLine());

			sr.Close();*/
			LoadSettings();
		}
		public void SaveSettings()
		{
			StreamWriter sw = new StreamWriter("Settings.cfg");

			/*
			sw.WriteLine("Font:"		 + choose_font.FontFile);
			sw.WriteLine("Size:"		 + label1.Font.Size);
			sw.WriteLine("ForeColor:"	 + label1.ForeColor);
			sw.WriteLine("BackColor:"	 + label1.BackColor);*/

			sw.WriteLine(font_file);
			sw.WriteLine(label1.Font.Size);
			sw.WriteLine(label1.ForeColor.ToArgb());
			sw.WriteLine(label1.BackColor.ToArgb());
			sw.Close();
		}
		public void LoadSettings()
		{
			MessageBox.Show(this, Directory.GetCurrentDirectory(), "Directory", MessageBoxButtons.OK);
			StreamReader sr = new StreamReader("Settings.cfg");
			MessageBox.Show(this, sr.ToString(), "Directory", MessageBoxButtons.OK);

			font_file = sr.ReadLine();
			if (font_file == null || font_file == "")
			{
				font_file = font_file_default;
			}

			size = Convert.ToInt32(sr.ReadLine());
			if (size == 0)
			{
				size = 48;
			}

			foreground = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));
			background = Color.FromArgb(Convert.ToInt32(sr.ReadLine()));

			sr.Close();


			PrivateFontCollection pfc = new PrivateFontCollection();
			pfc.AddFontFile(font_file);

			System.Drawing.Font font = new System.Drawing.Font(pfc.Families[0], size);
			label1.Font = font;
			label1.ForeColor = foreground;
			label1.BackColor = background;
		}
		private void SetShowDate(bool show_date)
		{
			this.show_date = show_date;

			cbShowDate.Checked = show_date;
			showDateToolStripMenuItem.Checked = show_date;
		}
		private void SetConstrolsVisibility(bool visible_controls)
		{
			this.visible_controls = visible_controls;

			this.FormBorderStyle = visible_controls ? FormBorderStyle.Sizable : FormBorderStyle.None;
			this.TransparencyKey = visible_controls ? Color.AliceBlue : SystemColors.Control;

			this.ShowInTaskbar = visible_controls;
			this.cbShowDate.Visible = visible_controls;

			this.btnHideControls.Visible = visible_controls;
			this.btnClose.Visible = visible_controls;

			//this.notifyIcon1.Visible = !visible_controls;

			this.showControlsToolStripMenuItem.Checked = visible_controls;
			this.btnFont.Visible = visible_controls;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			//https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
			//https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings

			label1.Text = DateTime.Now.ToString("HH:mm:ss tt");

			if (cbShowDate.Checked)
			{
				label1.Text += $"\n{DateTime.Now.ToString("gg\ndd.MM.yyyy")}";
			}
			notifyIcon1.Text = DateTime.Now.ToString($"hh:mm:ss tt");
		}

		private void label1_DoubleClick(object sender, EventArgs e)
		{
			/*this.FormBorderStyle = FormBorderStyle.Sizable;
			this.TransparencyKey = Color.AliceBlue;

			this.ShowInTaskbar = true;
			this.cbShowDate.Visible = true;

			this.btnHideControls.Visible = true;
			this.btnClose.Visible = true;*/

			SetConstrolsVisibility(true);
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{/*
			this.FormBorderStyle = FormBorderStyle.None;
			this.TransparencyKey = SystemColors.Control;

			this.ShowInTaskbar = false;
			this.cbShowDate.Visible = false;

			this.btnHideControls.Visible = false;
			this.btnClose.Visible = false;
			*/

			SetConstrolsVisibility(false);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			SaveSettings();
			this.Close();
		}

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
		{

		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveSettings();
			this.Close();
		}

		private void showControlsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			/*
			 if (this.FormBorderStyle == FormBorderStyle.None)
			{
				this.FormBorderStyle = FormBorderStyle.Sizable;
				this.TransparencyKey = Color.AliceBlue;

				this.ShowInTaskbar = true;
				this.cbShowDate.Visible = true;

				this.btnHideControls.Visible = true;
				this.btnClose.Visible = true;
			}
			else
			{
				this.FormBorderStyle = FormBorderStyle.None;
				this.TransparencyKey = SystemColors.Control;

				this.ShowInTaskbar = false;
				this.cbShowDate.Visible = false;

				this.btnHideControls.Visible = false;
				this.btnClose.Visible = false;
			}
			*/


			
			if (showControlsToolStripMenuItem.Checked)
			{
				label1_DoubleClick(sender, e);
			}
			else
			{
				btnHideControls_Click(sender, e);
			}

		}

		private void showDateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			/*
			 if(this.cbShowDate.Checked == false)
			{
				this.cbShowDate.Checked = true;

				this.label1.Text += $"\n{DateTime.Now.ToString("gg\ndd.MM.yyyy")}";
			}
			else
			{
				this.label1.Text = DateTime.Now.ToString("HH:mm:ss tt");

				this.cbShowDate.Checked = false;
			}
			*/

			//cbShowDate.Checked = showDateToolStripMenuItem.Checked;

			this.show_date = showDateToolStripMenuItem.Checked;
			SetShowDate(show_date);
		}

		private void cbShowDate_CheckedChanged(object sender, EventArgs e)
		{
			SetShowDate(cbShowDate.Checked);
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			label1_DoubleClick(sender, e);
		}

		private void btnFontChanger_Click(object sender, EventArgs e)
		{
			//PrivateFontCollection Fonter = new PrivateFontCollection();

			//Fonter.AddFontFile("C:\\Users\\tekat\\source\\repos\\WindowsForms\\WindowsForms\\TanaUncialSP.otf");
			//Font CustomFont = new Font(Fonter.Families[0], label1.Font.Size);

			//this.label1.Font = CustomFont;
		}

		private void btnFont_Click(object sender, EventArgs e)
		{
			//Font font = new Font(label1.Font);

			choose_font.ShowDialog(this);

			label1.Font = choose_font.OldFont;
			font_file = choose_font.FontFile;
		}

		private void Form1_ContextMenuStripChanged(object sender, EventArgs e)
		{

		}

		private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog(this);
			label1.ForeColor = colorDialog1.Color;
		}

		private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog(this);
			label1.BackColor = colorDialog1.Color;
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			//btnFont_Click(sender, e);
			choose_font.ShowDialog(this);
			label1.Font = choose_font.OldFont;
			font_file = choose_font.FontFile;
		}
	}
}
