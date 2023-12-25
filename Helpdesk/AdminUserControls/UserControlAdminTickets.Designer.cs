namespace Helpdesk.AdminUserControls
{
    partial class UserControlAdminTickets
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
            Categorie = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBoxCategorie = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            DateOuverture = new DateTimePicker();
            DateOuvert = new Label();
            DateClotur = new Label();
            DateCloture = new DateTimePicker();
            btnvider = new Button();
            btnmettreajour = new Button();
            btnsupprimer = new Button();
            btnajouter = new Button();
            dataGridView1 = new DataGridView();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Categorie
            // 
            Categorie.AutoSize = true;
            Categorie.BackColor = Color.Transparent;
            Categorie.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Categorie.ForeColor = Color.White;
            Categorie.Location = new Point(12, 46);
            Categorie.Name = "Categorie";
            Categorie.Size = new Size(127, 21);
            Categorie.TabIndex = 46;
            Categorie.Text = "Categorie Id :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(341, 46);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 48;
            label1.Text = " Employe Id :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(563, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 27);
            textBox1.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(686, 50);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 50;
            label2.Text = " Statut :";
            // 
            // comboBoxCategorie
            // 
            comboBoxCategorie.FormattingEnabled = true;
            comboBoxCategorie.Items.AddRange(new object[] { "ouvert", "en cours", "fermé" });
            comboBoxCategorie.Location = new Point(780, 48);
            comboBoxCategorie.Name = "comboBoxCategorie";
            comboBoxCategorie.Size = new Size(151, 28);
            comboBoxCategorie.TabIndex = 51;
            comboBoxCategorie.SelectedIndexChanged += comboBoxCategorie_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 53;
            label3.Text = "Description :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 54;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(628, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(538, 106);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 55;
            label4.Text = "Priorité :";
            // 
            // DateOuverture
            // 
            DateOuverture.CustomFormat = " ";
            DateOuverture.Format = DateTimePickerFormat.Custom;
            DateOuverture.Location = new Point(166, 163);
            DateOuverture.Name = "DateOuverture";
            DateOuverture.Size = new Size(173, 27);
            DateOuverture.TabIndex = 57;
            DateOuverture.ValueChanged += DateOuverture_ValueChanged;
            DateOuverture.KeyDown += DateOuverture_KeyDown;
            // 
            // DateOuvert
            // 
            DateOuvert.AutoSize = true;
            DateOuvert.BackColor = Color.Transparent;
            DateOuvert.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DateOuvert.ForeColor = Color.White;
            DateOuvert.Location = new Point(12, 167);
            DateOuvert.Name = "DateOuvert";
            DateOuvert.Size = new Size(148, 21);
            DateOuvert.TabIndex = 58;
            DateOuvert.Text = "DateOuverture :";
            // 
            // DateClotur
            // 
            DateClotur.AutoSize = true;
            DateClotur.BackColor = Color.Transparent;
            DateClotur.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DateClotur.ForeColor = Color.White;
            DateClotur.Location = new Point(393, 167);
            DateClotur.Name = "DateClotur";
            DateClotur.Size = new Size(124, 21);
            DateClotur.TabIndex = 59;
            DateClotur.Text = "DateCloture :";
            // 
            // DateCloture
            // 
            DateCloture.CustomFormat = " ";
            DateCloture.Format = DateTimePickerFormat.Custom;
            DateCloture.Location = new Point(555, 161);
            DateCloture.Name = "DateCloture";
            DateCloture.Size = new Size(173, 27);
            DateCloture.TabIndex = 60;
            DateCloture.ValueChanged += DateCloture_ValueChanged;
            DateCloture.KeyDown += DateCloture_KeyDown;
            // 
            // btnvider
            // 
            btnvider.BackColor = Color.Black;
            btnvider.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnvider.ForeColor = Color.OldLace;
            btnvider.Location = new Point(619, 226);
            btnvider.Name = "btnvider";
            btnvider.Size = new Size(168, 58);
            btnvider.TabIndex = 64;
            btnvider.Text = "Vider";
            btnvider.UseVisualStyleBackColor = false;
            // 
            // btnmettreajour
            // 
            btnmettreajour.BackColor = Color.White;
            btnmettreajour.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnmettreajour.ForeColor = Color.Black;
            btnmettreajour.Location = new Point(419, 226);
            btnmettreajour.Name = "btnmettreajour";
            btnmettreajour.Size = new Size(168, 58);
            btnmettreajour.TabIndex = 63;
            btnmettreajour.Text = "Mettre à jour";
            btnmettreajour.UseVisualStyleBackColor = false;
            // 
            // btnsupprimer
            // 
            btnsupprimer.BackColor = Color.FromArgb(240, 30, 44);
            btnsupprimer.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsupprimer.ForeColor = Color.White;
            btnsupprimer.Location = new Point(216, 226);
            btnsupprimer.Name = "btnsupprimer";
            btnsupprimer.Size = new Size(168, 58);
            btnsupprimer.TabIndex = 62;
            btnsupprimer.Text = "Supprimer";
            btnsupprimer.UseVisualStyleBackColor = false;
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
            btnajouter.TabIndex = 61;
            btnajouter.Text = "Ajouter";
            btnajouter.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(41, 75, 93);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 310);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(989, 273);
            dataGridView1.TabIndex = 65;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(145, 44);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(117, 27);
            textBox3.TabIndex = 66;
            // 
            // UserControlAdminTickets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 75, 93);
            Controls.Add(textBox3);
            Controls.Add(dataGridView1);
            Controls.Add(btnvider);
            Controls.Add(btnmettreajour);
            Controls.Add(btnsupprimer);
            Controls.Add(btnajouter);
            Controls.Add(DateCloture);
            Controls.Add(DateClotur);
            Controls.Add(DateOuvert);
            Controls.Add(DateOuverture);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBoxCategorie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Categorie);
            Name = "UserControlAdminTickets";
            Size = new Size(998, 601);
            Load += UserControlAdminTickets_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Categorie;
        private TextBox txtName;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBoxCategorie;
        private Label label3;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private Label label4;
        private DateTimePicker DateOuverture;
        private Label DateOuvert;
        private Label DateClotur;
        private DateTimePicker DateCloture;
        private Button btnvider;
        private Button btnmettreajour;
        private Button btnsupprimer;
        private Button btnajouter;
        private DataGridView dataGridView1;
        private TextBox textBox3;
    }
}
