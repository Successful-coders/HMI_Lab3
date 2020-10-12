using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HMI_Lab3
{
    partial class PriceListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriceListForm));
            this.editButtonImages = new System.Windows.Forms.ImageList(this.components);
            this.AddIcon = new System.Windows.Forms.ImageList(this.components);
            this.RemoveIcon = new System.Windows.Forms.ImageList(this.components);
            this.addCategoryPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddButton = new System.Windows.Forms.PictureBox();
            this.addItemPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SignInIcon = new System.Windows.Forms.ImageList(this.components);
            this.signInButton = new System.Windows.Forms.PictureBox();
            this.editButton = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.PictureBox();
            this.signInLabel = new System.Windows.Forms.Label();
            this.noSearchResultLabel = new System.Windows.Forms.Label();
            this.searchBox = new HMI_Lab3.HintTextBox();
            this.hintTextBox3 = new HMI_Lab3.HintTextBox();
            this.hintTextBox1 = new HMI_Lab3.HintTextBox();
            this.hintTextBox2 = new HMI_Lab3.HintTextBox();
            this.categoryNameTextBox = new HMI_Lab3.HintTextBox();
            this.categoryListView = new HMI_Lab3.DragListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addCategoryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).BeginInit();
            this.addItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).BeginInit();
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
            this.addCategoryPanel.Controls.Add(this.categoryNameTextBox);
            this.addCategoryPanel.Controls.Add(this.pictureBox1);
            this.addCategoryPanel.Controls.Add(this.AddButton);
            this.addCategoryPanel.Location = new System.Drawing.Point(12, 452);
            this.addCategoryPanel.Name = "addCategoryPanel";
            this.addCategoryPanel.Size = new System.Drawing.Size(776, 27);
            this.addCategoryPanel.TabIndex = 3;
            this.addCategoryPanel.Visible = false;
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
            // addItemPanel
            // 
            this.addItemPanel.Controls.Add(this.hintTextBox3);
            this.addItemPanel.Controls.Add(this.hintTextBox1);
            this.addItemPanel.Controls.Add(this.hintTextBox2);
            this.addItemPanel.Controls.Add(this.pictureBox3);
            this.addItemPanel.Location = new System.Drawing.Point(12, 378);
            this.addItemPanel.Name = "addItemPanel";
            this.addItemPanel.Size = new System.Drawing.Size(776, 27);
            this.addItemPanel.TabIndex = 5;
            this.addItemPanel.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HMI_Lab3.Properties.Resources.plus;
            this.pictureBox3.InitialImage = global::HMI_Lab3.Properties.Resources.plus;
            this.pictureBox3.Location = new System.Drawing.Point(4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // SignInIcon
            // 
            this.SignInIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("SignInIcon.ImageStream")));
            this.SignInIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.SignInIcon.Images.SetKeyName(0, "signIn.png");
            // 
            // signInButton
            // 
            this.signInButton.Image = global::HMI_Lab3.Properties.Resources.signIn;
            this.signInButton.Location = new System.Drawing.Point(745, 12);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(40, 40);
            this.signInButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.signInButton.TabIndex = 6;
            this.signInButton.TabStop = false;
            this.signInButton.Click += new System.EventHandler(this.SignInButton_Click);
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
            this.editButton.Size = new System.Drawing.Size(131, 40);
            this.editButton.TabIndex = 1;
            this.editButton.Text = "Редактировать";
            this.editButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Visible = false;
            this.editButton.CheckedChanged += new System.EventHandler(this.editButton_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.Image = global::HMI_Lab3.Properties.Resources.search;
            this.searchButton.Location = new System.Drawing.Point(455, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(25, 23);
            this.searchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.searchButton.TabIndex = 8;
            this.searchButton.TabStop = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInLabel.Location = new System.Drawing.Point(691, 24);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(48, 17);
            this.signInLabel.TabIndex = 10;
            this.signInLabel.Text = "Войти";
            this.signInLabel.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // noSearchResultLabel
            // 
            this.noSearchResultLabel.Location = new System.Drawing.Point(12, 95);
            this.noSearchResultLabel.Name = "noSearchResultLabel";
            this.noSearchResultLabel.Size = new System.Drawing.Size(776, 23);
            this.noSearchResultLabel.TabIndex = 11;
            this.noSearchResultLabel.Text = "По вашему запросу ничего не найдено...";
            this.noSearchResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noSearchResultLabel.Visible = false;
            // 
            // searchBox
            // 
            this.searchBox.Cue = "Поиск...";
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(267, 29);
            this.searchBox.MaxLength = 25;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(186, 23);
            this.searchBox.TabIndex = 9;
            this.searchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyUp);
            // 
            // hintTextBox3
            // 
            this.hintTextBox3.Cue = "Ед. изм.";
            this.hintTextBox3.Location = new System.Drawing.Point(682, 4);
            this.hintTextBox3.Name = "hintTextBox3";
            this.hintTextBox3.Size = new System.Drawing.Size(91, 20);
            this.hintTextBox3.TabIndex = 5;
            // 
            // hintTextBox1
            // 
            this.hintTextBox1.Cue = "Имя товара";
            this.hintTextBox1.Location = new System.Drawing.Point(30, 4);
            this.hintTextBox1.Name = "hintTextBox1";
            this.hintTextBox1.Size = new System.Drawing.Size(438, 20);
            this.hintTextBox1.TabIndex = 5;
            this.hintTextBox1.Visible = false;
            // 
            // hintTextBox2
            // 
            this.hintTextBox2.Cue = "Цена";
            this.hintTextBox2.Location = new System.Drawing.Point(481, 4);
            this.hintTextBox2.Name = "hintTextBox2";
            this.hintTextBox2.Size = new System.Drawing.Size(189, 20);
            this.hintTextBox2.TabIndex = 5;
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Cue = "Имя категории";
            this.categoryNameTextBox.Location = new System.Drawing.Point(30, 2);
            this.categoryNameTextBox.MaxLength = 35;
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(313, 20);
            this.categoryNameTextBox.TabIndex = 5;
            this.categoryNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categoryNameTextBox_KeyDown);
            // 
            // categoryListView
            // 
            this.categoryListView.AllowDrop = true;
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Cost,
            this.Unit});
            this.categoryListView.HideSelection = false;
            this.categoryListView.InsertionLineColor = System.Drawing.Color.Black;
            this.categoryListView.Location = new System.Drawing.Point(0, 63);
            this.categoryListView.MultiSelect = false;
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(800, 723);
            this.categoryListView.TabIndex = 0;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.View = System.Windows.Forms.View.Details;
            this.categoryListView.Resize += new System.EventHandler(this.categoryListView_Resize);
            // 
            // ItemName
            // 
            this.ItemName.Tag = "1";
            this.ItemName.Text = "Имя";
            this.ItemName.Width = 490;
            // 
            // Cost
            // 
            this.Cost.Tag = "2";
            this.Cost.Text = "Цена, $";
            this.Cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Cost.Width = 200;
            // 
            // Unit
            // 
            this.Unit.Tag = "3";
            this.Unit.Text = "Ед. изм.";
            this.Unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Unit.Width = 100;
            // 
            // PriceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 784);
            this.Controls.Add(this.noSearchResultLabel);
            this.Controls.Add(this.signInLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.addItemPanel);
            this.Controls.Add(this.addCategoryPanel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.categoryListView);
            this.Name = "PriceListForm";
            this.Text = "Прайс лист стоматологической клиники";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addCategoryPanel.ResumeLayout(false);
            this.addCategoryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddButton)).EndInit();
            this.addItemPanel.ResumeLayout(false);
            this.addItemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signInButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DragListView categoryListView;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Cost;
        private CheckBox editButton;
        private ImageList editButtonImages;
        private ImageList AddIcon;
        private ImageList RemoveIcon;
        private PictureBox AddButton;
        private Panel addCategoryPanel;
        private PictureBox pictureBox1;
        private Panel addItemPanel;
        private PictureBox pictureBox3;
        private HintTextBox hintTextBox2;
        private HintTextBox hintTextBox1;
        private HintTextBox categoryNameTextBox;
        private ImageList SignInIcon;
        private PictureBox signInButton;
        private PictureBox searchButton;
        private HintTextBox searchBox;
        private Label signInLabel;
        private ColumnHeader Unit;
        private HintTextBox hintTextBox3;
        private Label noSearchResultLabel;
    }
}

