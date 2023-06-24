namespace STUDENT_TEACHER_DATA
{
    partial class F_ADD_STU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_ADD_STU));
            this.com_dept_stu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_1_6 = new System.Windows.Forms.Label();
            this.b_add_stu = new Guna.UI2.WinForms.Guna2Button();
            this.t_fname_stu = new Guna.UI2.WinForms.Guna2TextBox();
            this.pbox_userName_1 = new System.Windows.Forms.PictureBox();
            this.t_id_stu = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.com_year_stu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.b_add_teach = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_userName_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // com_dept_stu
            // 
            this.com_dept_stu.BackColor = System.Drawing.Color.Transparent;
            this.com_dept_stu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.com_dept_stu.BorderRadius = 8;
            this.com_dept_stu.CustomizableEdges.BottomLeft = false;
            this.com_dept_stu.CustomizableEdges.TopLeft = false;
            this.com_dept_stu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.com_dept_stu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_dept_stu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.com_dept_stu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_dept_stu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_dept_stu.Font = new System.Drawing.Font("AlHurraTxtlight", 10.2F);
            this.com_dept_stu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.com_dept_stu.HoverState.BorderColor = System.Drawing.Color.Thistle;
            this.com_dept_stu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.com_dept_stu.IntegralHeight = false;
            this.com_dept_stu.ItemHeight = 25;
            this.com_dept_stu.Items.AddRange(new object[] {
            "كلية الهندسة المعلوماتية",
            "كلية الإدارة والإقتصاد",
            "المعهد التقاني للحاسوب",
            "معهد إدارة الأعمال"});
            this.com_dept_stu.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.com_dept_stu.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black;
            this.com_dept_stu.Location = new System.Drawing.Point(378, 239);
            this.com_dept_stu.Name = "com_dept_stu";
            this.com_dept_stu.Size = new System.Drawing.Size(229, 31);
            this.com_dept_stu.StartIndex = 0;
            this.com_dept_stu.TabIndex = 150;
            this.com_dept_stu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("PT Simple Bold Ruled", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(569, 210);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(44, 31);
            this.label2.TabIndex = 149;
            this.label2.Text = "الفرع";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 119);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(88, 27);
            this.label1.TabIndex = 148;
            this.label1.Text = "الاسم الثلاثي";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_1_6
            // 
            this.l_1_6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l_1_6.AutoSize = true;
            this.l_1_6.BackColor = System.Drawing.Color.Transparent;
            this.l_1_6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.l_1_6.Font = new System.Drawing.Font("PT Simple Bold Ruled", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.l_1_6.ForeColor = System.Drawing.Color.White;
            this.l_1_6.Location = new System.Drawing.Point(481, 119);
            this.l_1_6.Name = "l_1_6";
            this.l_1_6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.l_1_6.Size = new System.Drawing.Size(131, 27);
            this.l_1_6.TabIndex = 147;
            this.l_1_6.Text = " رقم الجامعي الطالب";
            this.l_1_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_add_stu
            // 
            this.b_add_stu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_add_stu.Animated = true;
            this.b_add_stu.AutoRoundedCorners = true;
            this.b_add_stu.BackColor = System.Drawing.Color.Transparent;
            this.b_add_stu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_add_stu.BorderRadius = 18;
            this.b_add_stu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.b_add_stu.BorderThickness = 1;
            this.b_add_stu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.b_add_stu.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_add_stu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_add_stu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_add_stu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_add_stu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_add_stu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.b_add_stu.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_add_stu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_add_stu.HoverState.BorderColor = System.Drawing.Color.Plum;
            this.b_add_stu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(80)))));
            this.b_add_stu.ImageSize = new System.Drawing.Size(18, 18);
            this.b_add_stu.Location = new System.Drawing.Point(231, 397);
            this.b_add_stu.Name = "b_add_stu";
            this.b_add_stu.ShadowDecoration.BorderRadius = 0;
            this.b_add_stu.Size = new System.Drawing.Size(157, 38);
            this.b_add_stu.TabIndex = 146;
            this.b_add_stu.TabStop = false;
            this.b_add_stu.Text = "إضافة طالب";
            this.b_add_stu.TextFormatNoPrefix = true;
            // 
            // t_fname_stu
            // 
            this.t_fname_stu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.t_fname_stu.Animated = true;
            this.t_fname_stu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_fname_stu.BorderRadius = 10;
            this.t_fname_stu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_fname_stu.CustomizableEdges.BottomRight = false;
            this.t_fname_stu.CustomizableEdges.TopRight = false;
            this.t_fname_stu.DefaultText = "";
            this.t_fname_stu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_fname_stu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_fname_stu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_fname_stu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_fname_stu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_fname_stu.FocusedState.BorderColor = System.Drawing.Color.Plum;
            this.t_fname_stu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_fname_stu.ForeColor = System.Drawing.Color.White;
            this.t_fname_stu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_fname_stu.IconRightSize = new System.Drawing.Size(25, 25);
            this.t_fname_stu.Location = new System.Drawing.Point(33, 144);
            this.t_fname_stu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.t_fname_stu.Name = "t_fname_stu";
            this.t_fname_stu.PasswordChar = '\0';
            this.t_fname_stu.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.t_fname_stu.PlaceholderText = "";
            this.t_fname_stu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.t_fname_stu.SelectedText = "";
            this.t_fname_stu.Size = new System.Drawing.Size(229, 32);
            this.t_fname_stu.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.t_fname_stu.TabIndex = 145;
            this.t_fname_stu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbox_userName_1
            // 
            this.pbox_userName_1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbox_userName_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbox_userName_1.BackgroundImage")));
            this.pbox_userName_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbox_userName_1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbox_userName_1.Location = new System.Drawing.Point(288, 18);
            this.pbox_userName_1.Name = "pbox_userName_1";
            this.pbox_userName_1.Size = new System.Drawing.Size(70, 75);
            this.pbox_userName_1.TabIndex = 144;
            this.pbox_userName_1.TabStop = false;
            // 
            // t_id_stu
            // 
            this.t_id_stu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.t_id_stu.Animated = true;
            this.t_id_stu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_id_stu.BorderRadius = 10;
            this.t_id_stu.Cursor = System.Windows.Forms.Cursors.Default;
            this.t_id_stu.CustomizableEdges.BottomRight = false;
            this.t_id_stu.CustomizableEdges.TopRight = false;
            this.t_id_stu.DefaultText = "";
            this.t_id_stu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_id_stu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_id_stu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_id_stu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_id_stu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_id_stu.FocusedState.BorderColor = System.Drawing.Color.Plum;
            this.t_id_stu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_id_stu.ForeColor = System.Drawing.Color.White;
            this.t_id_stu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_id_stu.IconRightSize = new System.Drawing.Size(25, 25);
            this.t_id_stu.Location = new System.Drawing.Point(378, 144);
            this.t_id_stu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.t_id_stu.Name = "t_id_stu";
            this.t_id_stu.PasswordChar = '\0';
            this.t_id_stu.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.t_id_stu.PlaceholderText = "";
            this.t_id_stu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.t_id_stu.SelectedText = "";
            this.t_id_stu.Size = new System.Drawing.Size(229, 32);
            this.t_id_stu.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.t_id_stu.TabIndex = 143;
            this.t_id_stu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("PT Simple Bold Ruled", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(218, 210);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(50, 31);
            this.label3.TabIndex = 151;
            this.label3.Text = "السنة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // com_year_stu
            // 
            this.com_year_stu.BackColor = System.Drawing.Color.Transparent;
            this.com_year_stu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.com_year_stu.BorderRadius = 8;
            this.com_year_stu.CustomizableEdges.BottomRight = false;
            this.com_year_stu.CustomizableEdges.TopRight = false;
            this.com_year_stu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.com_year_stu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_year_stu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.com_year_stu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_year_stu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.com_year_stu.Font = new System.Drawing.Font("AlHurraTxtlight", 10.2F);
            this.com_year_stu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.com_year_stu.HoverState.BorderColor = System.Drawing.Color.Thistle;
            this.com_year_stu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.com_year_stu.IntegralHeight = false;
            this.com_year_stu.ItemHeight = 25;
            this.com_year_stu.Items.AddRange(new object[] {
            "السنة الأولى",
            "السنة الثانية",
            "السنة الثالثة",
            "السنة الرابعة",
            "السنة الخامسة"});
            this.com_year_stu.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.com_year_stu.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black;
            this.com_year_stu.Location = new System.Drawing.Point(33, 239);
            this.com_year_stu.Name = "com_year_stu";
            this.com_year_stu.Size = new System.Drawing.Size(229, 31);
            this.com_year_stu.StartIndex = 0;
            this.com_year_stu.TabIndex = 152;
            this.com_year_stu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(12, 18);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(47, 50);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 153;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // F_ADD_STU
            // 
            // 
            // b_add_teach
            // 
            this.b_add_teach.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_add_teach.Animated = true;
            this.b_add_teach.AutoRoundedCorners = true;
            this.b_add_teach.BackColor = System.Drawing.Color.Transparent;
            this.b_add_teach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_add_teach.BorderRadius = 18;
            this.b_add_teach.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.b_add_teach.BorderThickness = 1;
            this.b_add_teach.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.b_add_teach.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_add_teach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_add_teach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_add_teach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_add_teach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.b_add_teach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.b_add_teach.Font = new System.Drawing.Font("PT Bold Heading", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.b_add_teach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_add_teach.HoverState.BorderColor = System.Drawing.Color.Plum;
            this.b_add_teach.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(80)))));
            this.b_add_teach.ImageSize = new System.Drawing.Size(18, 18);
            this.b_add_teach.Location = new System.Drawing.Point(231, 397);
            this.b_add_teach.Name = "b_add_teach";
            this.b_add_teach.ShadowDecoration.BorderRadius = 0;
            this.b_add_teach.Size = new System.Drawing.Size(157, 38);
            this.b_add_teach.TabIndex = 156;
            this.b_add_teach.TabStop = false;
            this.b_add_teach.Text = "إضافة مدرس";
            this.b_add_teach.TextFormatNoPrefix = true;
            this.AcceptButton = this.b_add_teach;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(647, 452);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.com_year_stu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.com_dept_stu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_1_6);
            this.Controls.Add(this.b_add_stu);
            this.Controls.Add(this.t_fname_stu);
            this.Controls.Add(this.pbox_userName_1);
            this.Controls.Add(this.t_id_stu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_ADD_STU";
            this.Text = "F_ADD_STU";
            this.Load += new System.EventHandler(this.F_ADD_STU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_userName_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox com_dept_stu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_1_6;
        private Guna.UI2.WinForms.Guna2Button b_add_stu;
        internal Guna.UI2.WinForms.Guna2TextBox t_fname_stu;
        private System.Windows.Forms.PictureBox pbox_userName_1;
        internal Guna.UI2.WinForms.Guna2TextBox t_id_stu;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox com_year_stu;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button b_add_teach;
    }
}