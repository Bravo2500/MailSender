/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 22.08.2012
 * Time: 2:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;

namespace MAIL.buttons
{
	/// <summary>
	/// Description of SENDMAILBUTTON.
	/// </summary>
	public class SENDMAILBUTTON : BUTTONPROTOTYPE
	{
		const int width = 165;
		const int height = 74;
		
		public SENDMAILBUTTON(String btn_name, Color color)
		{
			//btn = new Button();
			btn.Size = new Size(width, height);
			btn.Text = btn_name;
			btn.BackColor = color;
		
		}
		
		public void SetLocation(Point locat)
		{
			btn.Location = new Point(locat.X, locat.Y - 2);
		}
	}
}
