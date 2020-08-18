namespace Croco
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuOnOf = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOnOf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CrocoTime On/Of";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuOnOf,
            this.toolStripSeparator1,
            this.toolStripMenuExit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(167, 54);
            // 
            // toolStripMenuOnOf
            // 
            this.toolStripMenuOnOf.Name = "toolStripMenuOnOf";
            this.toolStripMenuOnOf.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuOnOf.Text = "Enabled/Disabled";
            this.toolStripMenuOnOf.Click += new System.EventHandler(this.toolStripMenuOnOf_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuExit.Text = "Exit";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // btnOnOf
            // 
            this.btnOnOf.Location = new System.Drawing.Point(12, 96);
            this.btnOnOf.Name = "btnOnOf";
            this.btnOnOf.Size = new System.Drawing.Size(215, 23);
            this.btnOnOf.TabIndex = 1;
            this.btnOnOf.Text = "Enable";
            this.btnOnOf.UseVisualStyleBackColor = true;
            this.btnOnOf.Click += new System.EventHandler(this.btnOnOf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOnOf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(260, 170);
            this.MinimumSize = new System.Drawing.Size(260, 170);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrocoTime On/Of";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.Button btnOnOf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuOnOf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

