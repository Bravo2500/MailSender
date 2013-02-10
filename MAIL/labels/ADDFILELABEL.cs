/*
 * Created by SharpDevelop.
 * User: Aleksandr
 * Date: 23.08.2012
 * Time: 22:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using MAIL.buttons;
using MAIL.controls;
namespace MAIL.labels
{
	/// <summary>
	/// Description of ADDFILELABEL.
	/// </summary>
	public class ADDFILELABEL 
	{
		const int container_label_width = 870;
		const int container_label_height = 190;
		const int add_file_button_width = 160; //165
		const int add_file_button_height = 74;
		const int add_file_button_offset_x = 466;
		const int add_file_button_offset_y = 5;
		const int add_files_list_offset_x = 5;
		const int add_files_list_offset_y = 30;
		
		private Label container_label;
		private TextFieldWithName attachment_title_label;
		private SENDMAILBUTTON add_file_button;
		private ListBox added_files_list;
		
		public Label label
		{
			get { return container_label; }
		}
				
		public ADDFILELABEL(String title, Color color)
		{
			container_label = new Label();
			container_label.Size = new Size(container_label_width, container_label_height);
			container_label.BackColor = color;
			//container_label.Text = title;
			
			add_file_button = new SENDMAILBUTTON("ADD_FILE", Color.LightGray);
			add_file_button.button.Location = new Point(add_file_button_offset_x, add_files_list_offset_y);
			add_file_button.button.Size = new Size(add_file_button_width, add_file_button_height);
			
			attachment_title_label = new TextFieldWithName("ATTACHMENTS:", Color.LightGray);
			attachment_title_label.HideTextBox();
			
			added_files_list = new ListBox();
			added_files_list.Location = new Point(add_files_list_offset_x, add_files_list_offset_y);
			added_files_list.Size = new Size(400, 160);
			added_files_list.SelectionMode = SelectionMode.MultiExtended;
			
			container_label.Controls.Add(add_file_button.button);
			container_label.Controls.Add(added_files_list);
			container_label.Controls.Add(attachment_title_label.label);
			
			//container_label.PreviewKeyDown = true;
			added_files_list.KeyDown += new KeyEventHandler(OnKeyboardButtonClick);
			add_file_button.button.Click += new EventHandler(OnAddFileButtonClick);
		}
		
		public void OnAddFileButtonClick(object sender, EventArgs e)
		{
		    if (sender == add_file_button.button)
			{
				OpenFileDialog open_file_dialog = new OpenFileDialog();
				open_file_dialog.InitialDirectory = "d:\\" ;
   				open_file_dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" ;
    			open_file_dialog.FilterIndex = 2 ;
   		    	open_file_dialog.RestoreDirectory = true ;
   		    	open_file_dialog.Multiselect = true;
   		    	
   		    	DialogResult dialog_result = open_file_dialog.ShowDialog();
	   			if (dialog_result == DialogResult.OK) // Test result.
	    		{
	    			foreach (String file in open_file_dialog.FileNames) 
	    			{
	    				added_files_list.Items.Add(file);
	    			}
	   			}
	   			else
	   			{
	   				//MessageBox.Show(open_file_dialog); // <-- For debugging use only.
	   			}
	   		}
		}
		
		public List <String> GetAttachedFilesList()
		{
			List <String> files_list = new List<String>();
			for(int i = 0; i < added_files_list.Items.Count; i++)
			{
				files_list.Add(added_files_list.Items[i].ToString());
			}
			//MessageBox.Show(files_list.Count.ToString());
			return files_list;
		}
		
		
		private void OnKeyboardButtonClick(object sender, KeyEventArgs e)
		{
			if (sender == added_files_list)
			{
				if (e.KeyData == Keys.Delete)
				{
				    for(int i = added_files_list.SelectedIndices.Count-1; i >= 0; i--)
                        {
				    		int k = added_files_list.SelectedIndices[i]; 	
				    	    
				        	added_files_list.Items.RemoveAt(added_files_list.SelectedIndices[i]);
				        	if (i == 0) 
				        		if (added_files_list.Items.Count > 0)
				        			if (k > added_files_list.Items.Count)
				        			   added_files_list.SetSelected(k-1, true);
					    }
					//MessageBox.Show("Delete");
				}
				
			}
		}
		
	}
}
