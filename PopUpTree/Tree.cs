//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - BTree
//	File Name:		Tree.cs
//	Description:	Display for BTree Program	
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Justin Adams, adamsjl3@etsu.edu, Undergrad CS, East Tennessee State University
//	Created:		Monday, November 10, 2017
//	Copyright:		Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using Project5;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PopUpTree
{
	/// <summary>
	/// Windows Form to display BTree
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class Tree : Form
	{
		#region Properties
		/// <summary>
		/// Gets or sets the b.
		/// </summary>
		/// <value>
		/// The b.
		/// </value>
		public BTree b { get; set; }
		/// <summary>
		/// The tree node
		/// </summary>
		List<string> treeNode = new List<string> ( );
		#endregion

		#region Constructors
		/// <summary>
		/// Initializes a new instance of the <see cref="Tree"/> class.
		/// </summary>
		public Tree ( )
		{
			InitializeComponent ( );
		}//End Tree ( )
		 /// <summary>
		 /// Initializes a new instance of the <see cref="Tree"/> class.
		 /// </summary>
		 /// <param name="b">The b.</param>
		public Tree (BTree b)
		{
			this.b = b;
			InitializeComponent ( );
			SetValues ( );
		}//End Tree (BTree) 
		#endregion

		#region Methods
		/// <summary>
		/// Sets the values.
		/// </summary>
		/// <param name="b">The BTree.</param>
		private void SetValues ( )
		{
			//Set Stats
			OutItemLabel.Text = b.Count.ToString ( );
			OutIndexLabel.Text = b.IndexCount.ToString ( );
			OutLeafLabel.Text = b.LeafCount.ToString ( );
			int Space = (((b.NodeSize - 1) * b.LeafCount) + (b.NodeSize -1) * b.IndexCount);
			decimal fill = ((decimal) b.Count / Space);
			OutFillLabel.Text = String.Format ("{0:P0}", fill);
			treeNode = b.Display ( );
			OutHeightLabel.Text = treeNode.Count.ToString ( );
			//Set Tree Nodes
			SetTree (treeNode);
		}//End SetValues (BTree) 

		/// <summary>
		/// Sets the tree.
		/// </summary>
		/// <param name="treeNode">The tree node.</param>
		private void SetTree (List<string> treeNode)
		{
			treeView1.BeginUpdate ( );
			if (treeView1.Nodes != null)
			{
				treeView1.Nodes.Clear ( );
			}//End if statement
			for (int x = 0 ; x < treeNode.Count ; x++)
			{
				treeView1.Nodes.Add (new TreeNode ("Level " + x));
				string [ ] line = treeNode [x].Split ('@');
				for (int y = 0 ; y < line.Length ; y++)
				{
					treeView1.Nodes [x].Nodes.Add (line [y]);
				}//end for loop
			}//end for loop
			 // Reset the cursor to the default for all controls.
			Cursor.Current = Cursors.Default;
			// Begin repainting the TreeView.
			treeView1.EndUpdate ( );
		}//End SetTree (List<string>)
		#endregion

		#region Click Event
		/// <summary>
		/// Handles the Click event of the AddButton control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
		private void AddButton_Click (object sender, System.EventArgs e)
		{
			int newValue = 0;
			try
			{
				newValue = Int32.Parse (AddTextBox.Text);
				bool results = b.AddValue (newValue);
				if (results)
				{
					SetValues ( );
				}//End if statement
				else
				{
					MessageBox.Show ("Value is already added",
								"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
				}//End else statement
			}//End try statement
			catch (ArgumentNullException)
			{
				MessageBox.Show ("There is no data in field",
								"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}//End catch statement
			catch (FormatException)
			{
				MessageBox.Show ("There is Invalid data in field",
							"Error",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);
			}//End catch statement
			AddTextBox.Text = "";
			SetValues ( );
		}//End AddButton_Click (object, System.EventArgs)

		/// <summary>
		/// Handles the Click event of the FindButton control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void FindButton_Click (object sender, EventArgs e)
		{
			int newValue;
			Leaf returnLeaf;
			Node returnNode;
			try
			{
				newValue = Int32.Parse (FindTextBox.Text);
				returnLeaf = b.FindLeaf (newValue);
				returnNode = b.Root;
				MessageBox.Show (returnLeaf+"\n"+returnNode,
								"Found",
								MessageBoxButtons.OK,
								MessageBoxIcon.Hand);
			}//End try statement
			catch (ArgumentNullException)
			{
				MessageBox.Show ("There is no data in field",
								"Error",
								MessageBoxButtons.OK,
								MessageBoxIcon.Error);
			}//End catch statement
			catch (FormatException)
			{
				MessageBox.Show ("There is Invalid data in field",
							"Error",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);
			}//End catch statement
			FindTextBox.Text = "";
			b.ReturnToTop ( ); 
		}//End FindButton_Click (object, EventArgs)
		#endregion
	}//End Tree
}//End PopUpTree
