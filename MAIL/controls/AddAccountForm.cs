/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 16.09.2012
 * Time: 22:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MAIL.Forms
{
	/// <summary>
	/// Description of ADDACCOUNTFORM.
	/// </summary>
	public class ADDACCOUNTFORM : Form
	{
		private const int width = 200;
		private const int height = 200;
			
		private Button ok_button;
		private Button cancel_button;
		
		public ADDACCOUNTFORM()
		{
		
			InitializeComponent();
		}
		
		private void InitializeComponent()
		{
			// 
			// MainForm
			// 
			this.Text = "Create New Account";
			this.Name = "MainForm";
			this.Size = new Size(width, height);
			
			this.WindowState = FormWindowState.Normal;
			//this.FormBorderStyle = FormBorderStyle.None;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ControlBox = false;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			
			ok_button = new Button();
			ok_button.Text = "Ok";
				
			cancel_button = new Button();
			cancel_button.Text = "Cancel";
			this.Controls.Add(ok_button);
			this.Controls.Add(cancel_button);

		}
	}
}
