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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.categoryListView = new HMI_Lab3.DragListView();
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.editButton = new System.Windows.Forms.CheckBox();
            this.editButtonImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // categoryListView
            // 
            this.categoryListView.AllowDrop = true;
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.Cost});
            this.categoryListView.HideSelection = false;
            this.categoryListView.HoverSelection = true;
            this.categoryListView.InsertionLineColor = System.Drawing.Color.Black;
            this.categoryListView.Location = new System.Drawing.Point(0, 63);
            this.categoryListView.MultiSelect = false;
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(800, 499);
            this.categoryListView.TabIndex = 0;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.View = System.Windows.Forms.View.Details;
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
            // editButton
            // 
            this.editButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.editButton.BackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editButton.ImageIndex = 1;
            this.editButton.ImageList = this.editButtonImages;
            this.editButton.Location = new System.Drawing.Point(12, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(60, 40);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Edit";
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // editButtonImages
            // 
            this.editButtonImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("editButtonImages.ImageStream")));
            this.editButtonImages.TransparentColor = System.Drawing.Color.Transparent;
            this.editButtonImages.Images.SetKeyName(0, "editPressed.png");
            this.editButtonImages.Images.SetKeyName(1, "edit1.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.editButton);
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
        private CheckBox editButton;
        private ImageList editButtonImages;
    }
}

