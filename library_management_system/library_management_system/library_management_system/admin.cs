using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace library_management_system
{
    public partial class admin : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public admin()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            panelNav.Height = button1.Height;
            panelNav.Top = button1.Top;
            panelNav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelNav.Height = button1.Height;
            panelNav.Top = button1.Top;
            panelNav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelNav.Height = button2.Height;
            panelNav.Top = button2.Top;
            panelNav.Left = button2.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelNav.Height = button3.Height;
            panelNav.Top = button3.Top;
            panelNav.Left = button3.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelNav.Height = button4.Height;
            panelNav.Top = button4.Top;
            panelNav.Left = button4.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelNav.Height = button5.Height;
            panelNav.Top = button5.Top;
            panelNav.Left = button5.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void admin_Load(object sender, EventArgs e)
        {

        }
    }
}
