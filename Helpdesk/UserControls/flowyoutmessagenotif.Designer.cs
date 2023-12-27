namespace Helpdesk.UserControls
{
    partial class flowyoutmessagenotif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flowyoutmessagenotif));
            panel1 = new Panel();
            txtmessagenotif = new Label();
            date = new Label();
            attention = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)attention).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 10);
            panel1.TabIndex = 0;
            // 
            // txtmessagenotif
            // 
            txtmessagenotif.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtmessagenotif.AutoSize = true;
            txtmessagenotif.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtmessagenotif.Location = new Point(13, 22);
            txtmessagenotif.Name = "txtmessagenotif";
            txtmessagenotif.Size = new Size(59, 25);
            txtmessagenotif.TabIndex = 1;
            txtmessagenotif.Text = "label1";
            // 
            // date
            // 
            date.AutoSize = true;
            date.Location = new Point(632, 54);
            date.Name = "date";
            date.Size = new Size(50, 20);
            date.TabIndex = 2;
            date.Text = "label1";
            // 
            // attention
            // 
            attention.Image = (Image)resources.GetObject("attention.Image");
            attention.Location = new Point(713, 3);
            attention.Name = "attention";
            attention.Size = new Size(34, 35);
            attention.SizeMode = PictureBoxSizeMode.Zoom;
            attention.TabIndex = 3;
            attention.TabStop = false;
            attention.Visible = false;
            // 
            // flowyoutmessagenotif
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(attention);
            Controls.Add(date);
            Controls.Add(txtmessagenotif);
            Controls.Add(panel1);
            Name = "flowyoutmessagenotif";
            Size = new Size(750, 77);
            Load += flowyoutmessagenotif_Load;
            ((System.ComponentModel.ISupportInitialize)attention).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        public Label txtmessagenotif;
        public Label date;
        public PictureBox attention;
    }
}
