//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - BTree
//	File Name:		Leaf.cs
//	Description:	Holder of BTree Leaf Nodes
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
	/// Leaf node of BTree
	/// </summary>
	public class Leaf : Node
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="Leaf"/> class.
		/// </summary>
		public Leaf ( )
		{
			IsLeaf = true;
		}//End Leaf ( )

		 /// <summary>
		 /// Initializes a new instance of the <see cref="Leaf"/> class.
		 /// </summary>
		 /// <param name="nodeSize">Size of the node.</param>
		public Leaf (int nodeSize)
		{
			base.Value = new List<int> (nodeSize);
			this.NodeSize = nodeSize;
			IsLeaf = true;
		}//End Leaf (int)

		#endregion Constructors

		#region Methods

		/// <summary>
		/// Inserts the specified n.
		/// </summary>
		/// <param name="n">The n.</param>
		/// <returns>if value was inserted</returns>
		public override INSERT Insert (int n)
		{
			if (Value.Count == NodeSize - 1)
			{
				return INSERT.NEEDSPLIT;
			}//End if statement
			Value.Add (n);
			Value.Sort ( );
			return INSERT.SUCCESS;
		}//End Insert (int)

		#endregion Methods
	}//End Leaf
}//End Project5	GOOD