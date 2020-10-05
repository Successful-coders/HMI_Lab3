using System.Collections.Generic;

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
            this.categoryList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // categoryList
            // 
            this.categoryList.FormattingEnabled = true;
            this.categoryList.Location = new System.Drawing.Point(12, 43);
            this.categoryList.Name = "categoryList";
            this.categoryList.Size = new System.Drawing.Size(776, 277);
            this.categoryList.TabIndex = 0;
            this.categoryList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.categoryList.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.categoryList.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox1_DragOver);
            this.categoryList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.categoryList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox categoryList;
    }
}

