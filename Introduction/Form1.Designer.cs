using System.Windows.Forms;
namespace Introduction
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbShowDate = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnHideControls = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.sysTry = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDateCalculator = new System.Windows.Forms.Button();
            this.sysTry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbShowDate
            // 
            this.cbShowDate.AutoSize = true;
            this.cbShowDate.BackColor = System.Drawing.SystemColors.Control;
            this.cbShowDate.Checked = true;
            this.cbShowDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbShowDate.ForeColor = System.Drawing.Color.Black;
            this.cbShowDate.Location = new System.Drawing.Point(36, 219);
            this.cbShowDate.Name = "cbShowDate";
            this.cbShowDate.Size = new System.Drawing.Size(185, 41);
            this.cbShowDate.TabIndex = 1;
            this.cbShowDate.Text = "Show date";
            this.cbShowDate.UseVisualStyleBackColor = false;
            this.cbShowDate.Visible = false;
            this.cbShowDate.CheckedChanged += new System.EventHandler(this.cbShowDate_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(36, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(262, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHideControls
            // 
            this.btnHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHideControls.Location = new System.Drawing.Point(36, 339);
            this.btnHideControls.Name = "btnHideControls";
            this.btnHideControls.Size = new System.Drawing.Size(262, 46);
            this.btnHideControls.TabIndex = 3;
            this.btnHideControls.Text = "Hide Controls";
            this.btnHideControls.UseVisualStyleBackColor = true;
            this.btnHideControls.Visible = false;
            this.btnHideControls.Click += new System.EventHandler(this.btnHideControls_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.sysTry;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Clock by Fanil";
            this.notifyIcon1.Visible = true;
            // 
            // sysTry
            // 
            this.sysTry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDateToolStripMenuItem,
            this.showControlsToolStripMenuItem,
            this.hideControlsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.sysTry.Name = "contextMenuStrip";
            this.sysTry.Size = new System.Drawing.Size(150, 98);
            // 
            // showDateToolStripMenuItem
            // 
            this.showDateToolStripMenuItem.Checked = true;
            this.showDateToolStripMenuItem.CheckOnClick = true;
            this.showDateToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showDateToolStripMenuItem.Name = "showDateToolStripMenuItem";
            this.showDateToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showDateToolStripMenuItem.Text = "Show date";
            // 
            // showControlsToolStripMenuItem
            // 
            this.showControlsToolStripMenuItem.Name = "showControlsToolStripMenuItem";
            this.showControlsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showControlsToolStripMenuItem.Text = "Show controls";
            // 
            // hideControlsToolStripMenuItem
            // 
            this.hideControlsToolStripMenuItem.Name = "hideControlsToolStripMenuItem";
            this.hideControlsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.hideControlsToolStripMenuItem.Text = "Hide controls";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(440, 141);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Size = new System.Drawing.Size(150, 100);
            this.splitContainer1.TabIndex = 4;
            // 
            // btnDateCalculator
            // 
            this.btnDateCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDateCalculator.Location = new System.Drawing.Point(36, 278);
            this.btnDateCalculator.Name = "btnDateCalculator";
            this.btnDateCalculator.Size = new System.Drawing.Size(262, 43);
            this.btnDateCalculator.TabIndex = 5;
            this.btnDateCalculator.Text = "Date calculator";
            this.btnDateCalculator.UseVisualStyleBackColor = true;
            this.btnDateCalculator.Visible = false;
            this.btnDateCalculator.Click += new System.EventHandler(this.btnDateCalculator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(364, 459);
            this.Controls.Add(this.btnDateCalculator);
            this.Controls.Add(this.btnHideControls);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbShowDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clock";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.timer1_Tick);
            this.sysTry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbShowDate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHideControls;
        private NotifyIcon notifyIcon1;
        private SplitContainer splitContainer1;
        private ContextMenuStrip sysTry;
        private ToolStripMenuItem showDateToolStripMenuItem;
        private ToolStripMenuItem showControlsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem hideControlsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private Button btnDateCalculator;
    }
}

