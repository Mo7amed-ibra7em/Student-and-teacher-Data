namespace STUDENT_TEACHER_DATA.Notification
{
    partial class F_NOTIFICATION
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_NOTIFICATION));
            this.lbl_notification = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictor_icon_22 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer_notification = new System.Windows.Forms.Timer(this.components);
            this.Borderless_Notification_open = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictor_icon_22)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_notification
            // 
            this.lbl_notification.BackColor = System.Drawing.Color.Transparent;
            this.lbl_notification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_notification.Font = new System.Drawing.Font("Amiri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_notification.ForeColor = System.Drawing.Color.White;
            this.lbl_notification.Location = new System.Drawing.Point(0, 0);
            this.lbl_notification.Name = "lbl_notification";
            this.lbl_notification.Size = new System.Drawing.Size(247, 63);
            this.lbl_notification.TabIndex = 0;
            this.lbl_notification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_notification.Click += new System.EventHandler(this.lbl_notification_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.lbl_notification);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(100)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(45, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(247, 63);
            this.guna2GradientPanel1.TabIndex = 3;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // pictor_icon_22
            // 
            this.pictor_icon_22.AutoRoundedCorners = true;
            this.pictor_icon_22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.pictor_icon_22.BorderRadius = 21;
            this.pictor_icon_22.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictor_icon_22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.pictor_icon_22.Image = ((System.Drawing.Image)(resources.GetObject("pictor_icon_22.Image")));
            this.pictor_icon_22.ImageRotate = 0F;
            this.pictor_icon_22.Location = new System.Drawing.Point(0, 0);
            this.pictor_icon_22.Name = "pictor_icon_22";
            this.pictor_icon_22.Size = new System.Drawing.Size(45, 63);
            this.pictor_icon_22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictor_icon_22.TabIndex = 2;
            this.pictor_icon_22.TabStop = false;
            this.pictor_icon_22.Click += new System.EventHandler(this.pictor_icon_Click);
            // 
            // timer_notification
            // 
            this.timer_notification.Enabled = true;
            this.timer_notification.Interval = 3000;
            this.timer_notification.Tick += new System.EventHandler(this.timer_notification_Tick);
            // 
            // Borderless_Notification_open
            // 
            this.Borderless_Notification_open.AnimateWindow = true;
            this.Borderless_Notification_open.AnimationInterval = 400;
            this.Borderless_Notification_open.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.Borderless_Notification_open.ContainerControl = this;
            this.Borderless_Notification_open.DockForm = false;
            this.Borderless_Notification_open.DockIndicatorTransparencyValue = 0.6D;
            this.Borderless_Notification_open.DragForm = false;
            this.Borderless_Notification_open.HasFormShadow = false;
            this.Borderless_Notification_open.ResizeForm = false;
            this.Borderless_Notification_open.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(30)))));
            this.Borderless_Notification_open.TransparentWhileDrag = true;
            // 
            // F_NOTIFICATION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 63);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.pictor_icon_22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(166, 228);
            this.Name = "F_NOTIFICATION";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "F_NOTIFICATION";
            this.Load += new System.EventHandler(this.F_NOTIFICATION_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictor_icon_22)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbl_notification;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox pictor_icon_22;
        private System.Windows.Forms.Timer timer_notification;
        private Guna.UI2.WinForms.Guna2BorderlessForm Borderless_Notification_open;
    }
}