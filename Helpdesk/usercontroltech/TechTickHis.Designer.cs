namespace Helpdesk.usercontroltech
{
    partial class TechTickHis
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
            HistoriqueGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)HistoriqueGridView).BeginInit();
            SuspendLayout();
            // 
            // HistoriqueGridView
            // 
            HistoriqueGridView.BackgroundColor = SystemColors.Control;
            HistoriqueGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HistoriqueGridView.Location = new Point(0, 0);
            HistoriqueGridView.Name = "HistoriqueGridView";
            HistoriqueGridView.RowHeadersWidth = 51;
            HistoriqueGridView.RowTemplate.Height = 29;
            HistoriqueGridView.Size = new Size(800, 583);
            HistoriqueGridView.TabIndex = 0;
            HistoriqueGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TechTickHis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(HistoriqueGridView);
            Name = "TechTickHis";
            Size = new Size(800, 583);
            Load += TechTickHis_Load;
            ((System.ComponentModel.ISupportInitialize)HistoriqueGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HistoriqueGridView;
    }
}
