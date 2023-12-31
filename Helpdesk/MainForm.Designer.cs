namespace Helpdesk
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panel8 = new Panel();
            btnlogout = new Button();
            panel7 = new Panel();
            attentionred = new PictureBox();
            NotificationButton = new Button();
            panel6 = new Panel();
            HistoryButton = new Button();
            panel2 = new Panel();
            dashboardButton = new Button();
            panel5 = new Panel();
            ticketsButton = new Button();
            panel3 = new Panel();
            employeButton = new Button();
            panel4 = new Panel();
            techniciensButton = new Button();
            mainPanel = new Panel();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attentionred).BeginInit();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(0, 74, 173);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 453);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 74, 173);
            panel8.Controls.Add(btnlogout);
            panel8.Location = new Point(-1, 408);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(205, 34);
            panel8.TabIndex = 8;
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
            btnlogout.Location = new Point(-67, -13);
            btnlogout.Margin = new Padding(3, 2, 3, 2);
            btnlogout.Name = "btnlogout";
            btnlogout.Padding = new Padding(0, 11, 61, 8);
            btnlogout.Size = new Size(272, 56);
            btnlogout.TabIndex = 1;
            btnlogout.Text = "Log out";
            btnlogout.TextAlign = ContentAlignment.MiddleRight;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(0, 74, 173);
            panel7.Controls.Add(attentionred);
            panel7.Controls.Add(NotificationButton);
            panel7.Location = new Point(0, 257);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(205, 34);
            panel7.TabIndex = 7;
            // 
            // attentionred
            // 
            attentionred.Image = (Image)resources.GetObject("attentionred.Image");
            attentionred.Location = new Point(142, 5);
            attentionred.Margin = new Padding(3, 2, 3, 2);
            attentionred.Name = "attentionred";
            attentionred.Size = new Size(41, 23);
            attentionred.SizeMode = PictureBoxSizeMode.Zoom;
            attentionred.TabIndex = 0;
            attentionred.TabStop = false;
            attentionred.Visible = false;
            // 
            // NotificationButton
            // 
            NotificationButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            NotificationButton.BackColor = Color.FromArgb(0, 74, 173);
            NotificationButton.FlatAppearance.BorderSize = 0;
            NotificationButton.FlatAppearance.MouseDownBackColor = Color.Black;
            NotificationButton.FlatAppearance.MouseOverBackColor = Color.Black;
            NotificationButton.FlatStyle = FlatStyle.Flat;
            NotificationButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            NotificationButton.ForeColor = SystemColors.ControlLightLight;
            NotificationButton.Image = (Image)resources.GetObject("NotificationButton.Image");
            NotificationButton.Location = new Point(-67, -13);
            NotificationButton.Margin = new Padding(3, 2, 3, 2);
            NotificationButton.Name = "NotificationButton";
            NotificationButton.Padding = new Padding(0, 11, 61, 8);
            NotificationButton.Size = new Size(272, 56);
            NotificationButton.TabIndex = 1;
            NotificationButton.Text = "Notification";
            NotificationButton.TextAlign = ContentAlignment.MiddleRight;
            NotificationButton.UseVisualStyleBackColor = false;
            NotificationButton.Click += NotificationButton_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 74, 173);
            panel6.Controls.Add(HistoryButton);
            panel6.Location = new Point(0, 210);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(205, 34);
            panel6.TabIndex = 6;
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
            HistoryButton.Location = new Point(-97, -13);
            HistoryButton.Margin = new Padding(3, 2, 3, 2);
            HistoryButton.Name = "HistoryButton";
            HistoryButton.Padding = new Padding(0, 11, 61, 8);
            HistoryButton.Size = new Size(336, 56);
            HistoryButton.TabIndex = 1;
            HistoryButton.Text = "Historique tickets";
            HistoryButton.TextAlign = ContentAlignment.MiddleRight;
            HistoryButton.UseVisualStyleBackColor = false;
            HistoryButton.Click += HistoryButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 74, 173);
            panel2.Controls.Add(dashboardButton);
            panel2.Location = new Point(0, 21);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(205, 34);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint_1;
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
            dashboardButton.Location = new Point(-67, -13);
            dashboardButton.Margin = new Padding(3, 2, 3, 2);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(0, 11, 61, 8);
            dashboardButton.Size = new Size(272, 56);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleRight;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += button1_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 74, 173);
            panel5.Controls.Add(ticketsButton);
            panel5.Location = new Point(0, 163);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(205, 34);
            panel5.TabIndex = 5;
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
            ticketsButton.Location = new Point(-90, -13);
            ticketsButton.Margin = new Padding(3, 2, 3, 2);
            ticketsButton.Name = "ticketsButton";
            ticketsButton.Padding = new Padding(0, 11, 61, 8);
            ticketsButton.Size = new Size(319, 56);
            ticketsButton.TabIndex = 1;
            ticketsButton.Text = "Création tickets";
            ticketsButton.TextAlign = ContentAlignment.MiddleRight;
            ticketsButton.UseVisualStyleBackColor = false;
            ticketsButton.Click += ticketsButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 74, 173);
            panel3.Controls.Add(employeButton);
            panel3.Location = new Point(0, 68);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 34);
            panel3.TabIndex = 3;
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
            employeButton.Location = new Point(-51, -13);
            employeButton.Margin = new Padding(3, 2, 3, 2);
            employeButton.Name = "employeButton";
            employeButton.Padding = new Padding(0, 11, 76, 8);
            employeButton.Size = new Size(256, 56);
            employeButton.TabIndex = 1;
            employeButton.Text = "Employé";
            employeButton.TextAlign = ContentAlignment.MiddleRight;
            employeButton.UseVisualStyleBackColor = false;
            employeButton.Click += employeButton_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 74, 173);
            panel4.Controls.Add(techniciensButton);
            panel4.Location = new Point(0, 116);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(205, 34);
            panel4.TabIndex = 4;
            // 
            // techniciensButton
            // 
            techniciensButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            techniciensButton.BackColor = Color.FromArgb(0, 74, 173);
            techniciensButton.FlatAppearance.BorderSize = 0;
            techniciensButton.FlatAppearance.MouseDownBackColor = Color.Black;
            techniciensButton.FlatAppearance.MouseOverBackColor = Color.Black;
            techniciensButton.FlatStyle = FlatStyle.Flat;
            techniciensButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            techniciensButton.ForeColor = SystemColors.ControlLightLight;
            techniciensButton.Image = (Image)resources.GetObject("techniciensButton.Image");
            techniciensButton.Location = new Point(-67, -13);
            techniciensButton.Margin = new Padding(3, 2, 3, 2);
            techniciensButton.Name = "techniciensButton";
            techniciensButton.Padding = new Padding(0, 11, 61, 8);
            techniciensButton.Size = new Size(272, 56);
            techniciensButton.TabIndex = 1;
            techniciensButton.Text = "Techniciens";
            techniciensButton.TextAlign = ContentAlignment.MiddleRight;
            techniciensButton.UseVisualStyleBackColor = false;
            techniciensButton.Click += button3_Click;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Location = new Point(203, 0);
            mainPanel.Margin = new Padding(3, 2, 3, 2);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(690, 450);
            mainPanel.TabIndex = 1;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 451);
            Controls.Add(panel1);
            Controls.Add(mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Helpdesk";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)attentionred).EndInit();
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button dashboardButton;
        private Panel panel3;
        private Button employeButton;
        private Panel panel4;
        private Button techniciensButton;
        private Panel panel5;
        private Button ticketsButton;
        private Panel panel6;
        private Button HistoryButton;
        private Panel panel7;
        private Button NotificationButton;
        private Panel mainPanel;
        private Panel panel8;
        private Button btnlogout;
        private PictureBox attentionred;
    }
}