﻿namespace WindowsForms
{
	partial class Font
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
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.cbFont = new System.Windows.Forms.ComboBox();
			this.lblExample = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(12, 141);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(119, 48);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(286, 141);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(119, 48);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// cbFont
			// 
			this.cbFont.FormattingEnabled = true;
			this.cbFont.Location = new System.Drawing.Point(12, 12);
			this.cbFont.Name = "cbFont";
			this.cbFont.Size = new System.Drawing.Size(392, 21);
			this.cbFont.TabIndex = 2;
			this.cbFont.SelectionChangeCommitted += new System.EventHandler(this.cbFont_SelectionChangeCommitted_1);
			// 
			// lblExample
			// 
			this.lblExample.AutoSize = true;
			this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblExample.Location = new System.Drawing.Point(12, 96);
			this.lblExample.Name = "lblExample";
			this.lblExample.Size = new System.Drawing.Size(163, 42);
			this.lblExample.TabIndex = 3;
			this.lblExample.Text = "Example";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(279, 96);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 4;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// Font
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 195);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.lblExample);
			this.Controls.Add(this.cbFont);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Location = new System.Drawing.Point(1000, 0);
			this.Name = "Font";
			this.Text = "Font";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ComboBox cbFont;
		private System.Windows.Forms.Label lblExample;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}