﻿namespace Helpdesk
{
    partial class TechnicienForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicienForm));
            panel1 = new Panel();
            panel8 = new Panel();
            btnlogout = new Button();
            panel6 = new Panel();
            HistoryButton = new Button();
            panel2 = new Panel();
            dashboardButton = new Button();
            panel5 = new Panel();
            ticketsButton = new Button();
            panel3 = new Panel();
            employeButton = new Button();
            mainpanel_tech = new Panel();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 74, 173);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(-5, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(232, 604);
            panel1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 74, 173);
            panel8.Controls.Add(btnlogout);
            panel8.Location = new Point(4, 542);
            panel8.Name = "panel8";
            panel8.Size = new Size(234, 45);
            panel8.TabIndex = 9;
            // 
            // btnlogout
            // 
            btnlogout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnlogout.BackColor = Color.FromArgb(0, 74, 173);
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatAppearance.MouseDownBackColor = Color.Black;
            btnlogout.FlatAppearance.MouseOverBackColor = Color.Black;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogout.ForeColor = SystemColors.ControlLightLight;
            btnlogout.Image = (Image)resources.GetObject("btnlogout.Image");
            btnlogout.Location = new Point(-77, -17);
            btnlogout.Name = "btnlogout";
            btnlogout.Padding = new Padding(0, 15, 70, 11);
            btnlogout.Size = new Size(311, 75);
            btnlogout.TabIndex = 1;
            btnlogout.Text = "Log out";
            btnlogout.TextAlign = ContentAlignment.MiddleRight;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click_1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 74, 173);
            panel6.Controls.Add(HistoryButton);
            panel6.Location = new Point(4, 210);
            panel6.Name = "panel6";
            panel6.Size = new Size(234, 45);
            panel6.TabIndex = 12;
            // 
            // HistoryButton
            // 
            HistoryButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            HistoryButton.BackColor = Color.FromArgb(0, 74, 173);
            HistoryButton.FlatAppearance.BorderSize = 0;
            HistoryButton.FlatAppearance.MouseDownBackColor = Color.Black;
            HistoryButton.FlatAppearance.MouseOverBackColor = Color.Black;
            HistoryButton.FlatStyle = FlatStyle.Flat;
            HistoryButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            HistoryButton.ForeColor = SystemColors.ControlLightLight;
            HistoryButton.Image = (Image)resources.GetObject("HistoryButton.Image");
            HistoryButton.Location = new Point(-111, -17);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Padding = new Padding(0, 15, 70, 11);
            HistoryButton.Size = new Size(384, 75);
            HistoryButton.TabIndex = 1;
            HistoryButton.Text = "Historique tickets";
            HistoryButton.TextAlign = ContentAlignment.MiddleRight;
            HistoryButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 74, 173);
            panel2.Controls.Add(dashboardButton);
            panel2.Location = new Point(3, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 45);
            panel2.TabIndex = 8;
            // 
            // dashboardButton
            // 
            dashboardButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dashboardButton.BackColor = Color.Black;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatAppearance.MouseDownBackColor = Color.Black;
            dashboardButton.FlatAppearance.MouseOverBackColor = Color.Black;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dashboardButton.ForeColor = SystemColors.ControlLightLight;
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.Location = new Point(-77, -17);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(0, 15, 70, 11);
            dashboardButton.Size = new Size(311, 75);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleRight;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 74, 173);
            panel5.Controls.Add(ticketsButton);
            panel5.Location = new Point(4, 147);
            panel5.Name = "panel5";
            panel5.Size = new Size(234, 45);
            panel5.TabIndex = 11;
            // 
            // ticketsButton
            // 
            ticketsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ticketsButton.BackColor = Color.FromArgb(0, 74, 173);
            ticketsButton.FlatAppearance.BorderSize = 0;
            ticketsButton.FlatAppearance.MouseDownBackColor = Color.Black;
            ticketsButton.FlatAppearance.MouseOverBackColor = Color.Black;
            ticketsButton.FlatStyle = FlatStyle.Flat;
            ticketsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ticketsButton.ForeColor = SystemColors.ControlLightLight;
            ticketsButton.Image = (Image)resources.GetObject("ticketsButton.Image");
            ticketsButton.Location = new Point(-70, -17);
            ticketsButton.Name = "ticketsButton";
            ticketsButton.Padding = new Padding(0, 15, 70, 11);
            ticketsButton.Size = new Size(297, 75);
            ticketsButton.TabIndex = 1;
            ticketsButton.Text = "voir tickets";
            ticketsButton.TextAlign = ContentAlignment.MiddleRight;
            ticketsButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 74, 173);
            panel3.Controls.Add(employeButton);
            panel3.Location = new Point(3, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(234, 45);
            panel3.TabIndex = 9;
            // 
            // employeButton
            // 
            employeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            employeButton.BackColor = Color.FromArgb(0, 74, 173);
            employeButton.FlatAppearance.BorderSize = 0;
            employeButton.FlatAppearance.MouseDownBackColor = Color.Black;
            employeButton.FlatAppearance.MouseOverBackColor = Color.Black;
            employeButton.FlatStyle = FlatStyle.Flat;
            employeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            employeButton.ForeColor = SystemColors.ControlLightLight;
            employeButton.Image = (Image)resources.GetObject("employeButton.Image");
            employeButton.Location = new Point(-58, -17);
            employeButton.Name = "employeButton";
            employeButton.Padding = new Padding(0, 15, 87, 11);
            employeButton.Size = new Size(293, 75);
            employeButton.TabIndex = 1;
            employeButton.Text = "Employé";
            employeButton.TextAlign = ContentAlignment.MiddleRight;
            employeButton.UseVisualStyleBackColor = false;
            // 
            // mainpanel_tech
            // 
            mainpanel_tech.Location = new Point(225, 2);
            mainpanel_tech.Name = "mainpanel_tech";
            mainpanel_tech.Size = new Size(794, 601);
            mainpanel_tech.TabIndex = 2;
            mainpanel_tech.Paint += panel7_Paint;
            // 
            // TechnicienForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 601);
            Controls.Add(mainpanel_tech);
            Controls.Add(panel1);
            Name = "TechnicienForm";
            Text = "TechnicienForm";
            Load += TechnicienForm_Load;
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel6;
        private Button HistoryButton;
        private Panel panel2;
        private Button dashboardButton;
        private Panel panel5;
        private Button ticketsButton;
        private Panel panel3;
        private Button employeButton;
        private Panel panel8;
        private Button btnlogout;
        private Panel mainpanel_tech;
    }
}