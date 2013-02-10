/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 21.08.2012
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MAIL
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private NotifyIcon  tray_icon;
	    private ContextMenu tray_menu;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		protected override void OnResize(EventArgs e)
		{
 			if(this.WindowState==FormWindowState.Minimized)
 			{
 				this.Hide();
	 			//this.WindowState=FormWindowState.Normal;
	 			tray_menu = new ContextMenu();
	 			tray_menu.MenuItems.Add("Open", OnClick);
	 			tray_menu.MenuItems.Add("Exit", OnExit);

	            tray_icon = new NotifyIcon();
	            tray_icon.Text = "MailSender";
	            tray_icon.Icon = new Icon(SystemIcons.Application, 40, 40);
	            tray_icon.Click += new EventHandler(OnClick);
	            tray_icon.ContextMenu = tray_menu;
				tray_icon.Visible = true;
 			}
 			else
 				base.OnResize (e);
 		}
		
		private void OnExit(object sender, EventArgs e)
	    {
	       Application.Exit();
	    }
		
		private void OnClick(object sender, EventArgs e)
		{
			tray_icon.Visible = false;
			this.Show();
			this.WindowState = FormWindowState.Maximized;
		}
	}
}
