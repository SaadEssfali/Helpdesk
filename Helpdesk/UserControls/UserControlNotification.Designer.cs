namespace Helpdesk.UserControls
{
    partial class UserControlNotification
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
            asRead = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // asRead
            // 
            asRead.Location = new Point(551, 19);
            asRead.Name = "asRead";
            asRead.Size = new Size(208, 35);
            asRead.TabIndex = 1;
            asRead.Text = "marquer tout comme lu ✔️";
            asRead.UseVisualStyleBackColor = true;
            asRead.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 113);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // UserControlNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(asRead);
            Name = "UserControlNotification";
            Size = new Size(800, 583);
            Load += UserControlNotification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button asRead;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
