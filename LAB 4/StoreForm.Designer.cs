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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStripDropDown1 = new System.Windows.Forms.ToolStripDropDown();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStripDropDown1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 420);
            this.listBox1.TabIndex = 0;
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
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(217, 43);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(152, 60);
            this.treeView1.TabIndex = 1;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBox1);
            this.Name = "StoreForm";
            this.Text = "StoreForm";
            this.toolStripDropDown1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TreeView treeView1;

        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripDropDown toolStripDropDown1;

        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}