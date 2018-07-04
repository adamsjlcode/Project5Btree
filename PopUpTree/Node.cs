//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - BTree
//	File Name:		Node.cs
//	Description:	BTree Node class
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Justin Adams, adamsjl3@etsu.edu, Undergrad CS, East Tennessee State University
//	Created:		Monday, November 10, 2017
//	Copyright:		Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using System.Collections.Generic;

namespace Project5
{
	/// <summary>
	/// Holds BTree information and values
	/// </summary>
	public class Node : IEnumerable
	{
		#region Properties

		/// <summary>
		/// Gets or sets the size of the node.
		/// </summary>
		/// <value>
		/// The size of the node.
		/// </value>
		public int NodeSize { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		public List<int> Value { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is leaf.
		/// </summary>
		/// <value>
		///   <c>true</c> if this instance is leaf; otherwise, <c>false</c>.
		/// </value>
		public bool IsLeaf { get; set; }

		#endregion Properties

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="Node"/> class.
		/// </summary>
		public Node ( )
		{
			Value = new List<int> ( );
		}//End Node

		/// <summary>
		/// Initializes a new instance of the <see cref="Node"/> class.
		/// </summary>
		/// <param name="nodeSize">Size of the node.</param>
		public Node (int nodeSize)
		{
			NodeSize = nodeSize;
			Value = new List<int> (NodeSize);
		}//End Node (int)

		#endregion Constructors

		#region Methods

		/// <summary>
		/// Returns a <see cref="System.String" /> that represents this instance.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String" /> that represents this instance.
		/// </returns>
		public override string ToString ( )
		{
			string displayLeaf = ""; //Display values in the list
			if (Value.Count == Value.Capacity)
			{
				for (int i = 0 ; i < Value.Count ; i++)
				{
					displayLeaf += "| " + Value [i] + " |";
				}//end for loop
			}//End if statement
			else
			{
				//Get number of empty values in List
				int emptyValues = Value.Capacity - Value.Count;
				for (int i = 0 ; i < Value.Capacity - emptyValues ; i++)
				{
					displayLeaf += "| " + Value [i] + " |";
				}//end for loop
				 //Display empty values
				for (int i = 0 ; i < emptyValues ; i++)
				{
					displayLeaf += "| #### |";
				}//end for loop
			}//End else statement
			return displayLeaf;
		}//End ToString ( )

		/// <summary>
		/// Inserts the specified v.
		/// </summary>
		/// <param name="v">The v.</param>
		/// <returns>If insertion was successful</returns>
		public virtual INSERT Insert (int v)
		{
			if (Value.Count == NodeSize - 1)
			{
				return INSERT.NEEDSPLIT;
			}//End if statement
			Value.Add (v);
			Value.Sort ( );
			return INSERT.SUCCESS;
		}//End Insert (int)

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
		/// </returns>
		public IEnumerator GetEnumerator ( )
		{
			return Value.GetEnumerator ( );
		}//End GetEnumerator ( )

		#endregion Methods
	}//End Node
}//End Project5	GOOD