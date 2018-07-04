//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - BTree
//	File Name:		MenuForm.cs
//	Description:	Initializer for BTree Program	
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Justin Adams, adamsjl3@etsu.edu, Undergrad CS, East Tennessee State University
//	Created:		Monday, November 10, 2017
//	Copyright:		Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////using Project5;
using Project5;
using System;
using System.Windows.Forms;

namespace PopUpTree
{
	/// <summary>
	/// Start up Page for BTree Application
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class MenuForm : Form
	{
		#region Properties
		/// <summary>
		/// The random between 0-9999
		/// </summary>
		Random random = new Random ( );
		/// <summary>
		/// The b tree
		/// </summary>
		public static BTree b;
		/// <summary>
		/// Gets or sets the number nodes.
		/// </summary>
		/// <value>
		/// The number nodes.
		/// </value>
		public static int numNodes { get; set; } 
		/// <summary>
		/// Gets or sets the size of the node.
		/// </summary>
		/// <value>
		/// The size of the node.
		/// </value>
		public static int NodeSize { get; set; } 
		#endregion

		#region Constructor
		/// <summary>
		/// Initializes a new instance of the <see cref="MenuForm"/> class.
		/// </summary>
		public MenuForm ( )
		{
			InitializeComponent ( );
		}//End MenuForm ( ) 
		#endregion

		#region Click Event
		/// <summary>
		/// Handles the Click event of the TreeButton control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void TreeButton_Click (object sender, EventArgs e)
		{
			bool valid = true;
			try
			{
				numNodes = Int32.Parse (StartTextBox.Text);
				NodeSize = Int32.Parse (NodeTextBox.Text);
			}//End try statement
			catch (ArgumentNullException)
			{
				MessageBox.Show ("There is no data in field",
								"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
				valid = false;
			}//End else statement
			catch (FormatException)
			{
				MessageBox.Show ("There is Invalid data in field",
							"Error",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);
				valid = false;
			}//End else statement
			if (valid)
			{
				b = new BTree (NodeSize);
				int next;
				int [ ] values = new int [numNodes];
				if (RandomCheckBox.Checked)
				{
					for (int i = 0 ; i < numNodes ; i++)
					{
						next = random.Next (0, 10000);
						values [i] = next;
					}//end for loop	
				}//End if statement
				else
				{
					for (int i = 0 ; i < numNodes ; i++)
					{
						values [i] = i;
					}//end for loop
				}//End else statement
				for (int i = 0 ; i < values.Length ; i++)
				{
					b.AddValue (values [i]);
				}//end for loop
				Tree tree = new Tree (b);
				tree.ShowDialog ( ); 
			}//End if statement
		}//End TreeButton_Click (object, EventArgs)  
		#endregion
	}//End MenuForm
}//End PopUpTree
