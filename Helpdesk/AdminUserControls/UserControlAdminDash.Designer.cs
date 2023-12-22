namespace Helpdesk.AdminUserControls
{
    partial class UserControlAdminDash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAdminDash));
            TickResPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)TickResPicture).BeginInit();
            SuspendLayout();
            // 
            // TickResPicture
            // 
            TickResPicture.Image = (Image)resources.GetObject("TickResPicture.Image");
            TickResPicture.Location = new Point(619, 27);
            TickResPicture.Name = "TickResPicture";
            TickResPicture.Size = new Size(335, 150);
            TickResPicture.TabIndex = 2;
            TickResPicture.TabStop = false;
            // 
            // UserControlAdminDash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(TickResPicture);
            Name = "UserControlAdminDash";
            Size = new Size(998, 601);
            ((System.ComponentModel.ISupportInitialize)TickResPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox TickResPicture;
    }
}
