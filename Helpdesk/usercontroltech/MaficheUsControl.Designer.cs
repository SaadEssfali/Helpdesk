namespace Helpdesk.usercontroltech
{
    partial class MaficheUsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaficheUsControl));
            pictureBox1 = new PictureBox();
            DEPlabel = new Label();
            SERVlabrl = new Label();
            SPEClabel = new Label();
            BURlabel = new Label();
            TELElabel = new Label();
            NAMElabel = new Label();
            IDlabel = new Label();
            prenomlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(740, 549);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // DEPlabel
            // 
            DEPlabel.AutoSize = true;
            DEPlabel.Location = new Point(350, 329);
            DEPlabel.Name = "DEPlabel";
            DEPlabel.Size = new Size(50, 20);
            DEPlabel.TabIndex = 1;
            DEPlabel.Text = "label1";
            // 
            // SERVlabrl
            // 
            SERVlabrl.AutoSize = true;
            SERVlabrl.Location = new Point(301, 372);
            SERVlabrl.Name = "SERVlabrl";
            SERVlabrl.Size = new Size(50, 20);
            SERVlabrl.TabIndex = 2;
            SERVlabrl.Text = "label2";
            // 
            // SPEClabel
            // 
            SPEClabel.AutoSize = true;
            SPEClabel.Location = new Point(318, 414);
            SPEClabel.Name = "SPEClabel";
            SPEClabel.Size = new Size(50, 20);
            SPEClabel.TabIndex = 3;
            SPEClabel.Text = "label3";
            // 
            // BURlabel
            // 
            BURlabel.AutoSize = true;
            BURlabel.Location = new Point(330, 451);
            BURlabel.Name = "BURlabel";
            BURlabel.Size = new Size(50, 20);
            BURlabel.TabIndex = 4;
            BURlabel.Text = "label4";
            // 
            // TELElabel
            // 
            TELElabel.AutoSize = true;
            TELElabel.Location = new Point(301, 490);
            TELElabel.Name = "TELElabel";
            TELElabel.Size = new Size(50, 20);
            TELElabel.TabIndex = 5;
            TELElabel.Text = "label5";
            // 
            // NAMElabel
            // 
            NAMElabel.AutoSize = true;
            NAMElabel.ForeColor = Color.Black;
            NAMElabel.Location = new Point(407, 252);
            NAMElabel.Name = "NAMElabel";
            NAMElabel.Size = new Size(50, 20);
            NAMElabel.TabIndex = 6;
            NAMElabel.Text = "label6";
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Location = new Point(135, 51);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(50, 20);
            IDlabel.TabIndex = 7;
            IDlabel.Text = "label7";
            IDlabel.Click += IDlabel_Click;
            // 
            // prenomlabel
            // 
            prenomlabel.AutoSize = true;
            prenomlabel.Location = new Point(350, 252);
            prenomlabel.Name = "prenomlabel";
            prenomlabel.Size = new Size(50, 20);
            prenomlabel.TabIndex = 10;
            prenomlabel.Text = "label8";
            // 
            // MaficheUsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(prenomlabel);
            Controls.Add(IDlabel);
            Controls.Add(NAMElabel);
            Controls.Add(TELElabel);
            Controls.Add(BURlabel);
            Controls.Add(SPEClabel);
            Controls.Add(SERVlabrl);
            Controls.Add(DEPlabel);
            Controls.Add(pictureBox1);
            Name = "MaficheUsControl";
            Size = new Size(800, 583);
            Load += MaficheUsControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label DEPlabel;
        private Label SERVlabrl;
        private Label SPEClabel;
        private Label BURlabel;
        private Label TELElabel;
        private Label NAMElabel;
        private Label IDlabel;
        private Label prenomlabel;
    }
}
