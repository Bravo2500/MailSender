/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 21.08.2012
 * Time: 20:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace MAIL
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			PanelManager panel_manager = new PanelManager();
			
		//	main_form.Show();
		//	String smtp_serv = "smtp.gmail.com";
		//	MailSender mail_sender = new MailSender(smtp_serv);
		//	mail_sender.SendMessage();
			
			Application.Run(panel_manager.form);
		}
		
	}
}
