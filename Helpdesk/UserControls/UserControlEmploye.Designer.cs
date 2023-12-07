namespace Helpdesk.UserControls
{
    partial class UserControlEmploye
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlEmploye));
            Id_card = new PictureBox();
            Nom = new Label();
            Prnm = new Label();
            ((System.ComponentModel.ISupportInitialize)Id_card).BeginInit();
            SuspendLayout();
            // 
            // Id_card
            // 
            Id_card.Image = (Image)resources.GetObject("Id_card.Image");
            Id_card.Location = new Point(129, 75);
            Id_card.Name = "Id_card";
            Id_card.Size = new Size(509, 449);
            Id_card.SizeMode = PictureBoxSizeMode.CenterImage;
            Id_card.TabIndex = 0;
            Id_card.TabStop = false;
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.BackColor = Color.MintCream;
            Nom.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Nom.Location = new Point(185, 75);
            Nom.Name = "Nom";
            Nom.Size = new Size(96, 46);
            Nom.TabIndex = 1;
            Nom.Text = "Nom";
            Nom.Click += label1_Click;
            // 
            // Prnm
            // 
            Prnm.AutoSize = true;
            Prnm.BackColor = Color.MintCream;
            Prnm.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Prnm.Location = new Point(185, 121);
            Prnm.Name = "Prnm";
            Prnm.Size = new Size(141, 46);
            Prnm.TabIndex = 2;
            Prnm.Text = "Prénom";
            Prnm.Click += label2_Click;
            // 
            // UserControlEmploye
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(239, 240, 242);
            Controls.Add(Prnm);
            Controls.Add(Nom);
            Controls.Add(Id_card);
            Name = "UserControlEmploye";
            Size = new Size(800, 583);
            Load += UserControlEmploye_Load;
            ((System.ComponentModel.ISupportInitialize)Id_card).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Id_card;
        private Label Nom;
        private Label Prnm;
    }
}
