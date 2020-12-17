using System.ComponentModel;

namespace LAB_4
{
    partial class StoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.storeItems = new System.Windows.Forms.ListBox();
            this.toolStripDropDown1 = new System.Windows.Forms.ToolStripDropDown();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.selectedItems = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectedItemsInfo = new System.Windows.Forms.TextBox();
            this.toolStripDropDown1.SuspendLayout();
            this.SuspendLayout();
            // 
            // storeItems
            // 
            this.storeItems.FormattingEnabled = true;
            this.storeItems.Location = new System.Drawing.Point(12, 12);
            this.storeItems.Name = "storeItems";
            this.storeItems.Size = new System.Drawing.Size(200, 420);
            this.storeItems.TabIndex = 0;
            this.storeItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.storeItems_MouseDown);
            // 
            // toolStripDropDown1
            // 
            this.toolStripDropDown1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripButton1, this.toolStripButton2, this.toolStripButton3});
            this.toolStripDropDown1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripDropDown1.Name = "toolStripDropDown1";
            this.toolStripDropDown1.Size = new System.Drawing.Size(43, 70);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 19);
            this.toolStripButton1.Text = "111";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(41, 19);
            this.toolStripButton2.Text = "11111";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(35, 19);
            this.toolStripButton3.Text = "1111";
            // 
            // selectedItems
            // 
            this.selectedItems.AllowDrop = true;
            this.selectedItems.FormattingEnabled = true;
            this.selectedItems.HorizontalScrollbar = true;
            this.selectedItems.Location = new System.Drawing.Point(218, 12);
            this.selectedItems.Name = "selectedItems";
            this.selectedItems.Size = new System.Drawing.Size(209, 368);
            this.selectedItems.TabIndex = 1;
            this.selectedItems.DragDrop += new System.Windows.Forms.DragEventHandler(this.selectedItems_DragDrop);
            this.selectedItems.DragOver += new System.Windows.Forms.DragEventHandler(this.selectedItems_DragOver);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = " Delete selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = " Delete all";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectedItemsInfo
            // 
            this.selectedItemsInfo.BackColor = System.Drawing.SystemColors.Menu;
            this.selectedItemsInfo.Location = new System.Drawing.Point(433, 12);
            this.selectedItemsInfo.Multiline = true;
            this.selectedItemsInfo.Name = "selectedItemsInfo";
            this.selectedItemsInfo.Size = new System.Drawing.Size(332, 307);
            this.selectedItemsInfo.TabIndex = 4;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectedItemsInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectedItems);
            this.Controls.Add(this.storeItems);
            this.Name = "StoreForm";
            this.Text = "StoreForm";
            this.toolStripDropDown1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox selectedItemsInfo;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ListBox selectedItems;

        private System.Windows.Forms.ListBox storeItems;

        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDown toolStripDropDown1;

        #endregion
    }
}