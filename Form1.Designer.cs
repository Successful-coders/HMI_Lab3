using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HMI_Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.categoryListView = new DragListView();
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // categoryListView
            // 
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.Cost});
            this.categoryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryListView.AllowDrop = true;
            this.categoryListView.HideSelection = false;
            this.categoryListView.HoverSelection = true;
            this.categoryListView.Location = new System.Drawing.Point(0, 0);
            this.categoryListView.MultiSelect = false;
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(800, 450);
            this.categoryListView.TabIndex = 0;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.View = System.Windows.Forms.View.Details;
            this.categoryListView.InsertionMark.Color = Color.BlueViolet;
            this.categoryListView.Resize += new System.EventHandler(this.categoryListView_Resize);
            // 
            // Description
            // 
            this.Description.Tag = "1";
            this.Description.Text = "Имя";
            this.Description.Width = 220;
            // 
            // Cost
            // 
            this.Cost.Tag = "2";
            this.Cost.Text = "Цена";
            this.Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cost.Width = 573;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoryListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DragListView categoryListView;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Cost;
    }
}

