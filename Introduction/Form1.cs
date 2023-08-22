using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width - this.Width - 10, 10);
            this.showDateToolStripMenuItem.Click += new System.EventHandler(this.itemShowDate_CheckedChanged);
            this.showControlsToolStripMenuItem.Click += new System.EventHandler(this.label1_MouseHover);
            this.hideControlsToolStripMenuItem.Click += new System.EventHandler(this.btnHideControls_Click);
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnClose_Click);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dateTime = DateTime.Now.ToString();
            string[] dt = dateTime.Split(' ');
            label1.Text = dt[1] + "\n";
            if (cbShowDate.Checked)
            {
                label1.Text += dt[0];
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.btnClose.Visible = true;
            this.btnHideControls.Visible = true;
            this.cbShowDate.Visible = true;
            this.btnDateCalculator.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
            this.btnClose.Visible = false;
            this.btnHideControls.Visible = false;
            this.cbShowDate.Visible = false;
            this.btnDateCalculator.Visible = false;
        }

        private void itemShowDate_CheckedChanged(object sender, EventArgs e)
        {
            if (showDateToolStripMenuItem.Checked)
            {
                cbShowDate.Checked = true;
                showDateToolStripMenuItem.Checked = true;
            }
            else
            {
                cbShowDate.Checked = false;
                showDateToolStripMenuItem.Checked = false;
            }
        }

        private void cbShowDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowDate.Checked)
            {
                cbShowDate.Checked = true;
                showDateToolStripMenuItem.Checked = true;
            }
            else
            {
                cbShowDate.Checked = false;
                showDateToolStripMenuItem.Checked = false;
            }
        }

        private void btnDateCalculator_Click(object sender, EventArgs e)
        {
            DateCalculator dc = new DateCalculator();
            dc.ShowDialog(this);
        }
    }
}
