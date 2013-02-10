/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 22.08.2012
 * Time: 2:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;

namespace MAIL.buttons
{
	/// <summary>
	/// Description of BUTTONPROTOTYPE.
	/// </summary>
	public class BUTTONPROTOTYPE
	{
		protected Button btn;
		
		public Button button
		{
			get { return btn; }
		}
		
		public BUTTONPROTOTYPE()
		{
			btn = new Button();
			btn.Click += new EventHandler(OnButtonClick);
		}
		
		//Эта функция, возможно, не пригодится. В будущем - или оставить, или удалить
		protected void OnButtonClick(object sender, EventArgs e)
		{
			if (sender == this.btn)
			{
				//MessageBox.Show("Button clicked");
			}
		}
	}
}
