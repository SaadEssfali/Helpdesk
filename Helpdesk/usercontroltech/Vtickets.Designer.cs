namespace Helpdesk.usercontroltech
{
    partial class Vtickets
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
            flowLayoutTicket = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutTicket
            // 
            flowLayoutTicket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutTicket.FlowDirection = FlowDirection.TopDown;
            flowLayoutTicket.Location = new Point(29, 17);
            flowLayoutTicket.Name = "flowLayoutTicket";
            flowLayoutTicket.Size = new Size(740, 215);
            flowLayoutTicket.TabIndex = 0;
            flowLayoutTicket.Paint += flowLayoutPanel1_Paint;
            // 
            // Vtickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutTicket);
            Name = "Vtickets";
            Size = new Size(800, 583);
            Load += Vtickets_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutTicket;
    }
}
