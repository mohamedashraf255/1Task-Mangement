using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Mangement
{
    
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            GraphicsPath circlePath = new GraphicsPath();
            circlePath.AddEllipse(0, 0, lblNumNotif.Width, lblNumNotif.Height);
            lblNumNotif.Region = new Region(circlePath);


        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblNumDone_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void lblProject_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_3(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;

            
            this.Close();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            //// 1. هنا إحنا بنمسح الـ Dashboard تماماً من المساحة البيضاء
            //plnMainDashboard.Controls.Clear();
            //pnlSidebar.Controls.Clear();

            //// 2. بنجهز شاشة المشاريع
            Project projects = new Project();
            //projects.TopLevel = false; // بنلغي شريط العنوان بتاعها
            //projects.FormBorderStyle = FormBorderStyle.None;
            //projects.Dock = DockStyle.Fill;

            //// 3. بنعرضها جوه المساحة البيضاء
            //plnMainDashboard.Controls.Add(projects);
            projects.Show();
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalTasks_Click(object sender, EventArgs e)
        {

        }
    
        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }

        private void OpenTaskDetails_Click(object sender, EventArgs e)
        {
            TaskDetails details = new TaskDetails();
            details.Show();
        }

    }
}
