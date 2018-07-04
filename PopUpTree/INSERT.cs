//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - BTree
//	File Name:		INSERT.cs
//	Description:	Enum for weather add value was successive
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Justin Adams, adamsjl3@etsu.edu, Undergrad CS, East Tennessee State University
//	Created:		Monday, November 10, 2017
//	Copyright:		Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Project5//Done
{
	/// <summary>
	/// The results of add value to b-tree
	/// </summary>
	public enum INSERT
	{
		/// <summary>
		/// The duplicate
		/// </summary>
		DUPLICATE,

		/// <summary>
		/// The success
		/// </summary>
		SUCCESS,

		/// <summary>
		/// The need to split
		/// </summary>
		NEEDSPLIT
	}//End INSERT
}//End Project5