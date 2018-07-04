//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - BTree
//	File Name:		Index.cs
//	Description:	Indexes node for BTree Class
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Justin Adams, adamsjl3@etsu.edu, Undergrad CS, East Tennessee State University
//	Created:		Monday, November 10, 2017
//	Copyright:		Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections.Generic;

namespace Project5
{
	/// <summary>
	/// Implements Node class using the node to reference Leaf Nodes
	/// </summary>
	public class Index : Node
	{
		#region Properties

		/// <summary>
		/// Gets or sets the indexes.
		/// </summary>
		/// <value>
		/// The indexes.
		/// </value>
		public List<Node> Indexes { get; set; }

		/// <summary>
		/// Gets or sets the sort list.
		/// </summary>
		/// <value>
		/// The sort list.
		/// </value>
		public List<int> SortList { get; set; }

		#endregion Properties

		#region Methods

		/// <summary>
		/// Initializes a new instance of the <see cref="Index" /> class.
		/// </summary>
		public Index ( )
		{
			Indexes = new List<Node> ( );
		}//End Index ( )

		/// <summary>
		/// Initializes a new instance of the <see cref="Index" /> class.
		/// </summary>
		/// <param name="n">The n.</param>
		public Index (int n)
		{
			base.NodeSize = n;
			base.Value = new List<int> (n);
			Indexes = new List<Node> (n);
		}//End Index (int)

		/// <summary>
		/// Inserts the specified n.
		/// </summary>
		/// <param name="N">The median value.</param>
		/// <param name="node">The node.</param>
		/// <returns>
		/// If node was inserted
		/// </returns>
		public INSERT Insert (Node node)
		{
			if (this.Indexes.Count == this.Indexes.Capacity)
			{
				return INSERT.NEEDSPLIT;
			}//End if statement
			Indexes.Add (node);
			SortList = new List<int> (Indexes.Count);
			for (int i = 0 ; i < Indexes.Count ; i++)
			{
				SortList.Add (Indexes [i].Value [0]);
			}//end for loop

			if (Indexes.Count > 1)
			{
				SinkSort (SortList);
			}//End if statement
			return INSERT.SUCCESS;
		}//End Insert (int, Node)

		#endregion Methods

		#region Sort

		/// <summary>
		/// Sinks the sort.
		/// </summary>
		/// <param name="list">The list.</param>
		public void SinkSort (List<int> list)
		{
			bool sorted = false;
			int pass = 0;

			while (!sorted && (pass < Indexes.Count))
			{
				pass++;
				sorted = true;
				for (int i = 0 ; i < Indexes.Count - pass ; i++)
				{
					if (list [i] > list [i + 1])
					{
						Swap (list, i, i + 1);
						sorted = false;
					}//End if statement
				}//End for loop
			}//End while loop
		}//End SinkSort (List<int>)

		/// <summary>
		/// Swaps the specified list.
		/// </summary>
		/// <param name="list">The list.</param>
		/// <param name="i">The i.</param>
		/// <param name="v">The v.</param>
		public void Swap (List<int> list, int i, int v)
		{
			Node temp = Indexes [i];
			Indexes [i] = Indexes [v];
			Indexes [v] = temp;
		}//End Swap (List<int>, int, int)

		#endregion Sort
	}//End Index
}//End Project5