/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 21.08.2012
 * Time: 21:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using MAIL.panels;

namespace MAIL
{
	/// <summary>
	/// Description of PANELMANAGER.
	/// </summary>
	public class PanelManager
	{
		private MainForm main_form;
		private SendMailPanel send_mail_panl;
		
		//private MAILLISTPANEL accounts_list_panl;
		
		public Panel send_mail_panel
		{
			get { return send_mail_panl; }
		}
		
		public MainForm form
		{
			get { return main_form; }
		}
		public PanelManager()
		{
			MailSender mail_sender = new MailSender();
			mail_sender.GetConfigurationFromFile();
			main_form = new MainForm();
			send_mail_panl = new SendMailPanel();
			main_form.Controls.Add(send_mail_panl);

		}
		
		public void ShowSendMailPanel()
		{
			send_mail_panel.Show();
		}
	}
}
