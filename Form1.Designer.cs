namespace Truss_2D
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Taskbar_panel = new System.Windows.Forms.Panel();
            this.New = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Tree_panel = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.Treeview = new System.Windows.Forms.TreeView();
            this.Prop_panel = new System.Windows.Forms.Panel();
            this.Sketch_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Taskbar_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.Tree_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Taskbar_panel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 33;
            this.splitContainer1.TabIndex = 0;
            // 
            // Taskbar_panel
            // 
            this.Taskbar_panel.BackColor = System.Drawing.SystemColors.Control;
            this.Taskbar_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Taskbar_panel.Controls.Add(this.New);
            this.Taskbar_panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Taskbar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Taskbar_panel.Location = new System.Drawing.Point(0, 0);
            this.Taskbar_panel.Name = "Taskbar_panel";
            this.Taskbar_panel.Size = new System.Drawing.Size(800, 33);
            this.Taskbar_panel.TabIndex = 0;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(3, 3);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 0;
            this.New.Text = "New Truss";
            this.New.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Tree_panel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Sketch_panel);
            this.splitContainer2.Size = new System.Drawing.Size(800, 413);
            this.splitContainer2.SplitterDistance = 253;
            this.splitContainer2.TabIndex = 0;
            // 
            // Tree_panel
            // 
            this.Tree_panel.BackColor = System.Drawing.SystemColors.GrayText;
            this.Tree_panel.Controls.Add(this.splitContainer3);
            this.Tree_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tree_panel.Location = new System.Drawing.Point(0, 0);
            this.Tree_panel.Name = "Tree_panel";
            this.Tree_panel.Size = new System.Drawing.Size(253, 413);
            this.Tree_panel.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.Treeview);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.Prop_panel);
            this.splitContainer3.Size = new System.Drawing.Size(253, 413);
            this.splitContainer3.SplitterDistance = 221;
            this.splitContainer3.TabIndex = 0;
            // 
            // Treeview
            // 
            this.Treeview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Treeview.Location = new System.Drawing.Point(0, 0);
            this.Treeview.Name = "Treeview";
            this.Treeview.Size = new System.Drawing.Size(253, 221);
            this.Treeview.TabIndex = 0;
            // 
            // Prop_panel
            // 
            this.Prop_panel.BackColor = System.Drawing.Color.White;
            this.Prop_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Prop_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prop_panel.Location = new System.Drawing.Point(0, 0);
            this.Prop_panel.Name = "Prop_panel";
            this.Prop_panel.Size = new System.Drawing.Size(253, 188);
            this.Prop_panel.TabIndex = 0;
            // 
            // Sketch_panel
            // 
            this.Sketch_panel.BackColor = System.Drawing.Color.White;
            this.Sketch_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sketch_panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Sketch_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sketch_panel.Location = new System.Drawing.Point(0, 0);
            this.Sketch_panel.Name = "Sketch_panel";
            this.Sketch_panel.Size = new System.Drawing.Size(543, 413);
            this.Sketch_panel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Taskbar_panel.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.Tree_panel.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel Taskbar_panel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel Tree_panel;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TreeView Treeview;
        private System.Windows.Forms.Panel Prop_panel;
        private System.Windows.Forms.Panel Sketch_panel;
        private System.Windows.Forms.Button New;
    }
}

