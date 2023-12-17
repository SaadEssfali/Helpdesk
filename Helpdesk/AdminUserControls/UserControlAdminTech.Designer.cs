namespace Helpdesk.AdminUserControls
{
    partial class UserControlAdminTech
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            Nom = new Label();
            btnajouter = new Button();
            btnsupprimer = new Button();
            btnmettreajour = new Button();
            btnvider = new Button();
            Usename = new Label();
            txtUsername = new TextBox();
            Passe = new Label();
            textPass = new TextBox();
            Prenom = new Label();
            textPrenom = new TextBox();
            Telephone = new Label();
            textTelephone = new TextBox();
            Departement = new Label();
            textDepartement = new TextBox();
            Service = new Label();
            textService = new TextBox();
            Specialite = new Label();
            Bureau = new Label();
            textBureau = new TextBox();
            dataGridView1 = new DataGridView();
            comboBoxSpecialite = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(119, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(117, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // Nom
            // 
            Nom.AutoSize = true;
            Nom.BackColor = Color.Transparent;
            Nom.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Nom.ForeColor = Color.White;
            Nom.Location = new Point(21, 44);
            Nom.Name = "Nom";
            Nom.Size = new Size(59, 21);
            Nom.TabIndex = 1;
            Nom.Text = "Nom :";
            Nom.Click += label1_Click;
            // 
            // btnajouter
            // 
            btnajouter.BackColor = Color.SeaGreen;
            btnajouter.FlatAppearance.BorderSize = 0;
            btnajouter.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnajouter.ForeColor = Color.White;
            btnajouter.Location = new Point(12, 226);
            btnajouter.Name = "btnajouter";
            btnajouter.Size = new Size(168, 58);
            btnajouter.TabIndex = 21;
            btnajouter.Text = "Ajouter";
            btnajouter.UseVisualStyleBackColor = false;
            // 
            // btnsupprimer
            // 
            btnsupprimer.BackColor = Color.FromArgb(240, 30, 44);
            btnsupprimer.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsupprimer.ForeColor = Color.White;
            btnsupprimer.Location = new Point(216, 226);
            btnsupprimer.Name = "btnsupprimer";
            btnsupprimer.Size = new Size(168, 58);
            btnsupprimer.TabIndex = 22;
            btnsupprimer.Text = "Supprimer";
            btnsupprimer.UseVisualStyleBackColor = false;
            // 
            // btnmettreajour
            // 
            btnmettreajour.BackColor = Color.White;
            btnmettreajour.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmettreajour.ForeColor = Color.Black;
            btnmettreajour.Location = new Point(419, 226);
            btnmettreajour.Name = "btnmettreajour";
            btnmettreajour.Size = new Size(168, 58);
            btnmettreajour.TabIndex = 23;
            btnmettreajour.Text = "Mettre à jour";
            btnmettreajour.UseVisualStyleBackColor = false;
            // 
            // btnvider
            // 
            btnvider.BackColor = Color.Black;
            btnvider.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnvider.ForeColor = Color.OldLace;
            btnvider.Location = new Point(619, 226);
            btnvider.Name = "btnvider";
            btnvider.Size = new Size(168, 58);
            btnvider.TabIndex = 24;
            btnvider.Text = "Vider";
            btnvider.UseVisualStyleBackColor = false;
            // 
            // Usename
            // 
            Usename.AutoSize = true;
            Usename.BackColor = Color.Transparent;
            Usename.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Usename.ForeColor = Color.White;
            Usename.Location = new Point(252, 44);
            Usename.Name = "Usename";
            Usename.Size = new Size(110, 21);
            Usename.TabIndex = 26;
            Usename.Text = "UserName :";
            Usename.Click += label1_Click_1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(368, 38);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(135, 27);
            txtUsername.TabIndex = 25;
            // 
            // Passe
            // 
            Passe.AutoSize = true;
            Passe.BackColor = Color.Transparent;
            Passe.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Passe.ForeColor = Color.White;
            Passe.Location = new Point(516, 44);
            Passe.Name = "Passe";
            Passe.Size = new Size(136, 21);
            Passe.TabIndex = 28;
            Passe.Text = "Mot De Passe :";
            Passe.Click += label2_Click_1;
            // 
            // textPass
            // 
            textPass.Location = new Point(662, 42);
            textPass.Name = "textPass";
            textPass.Size = new Size(123, 27);
            textPass.TabIndex = 27;
            textPass.TextChanged += textBox2_TextChanged_1;
            // 
            // Prenom
            // 
            Prenom.AutoSize = true;
            Prenom.BackColor = Color.Transparent;
            Prenom.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Prenom.ForeColor = Color.White;
            Prenom.Location = new Point(12, 106);
            Prenom.Name = "Prenom";
            Prenom.Size = new Size(82, 21);
            Prenom.TabIndex = 30;
            Prenom.Text = "Prenom :";
            // 
            // textPrenom
            // 
            textPrenom.Location = new Point(119, 104);
            textPrenom.Name = "textPrenom";
            textPrenom.Size = new Size(117, 27);
            textPrenom.TabIndex = 29;
            // 
            // Telephone
            // 
            Telephone.AutoSize = true;
            Telephone.BackColor = Color.Transparent;
            Telephone.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Telephone.ForeColor = Color.White;
            Telephone.Location = new Point(252, 106);
            Telephone.Name = "Telephone";
            Telephone.Size = new Size(113, 21);
            Telephone.TabIndex = 32;
            Telephone.Text = "Telephone :";
            // 
            // textTelephone
            // 
            textTelephone.Location = new Point(368, 104);
            textTelephone.Name = "textTelephone";
            textTelephone.Size = new Size(135, 27);
            textTelephone.TabIndex = 31;
            // 
            // Departement
            // 
            Departement.AutoSize = true;
            Departement.BackColor = Color.Transparent;
            Departement.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Departement.ForeColor = Color.White;
            Departement.Location = new Point(516, 106);
            Departement.Name = "Departement";
            Departement.Size = new Size(140, 21);
            Departement.TabIndex = 34;
            Departement.Text = "Departement :";
            Departement.Click += label5_Click;
            // 
            // textDepartement
            // 
            textDepartement.Location = new Point(662, 104);
            textDepartement.Name = "textDepartement";
            textDepartement.Size = new Size(123, 27);
            textDepartement.TabIndex = 33;
            // 
            // Service
            // 
            Service.AutoSize = true;
            Service.BackColor = Color.Transparent;
            Service.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Service.ForeColor = Color.White;
            Service.Location = new Point(516, 163);
            Service.Name = "Service";
            Service.Size = new Size(109, 21);
            Service.TabIndex = 36;
            Service.Text = "N° Service :";
            // 
            // textService
            // 
            textService.Location = new Point(662, 161);
            textService.Name = "textService";
            textService.Size = new Size(123, 27);
            textService.TabIndex = 35;
            textService.TextChanged += textBox6_TextChanged;
            // 
            // Specialite
            // 
            Specialite.AutoSize = true;
            Specialite.BackColor = Color.Transparent;
            Specialite.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Specialite.ForeColor = Color.White;
            Specialite.Location = new Point(12, 167);
            Specialite.Name = "Specialite";
            Specialite.Size = new Size(101, 21);
            Specialite.TabIndex = 38;
            Specialite.Text = "Specialité :";
            // 
            // Bureau
            // 
            Bureau.AutoSize = true;
            Bureau.BackColor = Color.Transparent;
            Bureau.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Bureau.ForeColor = Color.White;
            Bureau.Location = new Point(252, 163);
            Bureau.Name = "Bureau";
            Bureau.Size = new Size(106, 21);
            Bureau.TabIndex = 40;
            Bureau.Text = "N° Bureau :";
            // 
            // textBureau
            // 
            textBureau.Location = new Point(368, 161);
            textBureau.Name = "textBureau";
            textBureau.Size = new Size(135, 27);
            textBureau.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 310);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(933, 273);
            dataGridView1.TabIndex = 41;
            // 
            // comboBoxSpecialite
            // 
            comboBoxSpecialite.FormattingEnabled = true;
            comboBoxSpecialite.Items.AddRange(new object[] { "Software", "Hardware" });
            comboBoxSpecialite.Location = new Point(119, 156);
            comboBoxSpecialite.Name = "comboBoxSpecialite";
            comboBoxSpecialite.Size = new Size(117, 28);
            comboBoxSpecialite.TabIndex = 42;
            // 
            // UserControlAdminTech
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 29, 36);
            Controls.Add(comboBoxSpecialite);
            Controls.Add(dataGridView1);
            Controls.Add(Bureau);
            Controls.Add(textBureau);
            Controls.Add(Specialite);
            Controls.Add(Service);
            Controls.Add(textService);
            Controls.Add(Departement);
            Controls.Add(textDepartement);
            Controls.Add(Telephone);
            Controls.Add(textTelephone);
            Controls.Add(Prenom);
            Controls.Add(textPrenom);
            Controls.Add(Passe);
            Controls.Add(textPass);
            Controls.Add(Usename);
            Controls.Add(txtUsername);
            Controls.Add(btnvider);
            Controls.Add(btnmettreajour);
            Controls.Add(btnsupprimer);
            Controls.Add(btnajouter);
            Controls.Add(Nom);
            Controls.Add(txtName);
            ForeColor = SystemColors.HotTrack;
            Name = "UserControlAdminTech";
            Size = new Size(953, 601);
            Load += UserControlAdminTech_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label Nom;
        private Button btnajouter;
        private Button btnsupprimer;
        private Button btnmettreajour;
        private Button btnvider;
        private Label Usename;
        private TextBox txtUsername;
        private Label Passe;
        private TextBox textPass;
        private Label Prenom;
        private TextBox textPrenom;
        private Label Telephone;
        private TextBox textTelephone;
        private Label Departement;
        private TextBox textDepartement;
        private Label Service;
        private TextBox textService;
        private Label Specialite;
        private Label Bureau;
        private TextBox textBureau;
        private DataGridView dataGridView1;
        private ComboBox comboBoxSpecialite;
    }
}
