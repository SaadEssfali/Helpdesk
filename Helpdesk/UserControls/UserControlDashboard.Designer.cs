﻿namespace Helpdesk.UserControls
{
    partial class UserControlDashboard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDashboard));
            picnticket = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            hourlabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            pictureBox5 = new PictureBox();
            dayOfMonthLabel = new Label();
            dayOfWeekLabel = new Label();
            monthLabel = new Label();
            picVotreID = new PictureBox();
            YearLabel = new Label();
            dashID = new Label();
            nticket = new Label();
            statuticket = new Label();
            ((System.ComponentModel.ISupportInitialize)picnticket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVotreID).BeginInit();
            SuspendLayout();
            // 
            // picnticket
            // 
            picnticket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picnticket.Image = (Image)resources.GetObject("picnticket.Image");
            picnticket.Location = new Point(126, 179);
            picnticket.Margin = new Padding(3, 4, 3, 4);
            picnticket.Name = "picnticket";
            picnticket.Size = new Size(246, 114);
            picnticket.SizeMode = PictureBoxSizeMode.AutoSize;
            picnticket.TabIndex = 0;
            picnticket.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(406, 180);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(246, 114);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(126, 38);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(246, 114);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(84, 339);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(426, 221);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // hourlabel
            // 
            hourlabel.AutoSize = true;
            hourlabel.BackColor = Color.White;
            hourlabel.Font = new Font("Segoe UI Semibold", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            hourlabel.Location = new Point(285, 421);
            hourlabel.Name = "hourlabel";
            hourlabel.Size = new Size(140, 60);
            hourlabel.TabIndex = 4;
            hourlabel.Text = "label1";
            hourlabel.Click += hourlabel_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(271, 383);
            label1.Name = "label1";
            label1.Size = new Size(213, 38);
            label1.TabIndex = 5;
            label1.Text = "Heure Actuelle";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(539, 339);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(146, 221);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // dayOfMonthLabel
            // 
            dayOfMonthLabel.AutoSize = true;
            dayOfMonthLabel.BackColor = Color.White;
            dayOfMonthLabel.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            dayOfMonthLabel.ImageAlign = ContentAlignment.MiddleRight;
            dayOfMonthLabel.Location = new Point(583, 396);
            dayOfMonthLabel.Name = "dayOfMonthLabel";
            dayOfMonthLabel.Size = new Size(145, 51);
            dayOfMonthLabel.TabIndex = 8;
            dayOfMonthLabel.Text = "label2";
            dayOfMonthLabel.TextAlign = ContentAlignment.MiddleRight;
            dayOfMonthLabel.Click += dayOfMonthLabel_Click;
            // 
            // dayOfWeekLabel
            // 
            dayOfWeekLabel.AutoSize = true;
            dayOfWeekLabel.BackColor = Color.White;
            dayOfWeekLabel.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point);
            dayOfWeekLabel.Location = new Point(549, 509);
            dayOfWeekLabel.Name = "dayOfWeekLabel";
            dayOfWeekLabel.Size = new Size(41, 17);
            dayOfWeekLabel.TabIndex = 9;
            dayOfWeekLabel.Text = "label3";
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.BackColor = Color.White;
            monthLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            monthLabel.Location = new Point(552, 349);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(81, 31);
            monthLabel.TabIndex = 7;
            monthLabel.Text = "label2";
            // 
            // picVotreID
            // 
            picVotreID.Image = (Image)resources.GetObject("picVotreID.Image");
            picVotreID.Location = new Point(406, 38);
            picVotreID.Name = "picVotreID";
            picVotreID.Size = new Size(246, 114);
            picVotreID.SizeMode = PictureBoxSizeMode.CenterImage;
            picVotreID.TabIndex = 10;
            picVotreID.TabStop = false;
            picVotreID.Click += picVotreID_Click;
            // 
            // YearLabel
            // 
            YearLabel.AutoSize = true;
            YearLabel.BackColor = Color.White;
            YearLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            YearLabel.Location = new Point(539, 526);
            YearLabel.Name = "YearLabel";
            YearLabel.Size = new Size(66, 28);
            YearLabel.TabIndex = 11;
            YearLabel.Text = "label2";
            // 
            // dashID
            // 
            dashID.AutoSize = true;
            dashID.BackColor = Color.Transparent;
            dashID.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            dashID.ForeColor = SystemColors.ActiveCaptionText;
            dashID.Location = new Point(510, 79);
            dashID.Name = "dashID";
            dashID.Size = new Size(113, 46);
            dashID.TabIndex = 12;
            dashID.Text = "label2";
            dashID.Click += dashID_Click_1;
            // 
            // nticket
            // 
            nticket.AutoSize = true;
            nticket.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            nticket.Location = new Point(236, 217);
            nticket.Name = "nticket";
            nticket.Size = new Size(91, 38);
            nticket.TabIndex = 13;
            nticket.Text = "label2";
            nticket.Click += nticket_Click;
            // 
            // statuticket
            // 
            statuticket.AutoSize = true;
            statuticket.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            statuticket.Location = new Point(212, 261);
            statuticket.Name = "statuticket";
            statuticket.Size = new Size(55, 23);
            statuticket.TabIndex = 14;
            statuticket.Text = "label3";
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 240, 242);
            Controls.Add(statuticket);
            Controls.Add(nticket);
            Controls.Add(dashID);
            Controls.Add(YearLabel);
            Controls.Add(dayOfWeekLabel);
            Controls.Add(dayOfMonthLabel);
            Controls.Add(monthLabel);
            Controls.Add(pictureBox5);
            Controls.Add(label1);
            Controls.Add(hourlabel);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(picnticket);
            Controls.Add(picVotreID);
            Name = "UserControlDashboard";
            Size = new Size(800, 583);
            Load += UserControlDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)picnticket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVotreID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picnticket;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label hourlabel;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox pictureBox5;
        private Label dayOfMonthLabel;
        private Label dayOfWeekLabel;
        private Label monthLabel;
        private PictureBox picVotreID;
        private Label YearLabel;
        private Label dashID;
        private Label nticket;
        private Label statuticket;
    }
}
