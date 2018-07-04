//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - BTree
//	File Name:		Tree.Designer.cs
//	Description:	Designer for BTree display	
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Justin Adams, adamsjl3@etsu.edu, Undergrad CS, East Tennessee State University
//	Created:		Monday, November 10, 2017
//	Copyright:		Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace PopUpTree
{
	/// <summary>
	/// Tree Display
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	partial class Tree
	{
		#region Windows Form Designer generated code
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ( );
			}
			base.Dispose (disposing);
		}//End Dispose (bool)

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tree));
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.AddButton = new System.Windows.Forms.Button();
			this.Itemlabel = new System.Windows.Forms.Label();
			this.AddTextBox = new System.Windows.Forms.TextBox();
			this.LeafLabel = new System.Windows.Forms.Label();
			this.IndexLabel = new System.Windows.Forms.Label();
			this.OutItemLabel = new System.Windows.Forms.Label();
			this.OutIndexLabel = new System.Windows.Forms.Label();
			this.OutLeafLabel = new System.Windows.Forms.Label();
			this.HeightLabel = new System.Windows.Forms.Label();
			this.OutHeightLabel = new System.Windows.Forms.Label();
			this.FillLabel = new System.Windows.Forms.Label();
			this.OutFillLabel = new System.Windows.Forms.Label();
			this.FindTextBox = new System.Windows.Forms.TextBox();
			this.FindButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeView1.Location = new System.Drawing.Point(13, 23);
			this.treeView1.Name = "treeView1";
			this.treeView1.PathSeparator = "->";
			this.treeView1.Size = new System.Drawing.Size(763, 513);
			this.treeView1.TabIndex = 0;
			// 
			// AddButton
			// 
			this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddButton.Location = new System.Drawing.Point(844, 513);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(75, 23);
			this.AddButton.TabIndex = 1;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = true;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// Itemlabel
			// 
			this.Itemlabel.AutoSize = true;
			this.Itemlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Itemlabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Itemlabel.Location = new System.Drawing.Point(782, 23);
			this.Itemlabel.Name = "Itemlabel";
			this.Itemlabel.Size = new System.Drawing.Size(110, 24);
			this.Itemlabel.TabIndex = 2;
			this.Itemlabel.Text = "Item Count";
			// 
			// AddTextBox
			// 
			this.AddTextBox.Location = new System.Drawing.Point(782, 487);
			this.AddTextBox.Name = "AddTextBox";
			this.AddTextBox.Size = new System.Drawing.Size(190, 20);
			this.AddTextBox.TabIndex = 3;
			// 
			// LeafLabel
			// 
			this.LeafLabel.AutoSize = true;
			this.LeafLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LeafLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.LeafLabel.Location = new System.Drawing.Point(782, 149);
			this.LeafLabel.Name = "LeafLabel";
			this.LeafLabel.Size = new System.Drawing.Size(110, 24);
			this.LeafLabel.TabIndex = 5;
			this.LeafLabel.Text = "Leaf Count";
			// 
			// IndexLabel
			// 
			this.IndexLabel.AutoSize = true;
			this.IndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IndexLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.IndexLabel.Location = new System.Drawing.Point(782, 83);
			this.IndexLabel.Name = "IndexLabel";
			this.IndexLabel.Size = new System.Drawing.Size(123, 24);
			this.IndexLabel.TabIndex = 4;
			this.IndexLabel.Text = "Index Count";
			// 
			// OutItemLabel
			// 
			this.OutItemLabel.AutoSize = true;
			this.OutItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutItemLabel.Location = new System.Drawing.Point(921, 27);
			this.OutItemLabel.Name = "OutItemLabel";
			this.OutItemLabel.Size = new System.Drawing.Size(51, 20);
			this.OutItemLabel.TabIndex = 6;
			this.OutItemLabel.Text = "label1";
			// 
			// OutIndexLabel
			// 
			this.OutIndexLabel.AutoSize = true;
			this.OutIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutIndexLabel.Location = new System.Drawing.Point(921, 87);
			this.OutIndexLabel.Name = "OutIndexLabel";
			this.OutIndexLabel.Size = new System.Drawing.Size(51, 20);
			this.OutIndexLabel.TabIndex = 7;
			this.OutIndexLabel.Text = "label1";
			// 
			// OutLeafLabel
			// 
			this.OutLeafLabel.AutoSize = true;
			this.OutLeafLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutLeafLabel.Location = new System.Drawing.Point(921, 149);
			this.OutLeafLabel.Name = "OutLeafLabel";
			this.OutLeafLabel.Size = new System.Drawing.Size(51, 20);
			this.OutLeafLabel.TabIndex = 8;
			this.OutLeafLabel.Text = "label1";
			// 
			// HeightLabel
			// 
			this.HeightLabel.AutoSize = true;
			this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HeightLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.HeightLabel.Location = new System.Drawing.Point(782, 214);
			this.HeightLabel.Name = "HeightLabel";
			this.HeightLabel.Size = new System.Drawing.Size(71, 24);
			this.HeightLabel.TabIndex = 9;
			this.HeightLabel.Text = "Height";
			// 
			// OutHeightLabel
			// 
			this.OutHeightLabel.AutoSize = true;
			this.OutHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutHeightLabel.Location = new System.Drawing.Point(921, 218);
			this.OutHeightLabel.MaximumSize = new System.Drawing.Size(51, 20);
			this.OutHeightLabel.Name = "OutHeightLabel";
			this.OutHeightLabel.Size = new System.Drawing.Size(0, 20);
			this.OutHeightLabel.TabIndex = 10;
			// 
			// FillLabel
			// 
			this.FillLabel.AutoSize = true;
			this.FillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FillLabel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FillLabel.Location = new System.Drawing.Point(782, 281);
			this.FillLabel.Name = "FillLabel";
			this.FillLabel.Size = new System.Drawing.Size(84, 24);
			this.FillLabel.TabIndex = 11;
			this.FillLabel.Text = "Filled %";
			// 
			// OutFillLabel
			// 
			this.OutFillLabel.AutoSize = true;
			this.OutFillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutFillLabel.Location = new System.Drawing.Point(921, 281);
			this.OutFillLabel.Name = "OutFillLabel";
			this.OutFillLabel.Size = new System.Drawing.Size(51, 20);
			this.OutFillLabel.TabIndex = 12;
			this.OutFillLabel.Text = "label1";
			// 
			// FindTextBox
			// 
			this.FindTextBox.Location = new System.Drawing.Point(782, 432);
			this.FindTextBox.Name = "FindTextBox";
			this.FindTextBox.Size = new System.Drawing.Size(190, 20);
			this.FindTextBox.TabIndex = 13;
			// 
			// FindButton
			// 
			this.FindButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FindButton.Location = new System.Drawing.Point(844, 458);
			this.FindButton.Name = "FindButton";
			this.FindButton.Size = new System.Drawing.Size(75, 23);
			this.FindButton.TabIndex = 14;
			this.FindButton.Text = "Find";
			this.FindButton.UseVisualStyleBackColor = true;
			this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
			// 
			// Tree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(984, 554);
			this.Controls.Add(this.FindButton);
			this.Controls.Add(this.FindTextBox);
			this.Controls.Add(this.OutFillLabel);
			this.Controls.Add(this.FillLabel);
			this.Controls.Add(this.OutHeightLabel);
			this.Controls.Add(this.HeightLabel);
			this.Controls.Add(this.OutLeafLabel);
			this.Controls.Add(this.OutIndexLabel);
			this.Controls.Add(this.OutItemLabel);
			this.Controls.Add(this.LeafLabel);
			this.Controls.Add(this.IndexLabel);
			this.Controls.Add(this.AddTextBox);
			this.Controls.Add(this.Itemlabel);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.treeView1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Tree";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Project 5 Justin Adams";
			this.ResumeLayout(false);
			this.PerformLayout();

		}//End InitializeComponent ( )

		#endregion

		#region Properties
		/// <summary>
		/// The tree view1
		/// </summary>
		private System.Windows.Forms.TreeView treeView1;
		/// <summary>
		/// The add button
		/// </summary>
		private System.Windows.Forms.Button AddButton;
		/// <summary>
		/// The itemlabel
		/// </summary>
		private System.Windows.Forms.Label Itemlabel;
		/// <summary>
		/// The add text box
		/// </summary>
		private System.Windows.Forms.TextBox AddTextBox;
		/// <summary>
		/// The leaf label
		/// </summary>
		private System.Windows.Forms.Label LeafLabel;
		/// <summary>
		/// The index label
		/// </summary>
		private System.Windows.Forms.Label IndexLabel;
		/// <summary>
		/// The out item label
		/// </summary>
		private System.Windows.Forms.Label OutItemLabel;
		/// <summary>
		/// The out index label
		/// </summary>
		private System.Windows.Forms.Label OutIndexLabel;
		/// <summary>
		/// The out leaf label
		/// </summary>
		private System.Windows.Forms.Label OutLeafLabel;
		/// <summary>
		/// The height label
		/// </summary>
		private System.Windows.Forms.Label HeightLabel;
		/// <summary>
		/// The out height label
		/// </summary>
		private System.Windows.Forms.Label OutHeightLabel;
		/// <summary>
		/// The fill label
		/// </summary>
		private System.Windows.Forms.Label FillLabel;
		/// <summary>
		/// The out fill label
		/// </summary>
		private System.Windows.Forms.Label OutFillLabel;
		/// <summary>
		/// The find text box
		/// </summary>
		private System.Windows.Forms.TextBox FindTextBox;
		/// <summary>
		/// The find button
		/// </summary>
		private System.Windows.Forms.Button FindButton; 
		#endregion
	}//End Tree
}//End PopUpTree

