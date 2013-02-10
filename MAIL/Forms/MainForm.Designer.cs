/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 21.08.2012
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Windows.Forms;

namespace MAIL
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.WindowState = FormWindowState.Normal;
			//this.WindowState = FormWindowState.Maximized;
			//this.FormBorderStyle = FormBorderStyle.None;
			//this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(658,818);
			this.MaximumSize = new System.Drawing.Size(658,818);
			this.Text = "MAIL";
			this.Name = "MainForm";
		}
		

	}
}
