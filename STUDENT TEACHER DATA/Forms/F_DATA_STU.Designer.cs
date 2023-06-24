namespace STUDENT_TEACHER_DATA
{
    partial class F_DATA_STU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_DATA_STU));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.b_delete = new Guna.UI2.WinForms.Guna2Button();
            this.b_edit = new Guna.UI2.WinForms.Guna2Button();
            this.b_search = new Guna.UI2.WinForms.Guna2Button();
            this.t_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgv_stu = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu)).BeginInit();
            this.SuspendLayout();
            // 
            // b_delete
            // 
            this.b_delete.Animated = true;
            this.b_delete.AutoRoundedCorners = true;
            this.b_delete.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.b_delete.BorderRadius = 18;
            this.b_delete.BorderThickness = 1;
            this.b_delete.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.b_delete.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.b_delete.CheckedState.ForeColor = System.Drawing.Color.White;
            this.b_delete.CustomizableEdges.BottomLeft = false;
            this.b_delete.CustomizableEdges.TopLeft = false;
            this.b_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.b_delete.Font = new System.Drawing.Font("AlHurraTxtlight", 12F);
            this.b_delete.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.b_delete.HoverState.BorderColor = System.Drawing.Color.Violet;
            this.b_delete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.b_delete.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.b_delete.Location = new System.Drawing.Point(457, 400);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(151, 38);
            this.b_delete.TabIndex = 48;
            this.b_delete.Text = "حذف";
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_edit
            // 
            this.b_edit.Animated = true;
            this.b_edit.AutoRoundedCorners = true;
            this.b_edit.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.b_edit.BorderRadius = 18;
            this.b_edit.BorderThickness = 1;
            this.b_edit.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.b_edit.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.b_edit.CheckedState.ForeColor = System.Drawing.Color.White;
            this.b_edit.CustomizableEdges.BottomRight = false;
            this.b_edit.CustomizableEdges.TopRight = false;
            this.b_edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.b_edit.Font = new System.Drawing.Font("AlHurraTxtlight", 12F);
            this.b_edit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.b_edit.HoverState.BorderColor = System.Drawing.Color.Violet;
            this.b_edit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.b_edit.HoverState.ForeColor = System.Drawing.Color.RoyalBlue;
            this.b_edit.Location = new System.Drawing.Point(300, 400);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(151, 38);
            this.b_edit.TabIndex = 49;
            this.b_edit.Text = "تعديل";
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_search
            // 
            this.b_search.Animated = true;
            this.b_search.AutoRoundedCorners = true;
            this.b_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_search.BorderRadius = 14;
            this.b_search.BorderThickness = 1;
            this.b_search.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_search.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_search.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_search.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_search.CustomizableEdges.BottomLeft = false;
            this.b_search.CustomizableEdges.TopLeft = false;
            this.b_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.b_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.b_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.b_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.b_search.ForeColor = System.Drawing.Color.White;
            this.b_search.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.b_search.Image = ((System.Drawing.Image)(resources.GetObject("b_search.Image")));
            this.b_search.Location = new System.Drawing.Point(249, 404);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(39, 30);
            this.b_search.TabIndex = 74;
            // 
            // t_search
            // 
            this.t_search.Animated = true;
            this.t_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.t_search.BorderRadius = 10;
            this.t_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.t_search.CustomizableEdges.BottomRight = false;
            this.t_search.CustomizableEdges.TopRight = false;
            this.t_search.DefaultText = "";
            this.t_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.t_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.t_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.t_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.t_search.FocusedState.BorderColor = System.Drawing.Color.Plum;
            this.t_search.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.t_search.ForeColor = System.Drawing.Color.White;
            this.t_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.t_search.Location = new System.Drawing.Point(13, 404);
            this.t_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_search.Name = "t_search";
            this.t_search.PasswordChar = '\0';
            this.t_search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.t_search.PlaceholderText = "بحث";
            this.t_search.SelectedText = "";
            this.t_search.Size = new System.Drawing.Size(238, 30);
            this.t_search.TabIndex = 73;
            this.t_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.t_search.TextChanged += new System.EventHandler(this.t_search_TextChanged);
            // 
            // dgv_stu
            // 
            this.dgv_stu.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_stu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_stu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_stu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dgv_stu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_stu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("PT Bold Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_stu.ColumnHeadersHeight = 35;
            this.dgv_stu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_stu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_stu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_stu.Location = new System.Drawing.Point(12, 12);
            this.dgv_stu.Name = "dgv_stu";
            this.dgv_stu.ReadOnly = true;
            this.dgv_stu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_stu.RowHeadersVisible = false;
            this.dgv_stu.RowHeadersWidth = 51;
            this.dgv_stu.RowTemplate.Height = 30;
            this.dgv_stu.Size = new System.Drawing.Size(623, 365);
            this.dgv_stu.TabIndex = 75;
            this.dgv_stu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv_stu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_stu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_stu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_stu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_stu.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.dgv_stu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_stu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_stu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_stu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("PT Bold Heading", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgv_stu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_stu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_stu.ThemeStyle.HeaderStyle.Height = 35;
            this.dgv_stu.ThemeStyle.ReadOnly = true;
            this.dgv_stu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Lavender;
            this.dgv_stu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_stu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_stu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_stu.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_stu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.dgv_stu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_stu.DoubleClick += new System.EventHandler(this.dgv_stu_DoubleClick);
            // 
            // F_DATA_STU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(647, 452);
            this.Controls.Add(this.dgv_stu);
            this.Controls.Add(this.b_search);
            this.Controls.Add(this.t_search);
            this.Controls.Add(this.b_edit);
            this.Controls.Add(this.b_delete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_DATA_STU";
            this.Text = "F_DATA_STU";
            this.Load += new System.EventHandler(this.F_DATA_STU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button b_delete;
        private Guna.UI2.WinForms.Guna2Button b_edit;
        private Guna.UI2.WinForms.Guna2Button b_search;
        internal Guna.UI2.WinForms.Guna2TextBox t_search;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_stu;
    }
}