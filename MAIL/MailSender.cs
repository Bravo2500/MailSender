/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 21.08.2012
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;

namespace MAIL
{
	/// <summary>
	/// Description of MailSender.
	/// </summary>
	public class MailSender
	{
		private MailMessage mail;
		private SmtpClient smtp_server;
		private List <String> attached_files_list;
		private bool message_can_be_send;
		//private String mail_from_address;
				
		public MailSender()
		{
			smtp_server = new SmtpClient("smtp.gmail.com");
			message_can_be_send = false;
			attached_files_list = new List<String>();
		}
		
		public void GetConfigurationFromFile()
		{
			if(File.Exists("hosts.txt")) 
			{
				StreamReader hosts_file = new StreamReader("hosts.txt");
				string line = "";
				while ((line = hosts_file.ReadLine()) != null)
            	{
					string [] split_line = line.Split(new Char[]{' '});
					if (split_line.Length == 2)
					{
						smtp_server.Host = split_line[0];
						smtp_server.Port = Int32.Parse(split_line[1]);
						MessageBox.Show(split_line[1], "title", MessageBoxButtons.YesNo);
					}
					Console.WriteLine(line);
                    
            	}
				Console.Write("11");
				hosts_file.Close();
			}
			else
			{
				StreamWriter hosts_file = new StreamWriter("hosts.txt");
				hosts_file.WriteLine("smtp.gmail.com 587");
				hosts_file.Close();
			}
			
			
		}
		
		public void ConfigureSmtpClient(String user_login, String user_password)
		{
		    smtp_server.Port = 587;
            smtp_server.Credentials = new System.Net.NetworkCredential(user_login, user_password);
            smtp_server.EnableSsl = true;
		
		}
		
		public void WriteNewMail(String mail_from, String mail_to, String subject, String body)
		{
			mail = new MailMessage();
			mail.IsBodyHtml = false;
			//mail.From now must be equal to Сredentials (user_login@gmail.com)
			
			message_can_be_send = true;
			if ((mail_from != null) && (mail_from.Length > 0))
			{
				mail.From = new MailAddress(mail_from);
			}
			else 
			{
				MessageBox.Show("Please, insert correct address to MAIL_FROM: field");
				message_can_be_send = false;
				return;
			}
			
			if ((mail_to != null) && (mail_to.Length > 0))
			{
				MessageBox.Show(mail_to.ToString());
				mail.To.Add(mail_to);
			}
			else 
			{
				MessageBox.Show("Please, insert correct address to MAIL_TO: field");
				message_can_be_send = false;
				return;
			}
			
            mail.Subject = subject;
            mail.Body = body;
		}
		
		public void AddAttachments(List <String> files_list)
		{
			mail.Attachments.Clear();
			for(int i = 0; i < files_list.Count; i++)
			{
				mail.Attachments.Add(new Attachment(files_list[i]));
				MessageBox.Show(files_list[i]);
			}
			
		}
		
		public void SendMessage()
	    {
			if (message_can_be_send == true)           
			{
				try
            	{
            		smtp_server.Send(mail);
                	MessageBox.Show("mail Send");
            	}
            	catch (Exception ex)
            	{
                	MessageBox.Show(ex.ToString());
            	}
			}
			else
			{
				//MessageBox.Show("Sorry, message with such parameters can't be send");
			}
		}
	}
}
