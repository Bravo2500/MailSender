/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 22.08.2012
 * Time: 1:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using MAIL.controls;
using MAIL.buttons;

namespace MAIL.labels
{
	/// <summary>
	/// Description of EDITMAILTEXTLABEL.
	/// </summary>
	public class EDITMAILTEXTLABEL
	{
		const int container_label_width = 630;
		const int container_label_height = 682;
		const int mail_content_textbox_offset_x = 5;
		const int mail_content_textbox_offset_y = 32;
		const int mail_content_textbox_height = 450;  //644

		
		private Label container_label;
		private TextFieldWithName title_bar;
		private TextBox mail_content_textbox;
		private ADDFILELABEL add_file_label;
		
		public Label label
		{
			get { return container_label; }
		}
		
		public EDITMAILTEXTLABEL(String title, Color color )
		{
			container_label = new Label();
			container_label.Size = new Size(container_label_width, container_label_height);
			container_label.BackColor = color;
			
			mail_content_textbox = new TextBox();
			mail_content_textbox.Size = new Size(container_label_width - mail_content_textbox_offset_x*2,
			                                     mail_content_textbox_height);
			mail_content_textbox.Multiline = true;
			mail_content_textbox.BackColor = Color.WhiteSmoke;
			
			title_bar = new TextFieldWithName(title, color);
			title_bar.HideTextBox();
			
			add_file_label = new ADDFILELABEL("Title", color);
			add_file_label.label.Location = new Point(0, 482);
			
			container_label.Controls.Add(mail_content_textbox);
			container_label.Controls.Add(title_bar.label);
			container_label.Controls.Add(add_file_label.label);
						
			mail_content_textbox.Location = new Point(mail_content_textbox_offset_x, mail_content_textbox_offset_y);
			
			
		}
		
		public void SetLocation(Point locat)
		{
			container_label.Location = locat;			
		}
		
		public String GetTextBoxContent()
		{
			return mail_content_textbox.Text;
		}
		
		public List <String> GetListBoxContent()
		{
			return add_file_label.GetAttachedFilesList();
		}
		

	}
}
