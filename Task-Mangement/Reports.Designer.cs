namespace Task_Mangement
{
    partial class Reports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblNumNotif = new System.Windows.Forms.Label();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnWorkFlowBoard = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.lblTaskify = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.lblReportsSubtitle = new System.Windows.Forms.Label();
            this.lblReportsTitle = new System.Windows.Forms.Label();
            this.pnlCardStatus = new System.Windows.Forms.Panel();
            this.lblLegendDone = new System.Windows.Forms.Label();
            this.lblLegendProgress = new System.Windows.Forms.Label();
            this.lblLegendTodo = new System.Windows.Forms.Label();
            this.lblCardStatusTitle = new System.Windows.Forms.Label();
            this.pnlCardPriority = new System.Windows.Forms.Panel();
            this.lblTagLow = new System.Windows.Forms.Label();
            this.lblTagMed = new System.Windows.Forms.Label();
            this.lblTagHigh = new System.Windows.Forms.Label();
            this.lblTagUrgent = new System.Windows.Forms.Label();
            this.lblValLow = new System.Windows.Forms.Label();
            this.lblValMed = new System.Windows.Forms.Label();
            this.lblValHigh = new System.Windows.Forms.Label();
            this.lblValUrgent = new System.Windows.Forms.Label();
            this.pnlBarLow = new System.Windows.Forms.Panel();
            this.pnlBarMed = new System.Windows.Forms.Panel();
            this.pnlBarHigh = new System.Windows.Forms.Panel();
            this.pnlBarUrgent = new System.Windows.Forms.Panel();
            this.lblCardPriorityTitle = new System.Windows.Forms.Label();
            this.pnlCardCompleted = new System.Windows.Forms.Panel();
            this.lblAhmedCount = new System.Windows.Forms.Label();
            this.pbAhmed = new System.Windows.Forms.ProgressBar();
            this.lblAhmed = new System.Windows.Forms.Label();
            this.lblYousefCount = new System.Windows.Forms.Label();
            this.pbYousef = new System.Windows.Forms.ProgressBar();
            this.lblYousef = new System.Windows.Forms.Label();
            this.lblMonaCount = new System.Windows.Forms.Label();
            this.pbMona = new System.Windows.Forms.ProgressBar();
            this.lblMona = new System.Windows.Forms.Label();
            this.lblSaraCount = new System.Windows.Forms.Label();
            this.pbSara = new System.Windows.Forms.ProgressBar();
            this.lblSara = new System.Windows.Forms.Label();
            this.lblCardCompletedTitle = new System.Windows.Forms.Label();
            this.pnlCardOverdue = new System.Windows.Forms.Panel();
            this.lblOverdueFooter = new System.Windows.Forms.Label();
            this.pnlOverdue2 = new System.Windows.Forms.Panel();
            this.lblOverdue2Date = new System.Windows.Forms.Label();
            this.lblOverdue2User = new System.Windows.Forms.Label();
            this.lblOverdue2Name = new System.Windows.Forms.Label();
            this.pnlOverdue1 = new System.Windows.Forms.Panel();
            this.lblOverdue1Date = new System.Windows.Forms.Label();
            this.lblOverdue1User = new System.Windows.Forms.Label();
            this.lblOverdue1Name = new System.Windows.Forms.Label();
            this.lblCardOverdueTitle = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlCardStatus.SuspendLayout();
            this.pnlCardPriority.SuspendLayout();
            this.pnlCardCompleted.SuspendLayout();
            this.pnlCardOverdue.SuspendLayout();
            this.pnlOverdue2.SuspendLayout();
            this.pnlOverdue1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.lblEmail);
            this.pnlSidebar.Controls.Add(this.lblUserName);
            this.pnlSidebar.Controls.Add(this.btnSignOut);
            this.pnlSidebar.Controls.Add(this.lblNumNotif);
            this.pnlSidebar.Controls.Add(this.btnNotifications);
            this.pnlSidebar.Controls.Add(this.btnReports);
            this.pnlSidebar.Controls.Add(this.btnWorkFlowBoard);
            this.pnlSidebar.Controls.Add(this.btnProjects);
            this.pnlSidebar.Controls.Add(this.lblTaskify);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(256, 753);
            this.pnlSidebar.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(11, 658);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(163, 23);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Yousef@Gmail.com";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(11, 628);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 23);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "El3amed";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(11, 694);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(231, 35);
            this.btnSignOut.TabIndex = 2;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblNumNotif
            // 
            this.lblNumNotif.BackColor = System.Drawing.Color.Red;
            this.lblNumNotif.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblNumNotif.ForeColor = System.Drawing.Color.White;
            this.lblNumNotif.Location = new System.Drawing.Point(211, 246);
            this.lblNumNotif.Name = "lblNumNotif";
            this.lblNumNotif.Size = new System.Drawing.Size(24, 24);
            this.lblNumNotif.TabIndex = 3;
            this.lblNumNotif.Text = "3";
            this.lblNumNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNotifications
            // 
            this.btnNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnNotifications.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNotifications.Location = new System.Drawing.Point(12, 242);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(231, 35);
            this.btnNotifications.TabIndex = 4;
            this.btnNotifications.Text = "●  Notifications";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.btnReports.FlatAppearance.BorderSize = 3;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(12, 201);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(231, 37);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "●  Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnWorkFlowBoard
            // 
            this.btnWorkFlowBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnWorkFlowBoard.FlatAppearance.BorderSize = 0;
            this.btnWorkFlowBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkFlowBoard.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnWorkFlowBoard.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnWorkFlowBoard.Location = new System.Drawing.Point(12, 160);
            this.btnWorkFlowBoard.Name = "btnWorkFlowBoard";
            this.btnWorkFlowBoard.Size = new System.Drawing.Size(231, 35);
            this.btnWorkFlowBoard.TabIndex = 6;
            this.btnWorkFlowBoard.Text = "●  WorkFlow Board";
            this.btnWorkFlowBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkFlowBoard.UseVisualStyleBackColor = false;
            this.btnWorkFlowBoard.Click += new System.EventHandler(this.btnWorkFlowBoard_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnProjects.FlatAppearance.BorderSize = 0;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnProjects.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnProjects.Location = new System.Drawing.Point(12, 119);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(231, 35);
            this.btnProjects.TabIndex = 7;
            this.btnProjects.Text = "●  Projects";
            this.btnProjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjects.UseVisualStyleBackColor = false;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // lblTaskify
            // 
            this.lblTaskify.AutoSize = true;
            this.lblTaskify.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTaskify.ForeColor = System.Drawing.Color.White;
            this.lblTaskify.Location = new System.Drawing.Point(35, 9);
            this.lblTaskify.Name = "lblTaskify";
            this.lblTaskify.Size = new System.Drawing.Size(154, 54);
            this.lblTaskify.TabIndex = 8;
            this.lblTaskify.Text = "Taskify";
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnNavDashboard.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNavDashboard.Location = new System.Drawing.Point(12, 78);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(231, 35);
            this.btnNavDashboard.TabIndex = 9;
            this.btnNavDashboard.Text = "●  Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.pnlHeader.Controls.Add(this.btnExportCsv);
            this.pnlHeader.Controls.Add(this.btnExportExcel);
            this.pnlHeader.Controls.Add(this.btnExportPdf);
            this.pnlHeader.Controls.Add(this.lblReportsSubtitle);
            this.pnlHeader.Controls.Add(this.lblReportsTitle);
            this.pnlHeader.Location = new System.Drawing.Point(280, 15);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1070, 75);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.BackColor = System.Drawing.Color.White;
            this.btnExportCsv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportCsv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnExportCsv.Location = new System.Drawing.Point(950, 18);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(110, 36);
            this.btnExportCsv.TabIndex = 0;
            this.btnExportCsv.Text = "Export CSV";
            this.btnExportCsv.UseVisualStyleBackColor = false;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.BackColor = System.Drawing.Color.White;
            this.btnExportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnExportExcel.Location = new System.Drawing.Point(825, 18);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(115, 36);
            this.btnExportExcel.TabIndex = 1;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.BackColor = System.Drawing.Color.White;
            this.btnExportPdf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.btnExportPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPdf.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnExportPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnExportPdf.Location = new System.Drawing.Point(705, 18);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(110, 36);
            this.btnExportPdf.TabIndex = 2;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.UseVisualStyleBackColor = false;
            // 
            // lblReportsSubtitle
            // 
            this.lblReportsSubtitle.AutoSize = true;
            this.lblReportsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblReportsSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblReportsSubtitle.Location = new System.Drawing.Point(6, 48);
            this.lblReportsSubtitle.Name = "lblReportsSubtitle";
            this.lblReportsSubtitle.Size = new System.Drawing.Size(280, 21);
            this.lblReportsSubtitle.TabIndex = 3;
            this.lblReportsSubtitle.Text = "All projects · 8 tasks · as of Oct 31 2026";
            // 
            // lblReportsTitle
            // 
            this.lblReportsTitle.AutoSize = true;
            this.lblReportsTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblReportsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(37)))), ((int)(((byte)(64)))));
            this.lblReportsTitle.Location = new System.Drawing.Point(3, 0);
            this.lblReportsTitle.Name = "lblReportsTitle";
            this.lblReportsTitle.Size = new System.Drawing.Size(157, 50);
            this.lblReportsTitle.TabIndex = 4;
            this.lblReportsTitle.Text = "Reports";
            // 
            // pnlCardStatus
            // 
            this.pnlCardStatus.BackColor = System.Drawing.Color.White;
            this.pnlCardStatus.Controls.Add(this.lblLegendDone);
            this.pnlCardStatus.Controls.Add(this.lblLegendProgress);
            this.pnlCardStatus.Controls.Add(this.lblLegendTodo);
            this.pnlCardStatus.Controls.Add(this.lblCardStatusTitle);
            this.pnlCardStatus.Controls.Add(this.chart1);
            this.pnlCardStatus.Location = new System.Drawing.Point(280, 105);
            this.pnlCardStatus.Name = "pnlCardStatus";
            this.pnlCardStatus.Size = new System.Drawing.Size(515, 290);
            this.pnlCardStatus.TabIndex = 2;
            // 
            // lblLegendDone
            // 
            this.lblLegendDone.AutoSize = true;
            this.lblLegendDone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLegendDone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblLegendDone.Location = new System.Drawing.Point(8, 235);
            this.lblLegendDone.Name = "lblLegendDone";
            this.lblLegendDone.Size = new System.Drawing.Size(137, 21);
            this.lblLegendDone.TabIndex = 0;
            this.lblLegendDone.Text = "■  Done · 2 (25%)";
            // 
            // lblLegendProgress
            // 
            this.lblLegendProgress.AutoSize = true;
            this.lblLegendProgress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLegendProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(111)))), ((int)(((byte)(237)))));
            this.lblLegendProgress.Location = new System.Drawing.Point(8, 259);
            this.lblLegendProgress.Name = "lblLegendProgress";
            this.lblLegendProgress.Size = new System.Drawing.Size(181, 21);
            this.lblLegendProgress.TabIndex = 1;
            this.lblLegendProgress.Text = "■  In progress · 2 (25%)";
            // 
            // lblLegendTodo
            // 
            this.lblLegendTodo.AutoSize = true;
            this.lblLegendTodo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblLegendTodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblLegendTodo.Location = new System.Drawing.Point(6, 209);
            this.lblLegendTodo.Name = "lblLegendTodo";
            this.lblLegendTodo.Size = new System.Drawing.Size(139, 21);
            this.lblLegendTodo.TabIndex = 2;
            this.lblLegendTodo.Text = "■  To do · 4 (50%)";
            // 
            // lblCardStatusTitle
            // 
            this.lblCardStatusTitle.AutoSize = true;
            this.lblCardStatusTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblCardStatusTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardStatusTitle.Name = "lblCardStatusTitle";
            this.lblCardStatusTitle.Size = new System.Drawing.Size(154, 28);
            this.lblCardStatusTitle.TabIndex = 4;
            this.lblCardStatusTitle.Text = "Tasks by status";
            // 
            // pnlCardPriority
            // 
            this.pnlCardPriority.BackColor = System.Drawing.Color.White;
            this.pnlCardPriority.Controls.Add(this.lblTagLow);
            this.pnlCardPriority.Controls.Add(this.lblTagMed);
            this.pnlCardPriority.Controls.Add(this.lblTagHigh);
            this.pnlCardPriority.Controls.Add(this.lblTagUrgent);
            this.pnlCardPriority.Controls.Add(this.lblValLow);
            this.pnlCardPriority.Controls.Add(this.lblValMed);
            this.pnlCardPriority.Controls.Add(this.lblValHigh);
            this.pnlCardPriority.Controls.Add(this.lblValUrgent);
            this.pnlCardPriority.Controls.Add(this.pnlBarLow);
            this.pnlCardPriority.Controls.Add(this.pnlBarMed);
            this.pnlCardPriority.Controls.Add(this.pnlBarHigh);
            this.pnlCardPriority.Controls.Add(this.pnlBarUrgent);
            this.pnlCardPriority.Controls.Add(this.lblCardPriorityTitle);
            this.pnlCardPriority.Location = new System.Drawing.Point(825, 105);
            this.pnlCardPriority.Name = "pnlCardPriority";
            this.pnlCardPriority.Size = new System.Drawing.Size(525, 290);
            this.pnlCardPriority.TabIndex = 3;
            // 
            // lblTagLow
            // 
            this.lblTagLow.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTagLow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTagLow.Location = new System.Drawing.Point(375, 235);
            this.lblTagLow.Name = "lblTagLow";
            this.lblTagLow.Size = new System.Drawing.Size(70, 25);
            this.lblTagLow.TabIndex = 0;
            this.lblTagLow.Text = "Low";
            this.lblTagLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTagMed
            // 
            this.lblTagMed.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTagMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTagMed.Location = new System.Drawing.Point(270, 235);
            this.lblTagMed.Name = "lblTagMed";
            this.lblTagMed.Size = new System.Drawing.Size(70, 25);
            this.lblTagMed.TabIndex = 1;
            this.lblTagMed.Text = "Medium";
            this.lblTagMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTagHigh
            // 
            this.lblTagHigh.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTagHigh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTagHigh.Location = new System.Drawing.Point(165, 235);
            this.lblTagHigh.Name = "lblTagHigh";
            this.lblTagHigh.Size = new System.Drawing.Size(70, 25);
            this.lblTagHigh.TabIndex = 2;
            this.lblTagHigh.Text = "High";
            this.lblTagHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTagUrgent
            // 
            this.lblTagUrgent.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTagUrgent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblTagUrgent.Location = new System.Drawing.Point(60, 235);
            this.lblTagUrgent.Name = "lblTagUrgent";
            this.lblTagUrgent.Size = new System.Drawing.Size(70, 25);
            this.lblTagUrgent.TabIndex = 3;
            this.lblTagUrgent.Text = "Urgent";
            this.lblTagUrgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValLow
            // 
            this.lblValLow.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValLow.Location = new System.Drawing.Point(385, 145);
            this.lblValLow.Name = "lblValLow";
            this.lblValLow.Size = new System.Drawing.Size(50, 20);
            this.lblValLow.TabIndex = 4;
            this.lblValLow.Text = "1";
            this.lblValLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValMed
            // 
            this.lblValMed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValMed.Location = new System.Drawing.Point(280, 45);
            this.lblValMed.Name = "lblValMed";
            this.lblValMed.Size = new System.Drawing.Size(50, 20);
            this.lblValMed.TabIndex = 5;
            this.lblValMed.Text = "3";
            this.lblValMed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValHigh
            // 
            this.lblValHigh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValHigh.Location = new System.Drawing.Point(175, 45);
            this.lblValHigh.Name = "lblValHigh";
            this.lblValHigh.Size = new System.Drawing.Size(50, 20);
            this.lblValHigh.TabIndex = 6;
            this.lblValHigh.Text = "3";
            this.lblValHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValUrgent
            // 
            this.lblValUrgent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValUrgent.Location = new System.Drawing.Point(70, 145);
            this.lblValUrgent.Name = "lblValUrgent";
            this.lblValUrgent.Size = new System.Drawing.Size(50, 20);
            this.lblValUrgent.TabIndex = 7;
            this.lblValUrgent.Text = "1";
            this.lblValUrgent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBarLow
            // 
            this.pnlBarLow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.pnlBarLow.Location = new System.Drawing.Point(385, 170);
            this.pnlBarLow.Name = "pnlBarLow";
            this.pnlBarLow.Size = new System.Drawing.Size(50, 60);
            this.pnlBarLow.TabIndex = 8;
            // 
            // pnlBarMed
            // 
            this.pnlBarMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(179)))), ((int)(((byte)(8)))));
            this.pnlBarMed.Location = new System.Drawing.Point(280, 70);
            this.pnlBarMed.Name = "pnlBarMed";
            this.pnlBarMed.Size = new System.Drawing.Size(50, 160);
            this.pnlBarMed.TabIndex = 9;
            // 
            // pnlBarHigh
            // 
            this.pnlBarHigh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(115)))), ((int)(((byte)(22)))));
            this.pnlBarHigh.Location = new System.Drawing.Point(175, 70);
            this.pnlBarHigh.Name = "pnlBarHigh";
            this.pnlBarHigh.Size = new System.Drawing.Size(50, 160);
            this.pnlBarHigh.TabIndex = 10;
            // 
            // pnlBarUrgent
            // 
            this.pnlBarUrgent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlBarUrgent.Location = new System.Drawing.Point(70, 170);
            this.pnlBarUrgent.Name = "pnlBarUrgent";
            this.pnlBarUrgent.Size = new System.Drawing.Size(50, 60);
            this.pnlBarUrgent.TabIndex = 11;
            // 
            // lblCardPriorityTitle
            // 
            this.lblCardPriorityTitle.AutoSize = true;
            this.lblCardPriorityTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardPriorityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblCardPriorityTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardPriorityTitle.Name = "lblCardPriorityTitle";
            this.lblCardPriorityTitle.Size = new System.Drawing.Size(168, 28);
            this.lblCardPriorityTitle.TabIndex = 12;
            this.lblCardPriorityTitle.Text = "Tasks by priority";
            // 
            // pnlCardCompleted
            // 
            this.pnlCardCompleted.BackColor = System.Drawing.Color.White;
            this.pnlCardCompleted.Controls.Add(this.lblAhmedCount);
            this.pnlCardCompleted.Controls.Add(this.pbAhmed);
            this.pnlCardCompleted.Controls.Add(this.lblAhmed);
            this.pnlCardCompleted.Controls.Add(this.lblYousefCount);
            this.pnlCardCompleted.Controls.Add(this.pbYousef);
            this.pnlCardCompleted.Controls.Add(this.lblYousef);
            this.pnlCardCompleted.Controls.Add(this.lblMonaCount);
            this.pnlCardCompleted.Controls.Add(this.pbMona);
            this.pnlCardCompleted.Controls.Add(this.lblMona);
            this.pnlCardCompleted.Controls.Add(this.lblSaraCount);
            this.pnlCardCompleted.Controls.Add(this.pbSara);
            this.pnlCardCompleted.Controls.Add(this.lblSara);
            this.pnlCardCompleted.Controls.Add(this.lblCardCompletedTitle);
            this.pnlCardCompleted.Location = new System.Drawing.Point(280, 420);
            this.pnlCardCompleted.Name = "pnlCardCompleted";
            this.pnlCardCompleted.Size = new System.Drawing.Size(515, 280);
            this.pnlCardCompleted.TabIndex = 4;
            // 
            // lblAhmedCount
            // 
            this.lblAhmedCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAhmedCount.Location = new System.Drawing.Point(465, 215);
            this.lblAhmedCount.Name = "lblAhmedCount";
            this.lblAhmedCount.Size = new System.Drawing.Size(30, 25);
            this.lblAhmedCount.TabIndex = 0;
            this.lblAhmedCount.Text = "0";
            // 
            // pbAhmed
            // 
            this.pbAhmed.Location = new System.Drawing.Point(85, 220);
            this.pbAhmed.Name = "pbAhmed";
            this.pbAhmed.Size = new System.Drawing.Size(370, 12);
            this.pbAhmed.TabIndex = 1;
            // 
            // lblAhmed
            // 
            this.lblAhmed.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAhmed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblAhmed.Location = new System.Drawing.Point(15, 215);
            this.lblAhmed.Name = "lblAhmed";
            this.lblAhmed.Size = new System.Drawing.Size(65, 25);
            this.lblAhmed.TabIndex = 2;
            this.lblAhmed.Text = "Ahmed";
            // 
            // lblYousefCount
            // 
            this.lblYousefCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYousefCount.Location = new System.Drawing.Point(465, 165);
            this.lblYousefCount.Name = "lblYousefCount";
            this.lblYousefCount.Size = new System.Drawing.Size(30, 25);
            this.lblYousefCount.TabIndex = 3;
            this.lblYousefCount.Text = "0";
            // 
            // pbYousef
            // 
            this.pbYousef.Location = new System.Drawing.Point(85, 170);
            this.pbYousef.Name = "pbYousef";
            this.pbYousef.Size = new System.Drawing.Size(370, 12);
            this.pbYousef.TabIndex = 4;
            // 
            // lblYousef
            // 
            this.lblYousef.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblYousef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblYousef.Location = new System.Drawing.Point(15, 165);
            this.lblYousef.Name = "lblYousef";
            this.lblYousef.Size = new System.Drawing.Size(65, 25);
            this.lblYousef.TabIndex = 5;
            this.lblYousef.Text = "Yousef";
            // 
            // lblMonaCount
            // 
            this.lblMonaCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonaCount.Location = new System.Drawing.Point(465, 115);
            this.lblMonaCount.Name = "lblMonaCount";
            this.lblMonaCount.Size = new System.Drawing.Size(30, 25);
            this.lblMonaCount.TabIndex = 6;
            this.lblMonaCount.Text = "1";
            // 
            // pbMona
            // 
            this.pbMona.Location = new System.Drawing.Point(85, 120);
            this.pbMona.Name = "pbMona";
            this.pbMona.Size = new System.Drawing.Size(370, 12);
            this.pbMona.TabIndex = 7;
            this.pbMona.Value = 100;
            // 
            // lblMona
            // 
            this.lblMona.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblMona.Location = new System.Drawing.Point(15, 115);
            this.lblMona.Name = "lblMona";
            this.lblMona.Size = new System.Drawing.Size(65, 25);
            this.lblMona.TabIndex = 8;
            this.lblMona.Text = "Mona";
            // 
            // lblSaraCount
            // 
            this.lblSaraCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSaraCount.Location = new System.Drawing.Point(465, 65);
            this.lblSaraCount.Name = "lblSaraCount";
            this.lblSaraCount.Size = new System.Drawing.Size(30, 25);
            this.lblSaraCount.TabIndex = 9;
            this.lblSaraCount.Text = "1";
            // 
            // pbSara
            // 
            this.pbSara.Location = new System.Drawing.Point(85, 70);
            this.pbSara.Name = "pbSara";
            this.pbSara.Size = new System.Drawing.Size(370, 12);
            this.pbSara.TabIndex = 10;
            this.pbSara.Value = 100;
            // 
            // lblSara
            // 
            this.lblSara.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblSara.Location = new System.Drawing.Point(15, 65);
            this.lblSara.Name = "lblSara";
            this.lblSara.Size = new System.Drawing.Size(65, 25);
            this.lblSara.TabIndex = 11;
            this.lblSara.Text = "Sara";
            // 
            // lblCardCompletedTitle
            // 
            this.lblCardCompletedTitle.AutoSize = true;
            this.lblCardCompletedTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardCompletedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblCardCompletedTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardCompletedTitle.Name = "lblCardCompletedTitle";
            this.lblCardCompletedTitle.Size = new System.Drawing.Size(275, 28);
            this.lblCardCompletedTitle.TabIndex = 12;
            this.lblCardCompletedTitle.Text = "Completed tasks per person";
            // 
            // pnlCardOverdue
            // 
            this.pnlCardOverdue.BackColor = System.Drawing.Color.White;
            this.pnlCardOverdue.Controls.Add(this.lblOverdueFooter);
            this.pnlCardOverdue.Controls.Add(this.pnlOverdue2);
            this.pnlCardOverdue.Controls.Add(this.pnlOverdue1);
            this.pnlCardOverdue.Controls.Add(this.lblCardOverdueTitle);
            this.pnlCardOverdue.Location = new System.Drawing.Point(825, 420);
            this.pnlCardOverdue.Name = "pnlCardOverdue";
            this.pnlCardOverdue.Size = new System.Drawing.Size(525, 280);
            this.pnlCardOverdue.TabIndex = 5;
            // 
            // lblOverdueFooter
            // 
            this.lblOverdueFooter.AutoSize = true;
            this.lblOverdueFooter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOverdueFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblOverdueFooter.Location = new System.Drawing.Point(20, 235);
            this.lblOverdueFooter.Name = "lblOverdueFooter";
            this.lblOverdueFooter.Size = new System.Drawing.Size(274, 20);
            this.lblOverdueFooter.TabIndex = 0;
            this.lblOverdueFooter.Text = "2 of 6 open tasks are past their deadline";
            // 
            // pnlOverdue2
            // 
            this.pnlOverdue2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlOverdue2.Controls.Add(this.lblOverdue2Date);
            this.pnlOverdue2.Controls.Add(this.lblOverdue2User);
            this.pnlOverdue2.Controls.Add(this.lblOverdue2Name);
            this.pnlOverdue2.Location = new System.Drawing.Point(20, 120);
            this.pnlOverdue2.Name = "pnlOverdue2";
            this.pnlOverdue2.Size = new System.Drawing.Size(485, 45);
            this.pnlOverdue2.TabIndex = 1;
            // 
            // lblOverdue2Date
            // 
            this.lblOverdue2Date.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblOverdue2Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblOverdue2Date.Location = new System.Drawing.Point(390, 10);
            this.lblOverdue2Date.Name = "lblOverdue2Date";
            this.lblOverdue2Date.Size = new System.Drawing.Size(85, 25);
            this.lblOverdue2Date.TabIndex = 0;
            this.lblOverdue2Date.Text = "Oct 30";
            this.lblOverdue2Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOverdue2User
            // 
            this.lblOverdue2User.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblOverdue2User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblOverdue2User.Location = new System.Drawing.Point(250, 10);
            this.lblOverdue2User.Name = "lblOverdue2User";
            this.lblOverdue2User.Size = new System.Drawing.Size(100, 25);
            this.lblOverdue2User.TabIndex = 1;
            this.lblOverdue2User.Text = "Yousef";
            // 
            // lblOverdue2Name
            // 
            this.lblOverdue2Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblOverdue2Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblOverdue2Name.Location = new System.Drawing.Point(12, 10);
            this.lblOverdue2Name.Name = "lblOverdue2Name";
            this.lblOverdue2Name.Size = new System.Drawing.Size(200, 25);
            this.lblOverdue2Name.TabIndex = 2;
            this.lblOverdue2Name.Text = "Prepare demo scenario";
            // 
            // pnlOverdue1
            // 
            this.pnlOverdue1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlOverdue1.Controls.Add(this.lblOverdue1Date);
            this.pnlOverdue1.Controls.Add(this.lblOverdue1User);
            this.pnlOverdue1.Controls.Add(this.lblOverdue1Name);
            this.pnlOverdue1.Location = new System.Drawing.Point(20, 60);
            this.pnlOverdue1.Name = "pnlOverdue1";
            this.pnlOverdue1.Size = new System.Drawing.Size(485, 45);
            this.pnlOverdue1.TabIndex = 2;
            // 
            // lblOverdue1Date
            // 
            this.lblOverdue1Date.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblOverdue1Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblOverdue1Date.Location = new System.Drawing.Point(390, 10);
            this.lblOverdue1Date.Name = "lblOverdue1Date";
            this.lblOverdue1Date.Size = new System.Drawing.Size(85, 25);
            this.lblOverdue1Date.TabIndex = 0;
            this.lblOverdue1Date.Text = "Oct 29";
            this.lblOverdue1Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOverdue1User
            // 
            this.lblOverdue1User.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblOverdue1User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblOverdue1User.Location = new System.Drawing.Point(250, 10);
            this.lblOverdue1User.Name = "lblOverdue1User";
            this.lblOverdue1User.Size = new System.Drawing.Size(100, 25);
            this.lblOverdue1User.TabIndex = 1;
            this.lblOverdue1User.Text = "Ahmed";
            // 
            // lblOverdue1Name
            // 
            this.lblOverdue1Name.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblOverdue1Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblOverdue1Name.Location = new System.Drawing.Point(12, 10);
            this.lblOverdue1Name.Name = "lblOverdue1Name";
            this.lblOverdue1Name.Size = new System.Drawing.Size(200, 25);
            this.lblOverdue1Name.TabIndex = 2;
            this.lblOverdue1Name.Text = "Create SQL script";
            // 
            // lblCardOverdueTitle
            // 
            this.lblCardOverdueTitle.AutoSize = true;
            this.lblCardOverdueTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCardOverdueTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblCardOverdueTitle.Location = new System.Drawing.Point(15, 15);
            this.lblCardOverdueTitle.Name = "lblCardOverdueTitle";
            this.lblCardOverdueTitle.Size = new System.Drawing.Size(146, 28);
            this.lblCardOverdueTitle.TabIndex = 3;
            this.lblCardOverdueTitle.Text = "Overdue tasks";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.Color = System.Drawing.Color.Silver;
            dataPoint2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataPoint3.Color = System.Drawing.Color.Blue;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(515, 290);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.pnlCardOverdue);
            this.Controls.Add(this.pnlCardCompleted);
            this.Controls.Add(this.pnlCardPriority);
            this.Controls.Add(this.pnlCardStatus);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taskify - Reports";
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCardStatus.ResumeLayout(false);
            this.pnlCardStatus.PerformLayout();
            this.pnlCardPriority.ResumeLayout(false);
            this.pnlCardPriority.PerformLayout();
            this.pnlCardCompleted.ResumeLayout(false);
            this.pnlCardCompleted.PerformLayout();
            this.pnlCardOverdue.ResumeLayout(false);
            this.pnlCardOverdue.PerformLayout();
            this.pnlOverdue2.ResumeLayout(false);
            this.pnlOverdue1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblNumNotif;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnWorkFlowBoard;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Label lblTaskify;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblReportsTitle;
        private System.Windows.Forms.Label lblReportsSubtitle;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Panel pnlCardStatus;
        private System.Windows.Forms.Label lblCardStatusTitle;
        private System.Windows.Forms.Label lblLegendTodo;
        private System.Windows.Forms.Label lblLegendProgress;
        private System.Windows.Forms.Label lblLegendDone;
        private System.Windows.Forms.Panel pnlCardPriority;
        private System.Windows.Forms.Label lblCardPriorityTitle;
        private System.Windows.Forms.Panel pnlBarUrgent;
        private System.Windows.Forms.Panel pnlBarHigh;
        private System.Windows.Forms.Panel pnlBarMed;
        private System.Windows.Forms.Panel pnlBarLow;
        private System.Windows.Forms.Label lblValUrgent;
        private System.Windows.Forms.Label lblValHigh;
        private System.Windows.Forms.Label lblValMed;
        private System.Windows.Forms.Label lblValLow;
        private System.Windows.Forms.Label lblTagUrgent;
        private System.Windows.Forms.Label lblTagHigh;
        private System.Windows.Forms.Label lblTagMed;
        private System.Windows.Forms.Label lblTagLow;
        private System.Windows.Forms.Panel pnlCardCompleted;
        private System.Windows.Forms.Label lblCardCompletedTitle;
        private System.Windows.Forms.Label lblSara;
        private System.Windows.Forms.ProgressBar pbSara;
        private System.Windows.Forms.Label lblSaraCount;
        private System.Windows.Forms.Label lblMona;
        private System.Windows.Forms.ProgressBar pbMona;
        private System.Windows.Forms.Label lblMonaCount;
        private System.Windows.Forms.Label lblYousef;
        private System.Windows.Forms.ProgressBar pbYousef;
        private System.Windows.Forms.Label lblYousefCount;
        private System.Windows.Forms.Label lblAhmed;
        private System.Windows.Forms.ProgressBar pbAhmed;
        private System.Windows.Forms.Label lblAhmedCount;
        private System.Windows.Forms.Panel pnlCardOverdue;
        private System.Windows.Forms.Label lblCardOverdueTitle;
        private System.Windows.Forms.Panel pnlOverdue1;
        private System.Windows.Forms.Label lblOverdue1Name;
        private System.Windows.Forms.Label lblOverdue1User;
        private System.Windows.Forms.Label lblOverdue1Date;
        private System.Windows.Forms.Panel pnlOverdue2;
        private System.Windows.Forms.Label lblOverdue2Name;
        private System.Windows.Forms.Label lblOverdue2User;
        private System.Windows.Forms.Label lblOverdue2Date;
        private System.Windows.Forms.Label lblOverdueFooter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
