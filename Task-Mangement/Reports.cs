using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Mangement
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            Project projects = new Project();
            projects.Show();
            this.Close();
        }

        private void btnWorkFlowBoard_Click(object sender, EventArgs e)
        {
            WorkFlow workFlow = new WorkFlow();
            workFlow.Show();
            this.Close();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void pnlDonutChart_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(25, 15, 170, 170);

            // Donut slices: 50% To do (Gray), 25% In progress (Blue), 25% Done (Green)
            using (Brush bGray = new SolidBrush(Color.FromArgb(148, 163, 184)))
            using (Brush bBlue = new SolidBrush(Color.FromArgb(47, 111, 237)))
            using (Brush bGreen = new SolidBrush(Color.FromArgb(34, 197, 94)))
            {
                e.Graphics.FillPie(bGray, rect, -90, 180);
                e.Graphics.FillPie(bBlue, rect, 90, 90);
                e.Graphics.FillPie(bGreen, rect, 180, 90);
            }

            // Inner hole for donut
            Rectangle holeRect = new Rectangle(55, 45, 110, 110);
            using (Brush bWhite = new SolidBrush(Color.White))
            {
                e.Graphics.FillEllipse(bWhite, holeRect);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
