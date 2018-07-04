//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Project 5 - BTree
//	File Name:		MenuForm.Designer.cs
//	Description:	Designer For BTree Program	
//	Course:			CSCI 2210-001 - Data Structures
//	Author:			Justin Adams, adamsjl3@etsu.edu, Undergrad CS, East Tennessee State University
//	Created:		Monday, November 10, 2017
//	Copyright:		Justin Adams, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace PopUpTree
{
	/// <summary>
	/// Designer for MenuForm
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	partial class MenuForm
	{
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
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
			this.StartNumLabel = new System.Windows.Forms.Label();
			this.NodeLabel = new System.Windows.Forms.Label();
			this.RandomLabel = new System.Windows.Forms.Label();
			this.StartTextBox = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.LabelPanel = new System.Windows.Forms.Panel();
			this.TreeButton = new System.Windows.Forms.Button();
			this.RandomCheckBox = new System.Windows.Forms.CheckBox();
			this.ViewLabel = new System.Windows.Forms.Label();
			this.NodeTextBox = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.LabelPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// StartNumLabel
			// 
			this.StartNumLabel.AutoSize = true;
			this.StartNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartNumLabel.Location = new System.Drawing.Point(5, 16);
			this.StartNumLabel.Name = "StartNumLabel";
			this.StartNumLabel.Size = new System.Drawing.Size(161, 24);
			this.StartNumLabel.TabIndex = 0;
			this.StartNumLabel.Text = "Starting Number";
			// 
			// NodeLabel
			// 
			this.NodeLabel.AutoSize = true;
			this.NodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NodeLabel.Location = new System.Drawing.Point(5, 62);
			this.NodeLabel.Name = "NodeLabel";
			this.NodeLabel.Size = new System.Drawing.Size(107, 24);
			this.NodeLabel.TabIndex = 1;
			this.NodeLabel.Text = "Node Size";
			// 
			// RandomLabel
			// 
			this.RandomLabel.AutoSize = true;
			this.RandomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RandomLabel.Location = new System.Drawing.Point(5, 110);
			this.RandomLabel.Name = "RandomLabel";
			this.RandomLabel.Size = new System.Drawing.Size(88, 24);
			this.RandomLabel.TabIndex = 2;
			this.RandomLabel.Text = "Random";
			// 
			// StartTextBox
			// 
			this.StartTextBox.Location = new System.Drawing.Point(206, 16);
			this.StartTextBox.Name = "StartTextBox";
			this.StartTextBox.Size = new System.Drawing.Size(100, 20);
			this.StartTextBox.TabIndex = 3;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.LabelPanel);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(349, 310);
			this.panel1.TabIndex = 4;
			// 
			// LabelPanel
			// 
			this.LabelPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.LabelPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LabelPanel.Controls.Add(this.TreeButton);
			this.LabelPanel.Controls.Add(this.RandomCheckBox);
			this.LabelPanel.Controls.Add(this.ViewLabel);
			this.LabelPanel.Controls.Add(this.StartNumLabel);
			this.LabelPanel.Controls.Add(this.StartTextBox);
			this.LabelPanel.Controls.Add(this.NodeTextBox);
			this.LabelPanel.Controls.Add(this.RandomLabel);
			this.LabelPanel.Controls.Add(this.NodeLabel);
			this.LabelPanel.Location = new System.Drawing.Point(16, 19);
			this.LabelPanel.Name = "LabelPanel";
			this.LabelPanel.Padding = new System.Windows.Forms.Padding(2);
			this.LabelPanel.Size = new System.Drawing.Size(315, 274);
			this.LabelPanel.TabIndex = 5;
			// 
			// TreeButton
			// 
			this.TreeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.TreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TreeButton.Location = new System.Drawing.Point(231, 242);
			this.TreeButton.Name = "TreeButton";
			this.TreeButton.Size = new System.Drawing.Size(75, 23);
			this.TreeButton.TabIndex = 6;
			this.TreeButton.Text = "Tree";
			this.TreeButton.UseVisualStyleBackColor = true;
			this.TreeButton.Click += new System.EventHandler(this.TreeButton_Click);
			// 
			// RandomCheckBox
			// 
			this.RandomCheckBox.AutoSize = true;
			this.RandomCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RandomCheckBox.Location = new System.Drawing.Point(206, 115);
			this.RandomCheckBox.Name = "RandomCheckBox";
			this.RandomCheckBox.Size = new System.Drawing.Size(59, 20);
			this.RandomCheckBox.TabIndex = 9;
			this.RandomCheckBox.Text = "True";
			this.RandomCheckBox.UseVisualStyleBackColor = true;
			// 
			// ViewLabel
			// 
			this.ViewLabel.AutoSize = true;
			this.ViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ViewLabel.Location = new System.Drawing.Point(189, 214);
			this.ViewLabel.Name = "ViewLabel";
			this.ViewLabel.Size = new System.Drawing.Size(117, 25);
			this.ViewLabel.TabIndex = 7;
			this.ViewLabel.Text = "View Tree";
			// 
			// NodeTextBox
			// 
			this.NodeTextBox.Location = new System.Drawing.Point(206, 62);
			this.NodeTextBox.Name = "NodeTextBox";
			this.NodeTextBox.Size = new System.Drawing.Size(100, 20);
			this.NodeTextBox.TabIndex = 4;
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(377, 336);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Project 5 Justin Adams ";
			this.panel1.ResumeLayout(false);
			this.LabelPanel.ResumeLayout(false);
			this.LabelPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		/// <summary>
		/// The start number label
		/// </summary>
		private System.Windows.Forms.Label StartNumLabel;
		/// <summary>
		/// The node label
		/// </summary>
		private System.Windows.Forms.Label NodeLabel;
		/// <summary>
		/// The random label
		/// </summary>
		private System.Windows.Forms.Label RandomLabel;
		/// <summary>
		/// The start text box
		/// </summary>
		private System.Windows.Forms.TextBox StartTextBox;
		/// <summary>
		/// The panel1
		/// </summary>
		private System.Windows.Forms.Panel panel1;
		/// <summary>
		/// The tree button
		/// </summary>
		private System.Windows.Forms.Button TreeButton;
		/// <summary>
		/// The label panel
		/// </summary>
		private System.Windows.Forms.Panel LabelPanel;
		/// <summary>
		/// The node text box
		/// </summary>
		private System.Windows.Forms.TextBox NodeTextBox;
		/// <summary>
		/// The view label
		/// </summary>
		private System.Windows.Forms.Label ViewLabel;
		/// <summary>
		/// The random CheckBox
		/// </summary>
		private System.Windows.Forms.CheckBox RandomCheckBox;
	}//End MenuForm
}//PopUpTree