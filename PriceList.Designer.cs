﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HMI_Lab3
{
    partial class PriceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceList));
            this.editButtonImages = new System.Windows.Forms.ImageList(this.components);
            this.AddIcon = new System.Windows.Forms.ImageList(this.components);
            this.RemoveIcon = new System.Windows.Forms.ImageList(this.components);
            this.addCategoryPanel = new System.Windows.Forms.Panel();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.categoryListView = new HMI_Lab3.DragListView();
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addItemPanel = new System.Windows.Forms.Panel();
            this.addNewItemLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.PictureBox();
            this.editButton = new System.Windows.Forms.CheckBox();
            this.addCategoryPanel.SuspendLayout();
            this.addItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).BeginInit();
            this.SuspendLayout();
            // 
            // editButtonImages
            // 
            this.editButtonImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("editButtonImages.ImageStream")));
            this.editButtonImages.TransparentColor = System.Drawing.Color.Transparent;
            this.editButtonImages.Images.SetKeyName(0, "editPressed.png");
            this.editButtonImages.Images.SetKeyName(1, "edit1.png");
            // 
            // AddIcon
            // 
            this.AddIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("AddIcon.ImageStream")));
            this.AddIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.AddIcon.Images.SetKeyName(0, "plus.png");
            // 
            // RemoveIcon
            // 
            this.RemoveIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("RemoveIcon.ImageStream")));
            this.RemoveIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.RemoveIcon.Images.SetKeyName(0, "cancel.png");
            // 
            // addCategoryPanel
            // 
            this.addCategoryPanel.Controls.Add(this.pictureBox1);
            this.addCategoryPanel.Controls.Add(this.categoryNameTextBox);
            this.addCategoryPanel.Controls.Add(this.AddButton);
            this.addCategoryPanel.Location = new System.Drawing.Point(12, 452);
            this.addCategoryPanel.Name = "addCategoryPanel";
            this.addCategoryPanel.Size = new System.Drawing.Size(776, 27);
            this.addCategoryPanel.TabIndex = 3;
            this.addCategoryPanel.Visible = false;
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(30, 3);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(313, 20);
            this.categoryNameTextBox.TabIndex = 3;
            this.categoryNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categoryNameTextBox_KeyDown);
            // 
            // categoryListView
            // 
            this.categoryListView.AllowDrop = true;
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.Cost});
            this.categoryListView.HideSelection = false;
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
            // addItemPanel
            // 
            this.addItemPanel.BackColor = System.Drawing.Color.SeaGreen;
            this.addItemPanel.Controls.Add(this.addNewItemLabel);
            this.addItemPanel.Controls.Add(this.pictureBox3);
            this.addItemPanel.Location = new System.Drawing.Point(12, 397);
            this.addItemPanel.Name = "addItemPanel";
            this.addItemPanel.Size = new System.Drawing.Size(776, 27);
            this.addItemPanel.TabIndex = 5;
            this.addItemPanel.Visible = false;
            this.addItemPanel.Click += new System.EventHandler(this.addItemPanel_Click);
            // 
            // addNewItemLabel
            // 
            this.addNewItemLabel.AutoSize = true;
            this.addNewItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewItemLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.addNewItemLabel.Location = new System.Drawing.Point(30, 6);
            this.addNewItemLabel.Name = "addNewItemLabel";
            this.addNewItemLabel.Size = new System.Drawing.Size(159, 17);
            this.addNewItemLabel.TabIndex = 3;
            this.addNewItemLabel.Text = "Добавить новый товар";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HMI_Lab3.Properties.Resources.plusWhite;
            this.pictureBox3.InitialImage = global::HMI_Lab3.Properties.Resources.plus;
            this.pictureBox3.Location = new System.Drawing.Point(4, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(350, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 1);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.Image = global::HMI_Lab3.Properties.Resources.plus;
            this.AddButton.InitialImage = global::HMI_Lab3.Properties.Resources.plus;
            this.AddButton.Location = new System.Drawing.Point(4, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(20, 20);
            this.AddButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddButton.TabIndex = 2;
            this.AddButton.TabStop = false;
            this.AddButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
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
            this.editButton.CheckedChanged += new System.EventHandler(this.editButton_CheckedChanged);
            // 
            // PriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.addItemPanel);
            this.Controls.Add(this.addCategoryPanel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.categoryListView);
            this.Name = "PriceList";
            this.Text = "Dentistry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addCategoryPanel.ResumeLayout(false);
            this.addCategoryPanel.PerformLayout();
            this.addItemPanel.ResumeLayout(false);
            this.addItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DragListView categoryListView;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Cost;
        private CheckBox editButton;
        private ImageList editButtonImages;
        private ImageList AddIcon;
        private ImageList RemoveIcon;
        private PictureBox AddButton;
        private Panel addCategoryPanel;
        private PictureBox pictureBox1;
        private TextBox categoryNameTextBox;
        private Panel addItemPanel;
        private Label addNewItemLabel;
        private PictureBox pictureBox3;
    }
}
