/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 21.08.2012
 * Time: 21:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using MAIL.controls;
using MAIL.labels;
using MAIL.buttons;

namespace MAIL.panels
{
	/// <summary>
	/// Description of SENDMAILPANEL.
	/// </summary>
	public class SendMailPanel : Panel
	{
		private const int loc_x = 0;
		private const int loc_y = 0;
		private const int width = 650;
		private const int height = 785;
		private const int text_field_to_offset_x = 10;
		private const int text_field_to_offset_y = 10;
		private const int text_field_subject_offset_x = 10;
		private const int text_field_subject_offset_y = 50;		
		private const int text_field_content_offset_x = 10;
		private const int text_field_content_offset_y = 92;
		private const int send_mail_button_offset_x = 476;
		private const int send_mail_button_offset_y = 10;
		
		private TextFieldWithName text_field_to;
		private TextFieldWithName text_field_subject;
		private EDITMAILTEXTLABEL edit_mail_text_label;
		private SENDMAILBUTTON send_mail_button;
				
		private MailSender mail_sender;
		
		public SendMailPanel()
		{
			//mail_sender = new MailSender("smtp.gmail.com");
			
			this.Location = new Point(loc_x, loc_y); //250, 10
			this.Size = new Size(width, height);
			this.MinimumSize = new Size(width, height);
			this.MaximumSize = new Size(width, height);
			this.BackColor = Color.Orange;
			
			text_field_to = new TextFieldWithName("MAIL_TO:", Color.LightGray);
			text_field_subject = new TextFieldWithName("SUBJECT:", Color.LightGray);
			edit_mail_text_label = new EDITMAILTEXTLABEL("CONTENT:", Color.LightGray);
			send_mail_button = new SENDMAILBUTTON("SEND MESSAGE", Color.LightGray);
			//add_file_label = new ADDFILELABEL(" ", Color.LightGray);
			
			this.Controls.Add(text_field_to.label);
			this.Controls.Add(text_field_subject.label);
			this.Controls.Add(edit_mail_text_label.label);
			this.Controls.Add(send_mail_button.button);
			//this.Controls.Add(add_file_label.label);
			
			text_field_to.SetLocation(new Point(text_field_to_offset_x, text_field_to_offset_y));
			text_field_subject.SetLocation(new Point(text_field_subject_offset_x, text_field_subject_offset_y));
			edit_mail_text_label.SetLocation(new Point(text_field_content_offset_x, text_field_content_offset_y));
			send_mail_button.SetLocation(new Point(send_mail_button_offset_x, send_mail_button_offset_y));
			
			send_mail_button.button.Click += new EventHandler(OnSendMailButtonClick);
			//text_field_to.Size = new Size(text_field_to_width, text_field_to_height);
			
		}
		
		private void OnSendMailButtonClick(object sender, EventArgs e)
		{
			if (sender == send_mail_button.button)
			{
				String account_name = "Delaar88";
				String account_password = "14921988";
				String mail_to = text_field_to.GetTextBoxContent();
				String subject = text_field_subject.GetTextBoxContent();
				String content = edit_mail_text_label.GetTextBoxContent();
				List <String> attachments = edit_mail_text_label.GetListBoxContent();
				//text_field_to.
				mail_sender.ConfigureSmtpClient(account_name, account_password);
				mail_sender.WriteNewMail("Delaar88@gmail.com", mail_to, subject, content);
				mail_sender.AddAttachments(attachments);
				mail_sender.SendMessage();
			}
		}
	}
}
