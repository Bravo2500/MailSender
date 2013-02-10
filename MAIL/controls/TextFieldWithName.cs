/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 21.08.2012
 * Time: 22:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows;
using System.ComponentModel;
using System.Linq;

namespace MAIL.controls
{
	/// <summary>
	/// Description of MAILTOTEXTBOX.
	/// </summary>
	public class TextFieldWithName
	{
		private const int container_label_width = 460;
		private const int container_label_height = 30;
		private const int border_size = 5;
		private const int text_field_width = 0;
		private const int text_field_height = 0;
		private const int left_label_width = 108;
		private const int text_box_width = 348;
		private Label left_label;
		private Label container_label;
		
		private TextBox textbox;
		
		public Label label
		{
			get { return container_label; }
		}
		
		public TextFieldWithName(String field_name, Color background_color)
		{
			//container label settings
			container_label = new Label();
			container_label.Location= new Point(0, 0);
			container_label.Size = new Size(container_label_width, container_label_height);
			container_label.BackColor = background_color;
			
			//left_label settings
			left_label = new Label();
			left_label.Location = new Point(0, 0);
			left_label.Size = new Size(left_label_width, container_label_height);
			left_label.ForeColor = Color.Black;
			left_label.Text = field_name;
			left_label.TextAlign = ContentAlignment.MiddleCenter;
			container_label.Controls.Add(left_label);
			
			//textbox settings
			textbox = new TextBox();
			textbox.Location = new Point(left_label.Width, border_size);
			
			Point textbox_right_down_dot = new Point(0, 0);
			textbox_right_down_dot.X = container_label.Location.X + container_label.Size.Width - 5;
			textbox_right_down_dot.Y = container_label.Location.Y + container_label.Size.Height - 5;		
	
			Size textbox_size = new Size(0, 0);
			textbox_size.Width = textbox_right_down_dot.X - textbox.Location.X;
			textbox_size.Height = textbox_right_down_dot.Y - textbox.Location.Y;
			textbox.Size = textbox_size;
			textbox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
				
			textbox.BackColor = Color.WhiteSmoke;
			textbox.ForeColor = Color.Black;
			container_label.Controls.Add(textbox);
						
			textbox.KeyDown += new KeyEventHandler(OnCtrlA);
			ShowTextBox();
		}
		
		public void SetLocation(Point locat)
		{
			container_label.Location = locat;
		}
		
		public void SetSize(Size sz)
		{
			container_label.Size = sz;
		}
		
		public void ShowTextBox()
		{
			textbox.Show();
		}
		
		public void HideTextBox()
		{
			textbox.Hide();
		}
		
		public String GetTextBoxContent()
		{
			return textbox.Text;
		}
		
		private void OnCtrlA(object sender, KeyEventArgs e)
		{
			if (e.Control & e.KeyCode == Keys.A)
                textbox.SelectAll();
		
		}
	}
}
