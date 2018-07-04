//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - BTree
//	File Name:		BTree.cs
//	Description:	Integer Binary Tree
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Justin Adams, adamsjl3@etsu.edu, Undergrad CS, East Tennessee State University
//	Created:		Monday, November 10, 2017
//	Copyright:		Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;

namespace Project5
{
	/// <summary>
	/// Holds Nodes in a balanced binary tree
	/// </summary>
	public class BTree
	{
		#region Properties

		/// <summary>
		/// Gets or sets the count.
		/// </summary>
		/// <value>
		/// The count.
		/// </value>
		public int Count { get; set; }

		/// <summary>
		/// Gets or sets the index count.
		/// </summary>
		/// <value>
		/// The index count.
		/// </value>
		public int IndexCount { get; set; }

		/// <summary>
		/// Gets or sets the left count.
		/// </summary>
		/// <value>
		/// The left count.
		/// </value>
		public int LeafCount { get; set; }

		/// <summary>
		/// Gets or sets the size of the node.
		/// </summary>
		/// <value>
		/// The size of the node.
		/// </value>
		public int NodeSize { get; set; }

		/// <summary>
		/// Gets or sets the root.
		/// </summary>
		/// <value>
		/// The root.
		/// </value>
		public Node Root { get; set; }

		/// <summary>
		/// The stack
		/// </summary>
		private Stack<Node> stack = new Stack<Node> ( );

		/// <summary>
		/// The print out
		/// </summary>
		private List<string> PrintOut;

		/// <summary>
		/// The stack trace
		/// </summary>
		private bool trace = false;

		#endregion Properties

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="BTree"/> class.
		/// </summary>
		/// <param name="airity">The airily.</param>
		public BTree (int airily)
		{
			NodeSize = airily;
			Root = null;
			stack.Push (Root);
			Root = new Leaf (airily);
			LeafCount++;
			stack.Push (Root);
		}//End BTree (int)

		#endregion Constructors

		#region Methods

		/// <summary>
		/// Adds the value.
		/// </summary>
		/// <param name="nValueToAdd">The n value to add.</param>
		/// <returns>If value was successfully added</returns>
		public bool AddValue (int nValueToAdd)
		{
			if (FindValue (nValueToAdd))
			{
				return false;
			}//End if statement
			 //Used for the start of the program when root is a leaf
			if (Root.IsLeaf)
			{
				Root = (Leaf) stack.Pop ( );
				INSERT temp = Root.Insert (nValueToAdd);
				switch (temp)
				{
					case INSERT.NEEDSPLIT:
						Leaf tempLeaf = (Leaf) Root;
						Root = new Index (NodeSize);
						SplitLeaf (tempLeaf, nValueToAdd);
						stack.Push (Root);
						IndexCount++;
						Index tempIndex = (Index) Root;
						break;

					case INSERT.SUCCESS:
						stack.Push (Root);
						break;

					default:
						break;
				}//End switch statement
			}//End if statement	TEST
			else
			{
				Leaf addLeaf = FindLeaf (nValueToAdd);
				INSERT temp = addLeaf.Insert (nValueToAdd);
				switch (temp)
				{
					case INSERT.NEEDSPLIT:
						;
						SplitLeaf (addLeaf, nValueToAdd);
						break;

					case INSERT.SUCCESS:
						break;

					default:
						break;
				}//End switch statement
			}//End else statement TEST
			if (!Root.IsLeaf || trace)
			{
				ReturnToTop ( );
			}//End if statement
			Count++;
			return true;
		}//End AddValue (int)

		 /// <summary>
		 /// Displays this instance.
		 /// </summary>
		public List<string> Display ( )
		{
			PrintOut = new List<string> (Count);
			Display (Root, 0);
			//int windowWidth = Console.WindowWidth;
			//double adjustment = 1;
			//for (int i = 0 ; i < PrintOut.Count ; i++)
			//{
			//	windowWidth	= Console.WindowWidth - ((PrintOut [i].Length) /2);
			//	adjustment /= 2;
			//	Console.SetCursorPosition ((int) (windowWidth * adjustment), Console.CursorTop);
			//	Console.WriteLine (PrintOut [i]);
			//}//end for loop
			return PrintOut;
		}//End Display ( ) Format Output

		 /// <summary>
		 /// Displays the specified node.
		 /// </summary>
		 /// <param name="node">The node.</param>
		 /// <param name="nLevel">The nth  level.</param>
		public void Display (Node node, int nLevel)
		{
			Index indexNode = new Index (NodeSize);
			String Level = "";
			if (!node.IsLeaf)
			{
				indexNode = node as Index;
				try
				{
					Level = PrintOut [nLevel];
					PrintOut.RemoveAt (nLevel);
				}
				catch (Exception)
				{
				}
				Level += indexNode.ToString ( ) + "@";
				PrintOut.Insert (nLevel, Level);
				foreach (Node n in indexNode.Indexes)
				{
					Display (n, nLevel + 1);
				}
			}//End if statement
			else
			{
				try
				{
					Level = PrintOut [nLevel];
					PrintOut.RemoveAt (nLevel);
				}
				catch (Exception)
				{
				}
				Level += node.ToString ( ) + "@";
				PrintOut.Insert (nLevel, Level);
			}//End else statement
		}//End Display (Node, int) Good

		 /// <summary>
		 /// Finds the leaf.
		 /// </summary>
		 /// <returns>Indexed Leaf</returns>
		public Leaf FindLeaf (int nValueToFind)
		{
			Leaf returnLeaf;
			if (!Root.IsLeaf && Root != null)
			{
				Index TopValue = (Index) Root;
				stack.Push (Root);
				for (int i = 0 ; i < TopValue.Value.Count ; i++)
				{
					if (nValueToFind <= TopValue.Value [i])
					{
						stack.Push (TopValue.Indexes [i]);
						Root = TopValue.Indexes [i];
						return FindLeaf (nValueToFind);
					}//End if statement
					else if (i == TopValue.Value.Count - 1)
					{
						stack.Push (TopValue.Indexes [i + 1]);
						Root = TopValue.Indexes [i + 1];
						return FindLeaf (nValueToFind);
					}//End if statement
				}//end for loop
			}//End if statement
			returnLeaf = (Leaf) Root;
			//Remove leaf from stack
			stack.Pop ( );
			//Set Root to leaf Parent
			Root = stack.Pop ( );
			return returnLeaf;
		}//End FindLeaf ( )

		 /// <summary>
		 /// Finds the value.
		 /// </summary>
		 /// <param name="nValue">The n value.</param>
		 /// <returns>
		 /// If value is present in BTree
		 /// </returns>
		public bool FindValue (int nValue)
		{
			bool found = false;
			Leaf leafRange = new Leaf (NodeSize);
			if (!Root.IsLeaf)
			{
				leafRange = FindLeaf (nValue);
			}//End if statement
			else
			{
				leafRange = (Leaf) Root;
			}//End else statement
			for (int i = 0 ; i < leafRange.Value.Count ; i++)
			{
				if (leafRange.Value [i] == nValue) found = true;
			}//end for loop
			return found;
		}//End FindValue (int)

		 /// <summary>
		 /// Splits the index.
		 /// </summary>
		 /// <param name="nodeToBeSplit">The node to be split.</param>
		 /// <param name="nodeToBeAddes">The node to be addes.</param>
		 /// <param name="valueToBeAdded">The value to be added.</param>
		public void SplitIndex (Index nodeToBeSplit, Node nodeToBeAddes, int valueToBeAdded)
		{
			#region Variables

			Index rootIndex = new Index (NodeSize);
			Index addIndex = new Index (NodeSize);
			try
			{
				addIndex = (Index) nodeToBeAddes;
			}
			catch (Exception e)
			{
				Console.WriteLine (e.Message);
			}
			int Size = (nodeToBeSplit.Indexes.Count + addIndex.Indexes.Count);
			List<int> values = new List<int> (Size);
			List<Node> indexes = new List<Node> (NodeSize + 1);
			Index IndexLess = new Index (NodeSize);
			Index IndexMore = new Index (NodeSize);
			double half = (double) (NodeSize) / 2.0;
			int postion = (int) Math.Ceiling (half) - 1;
			int numberofSplit;

			#endregion Variables

			#region Inner Methods

			/// <summary>
			/// Splits the index.
			/// </summary>
			/// <param name="size">The size.</param>
			/// <param name="list">The list.</param>
			/// <returns>List of values</returns>
			List<int> getValues (int size, List<int> list)
			{
				List<int> pulled = new List<int> (size);
				for (int i = 0 ; i < size - 1 ; i++)
				{
					pulled.Add (list [i]);
				}//end for loop
				return pulled;
			}
			/// <summary>
			/// Gets the indexes.
			/// </summary>
			/// <param name="size">The size.</param>
			/// <param name="list">The list.</param>
			/// <param name="listTwo">The list two.</param>
			/// <returns>List of indexes</returns>
			List<Node> getIndexes (int size, List<Node> list, List<Node> listTwo)
			{
				List<Node> pulled = new List<Node> (size);
				for (int i = 0 ; i < list.Count ; i++)
				{
					pulled.Add (list [i]);
					if (list [i].Value.Count > 1)
					{
					}//End if statement
				}//end for loop
				for (int i = 0 ; i < listTwo.Count ; i++)
				{
					pulled.Add (listTwo [i]);
				}//end for loop

				return pulled;
			}

			#region Sort

			/// <summary>
			/// Sinks the sort.
			/// </summary>
			/// <param name="list">The list.</param>
			void Sort ( )
			{
				List<int> indexValues = new List<int> ( );
				for (int i = 0 ; i < indexes.Count ; i++)
				{
					indexValues.Add (indexes [i].Value [0]);
				}//end for loop
				bool sorted = false;
				int pass = 0;

				while (!sorted && (pass < indexValues.Count))
				{
					//if (sorted)
					//{
					//	indexValues.Clear ( );
					//	for (int i = 0 ; i < indexes.Count ; i++)
					//	{
					//		indexValues.Add (indexes [i].Value [0]);
					//	}//end for loop
					//}//End if statement
					pass++;
					sorted = true;
					for (int i = 0 ; i < indexValues.Count - pass ; i++)
					{
						if (indexValues [i] > indexValues [i + 1])
						{
							Swap (indexValues, i, i + 1);
							sorted = false;
						}//End if statement
					}//End for loop
				}//End while loop
			}//End Sort (List<int>)
			 /// <summary>
			 /// Swaps the specified list.
			 /// </summary>
			 /// <param name="list">The list.</param>
			 /// <param name="i">The i.</param>
			 /// <param name="v">The v.</param>
			void Swap (List<int> list, int i, int v)
			{
				Node temp = indexes [i];
				int listTemp = list [i];
				indexes [i] = indexes [v];
				list [i] = list [v];
				indexes [v] = temp;
				list [v] = listTemp;
			}//End Swap (List<int>, int, int)

			#endregion Sort

			#endregion Inner Methods

			values = getValues (NodeSize, nodeToBeSplit.Value);
			values.Add (valueToBeAdded);
			values.Sort ( );
			numberofSplit = values [(int) half];
			indexes.AddRange (nodeToBeSplit.Indexes);
			indexes.AddRange (addIndex.Indexes);
			Sort ( );
			for (int i = 0 ; i < (int) Math.Ceiling (half) - 1 ; i++)
			{
				IndexLess.Insert (values [i]);
			}//end for loop
			for (int i = (int) Math.Ceiling (half) ; i < NodeSize ; i++)
			{
				IndexMore.Insert (values [i]);
			}//end for loop
			for (int i = 0 ; i < (int) Math.Ceiling (half) ; i++)
			{
				IndexLess.Insert (indexes [i]);
			}//end for loop
			for (int i = (int) Math.Ceiling (half) ; i < NodeSize + 1 ; i++)
			{
				IndexMore.Insert (indexes [i]);
			}//end for loop
			if (stack.Peek ( ) != null)
			{
				addIndex.Indexes.Clear ( );
				stack.Pop ( );
				rootIndex = (Index) stack.Pop ( );
				postion = rootIndex.Indexes.IndexOf (nodeToBeSplit);
				rootIndex.Indexes.RemoveAt (postion);
				INSERT results = rootIndex.Insert (numberofSplit);
				if (results == INSERT.NEEDSPLIT)
				{
					addIndex.Insert (IndexLess);
					addIndex.Insert (IndexMore);
					SplitIndex (rootIndex, addIndex, numberofSplit);
				}//End if statement
				else
				{
					rootIndex.Insert (IndexLess);
					rootIndex.Insert (IndexMore);
					Root = rootIndex;
				}//End else statement
			}//End if statement
			else
			{
				rootIndex.Insert (numberofSplit);
				rootIndex.Insert (IndexLess);
				rootIndex.Insert (IndexMore);
				Root = rootIndex;
				IndexCount++;
			}//End else statement
			IndexCount++;
		}//End SplitIndex (Index, Node, int)

		 /// <summary>
		 /// Splits the leaf.
		 /// </summary>
		 /// <param name="leaf">The leaf.</param>
		 /// <param name="nInsertedValue">The n inserted value.</param>
		public void SplitLeaf (Leaf leaf, int nInsertedValue)
		{
			Index newRoot = (Index) Root;
			Leaf leafLess = new Leaf (NodeSize);
			Leaf leafMore = new Leaf (NodeSize);
			List<int> values = new List<int> (NodeSize);
			double half = (double) (NodeSize) / 2.0;
			int postion = (int) Math.Ceiling (half) - 1;
			int numberofSplit;
			for (int i = 0 ; i < NodeSize - 1 ; i++)
			{
				values.Add (leaf.Value [i]);
			}//end for loop
			values.Add (nInsertedValue);
			values.Sort ( );
			numberofSplit = values [(int) half];
			for (int i = 0 ; i < (int) Math.Ceiling (half) - 1 ; i++)
			{
				leafLess.Insert (values [i]);
			}//end for loop
			for (int i = (int) Math.Ceiling (half) ; i < NodeSize ; i++)
			{
				leafMore.Insert (values [i]);
			}//end for loop
			INSERT results = newRoot.Insert (numberofSplit);
			if (IndexCount > 0)
			{
				int pos = newRoot.Indexes.IndexOf (leaf);
				newRoot.Indexes.RemoveAt (pos);
			}//End if statement
			if (results == INSERT.NEEDSPLIT)
			{
				Index OverPacked = new Index (NodeSize);
				OverPacked.Insert (leafLess);
				OverPacked.Insert (leafMore);
				SplitIndex (newRoot, OverPacked, values [(int) half]);
			}//End if statement
			else
			{
				newRoot.Insert (leafLess);
				newRoot.Insert (leafMore);
			}//End else statement
			LeafCount++;
		}//End SplitLeaf (Leaf, int)

		 /// <summary>
		 /// Returns to top.
		 /// </summary>
		public void ReturnToTop ( )
		{
			while (stack.Peek ( ) != null)
			{
				Root = stack.Pop ( );
			}//End while loop
		}//End ReturnToTop ( )

		#endregion Methods
	}//End BTree
}//End Project5