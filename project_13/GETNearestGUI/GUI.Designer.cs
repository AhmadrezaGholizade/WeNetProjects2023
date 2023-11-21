namespace GETNearestGUI
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.Title = new System.Windows.Forms.Label();
            this.Title_Panel = new System.Windows.Forms.Panel();
            this.Hor_Line = new System.Windows.Forms.Panel();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.XBOX = new System.Windows.Forms.TextBox();
            this.YBOX = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.result = new System.Windows.Forms.Label();
            this.NAME_label = new System.Windows.Forms.Label();
            this.FOUNDER_label = new System.Windows.Forms.Label();
            this.X_label = new System.Windows.Forms.Label();
            this.Y_label = new System.Windows.Forms.Label();
            this.PROJECTS_label = new System.Windows.Forms.Label();
            this.COUNTRY_label = new System.Windows.Forms.Label();
            this.result_group = new System.Windows.Forms.GroupBox();
            this.error_group = new System.Windows.Forms.GroupBox();
            this.Hor_line2 = new System.Windows.Forms.Panel();
            this.result_label2 = new System.Windows.Forms.Label();
            this.error_label = new System.Windows.Forms.Label();
            this.Title_Panel.SuspendLayout();
            this.result_group.SuspendLayout();
            this.error_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Title.Location = new System.Drawing.Point(145, 37);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(749, 80);
            this.Title.TabIndex = 2;
            this.Title.Text = "GET Nearest COMPANY";
            this.Title.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Title_Panel
            // 
            this.Title_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Title_Panel.BackgroundImage")));
            this.Title_Panel.Controls.Add(this.Title);
            this.Title_Panel.Location = new System.Drawing.Point(17, 20);
            this.Title_Panel.Name = "Title_Panel";
            this.Title_Panel.Size = new System.Drawing.Size(875, 141);
            this.Title_Panel.TabIndex = 3;
            // 
            // Hor_Line
            // 
            this.Hor_Line.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Hor_Line.Location = new System.Drawing.Point(17, 170);
            this.Hor_Line.Name = "Hor_Line";
            this.Hor_Line.Size = new System.Drawing.Size(877, 10);
            this.Hor_Line.TabIndex = 4;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.BackColor = System.Drawing.Color.Transparent;
            this.label_X.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_X.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_X.Location = new System.Drawing.Point(12, 196);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(111, 80);
            this.label_X.TabIndex = 3;
            this.label_X.Text = "X :";
            this.label_X.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.BackColor = System.Drawing.Color.Transparent;
            this.label_Y.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Y.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_Y.Location = new System.Drawing.Point(460, 196);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(108, 80);
            this.label_Y.TabIndex = 5;
            this.label_Y.Text = "Y :";
            this.label_Y.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_search.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.SystemColors.Control;
            this.button_search.Location = new System.Drawing.Point(17, 283);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(875, 92);
            this.button_search.TabIndex = 8;
            this.button_search.Text = "SEARCH";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.Button1_Click);
            // 
            // XBOX
            // 
            this.XBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XBOX.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.XBOX.Location = new System.Drawing.Point(119, 194);
            this.XBOX.Margin = new System.Windows.Forms.Padding(0);
            this.XBOX.Name = "XBOX";
            this.XBOX.Size = new System.Drawing.Size(322, 83);
            this.XBOX.TabIndex = 10;
            // 
            // YBOX
            // 
            this.YBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YBOX.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.YBOX.Location = new System.Drawing.Point(570, 194);
            this.YBOX.Margin = new System.Windows.Forms.Padding(0);
            this.YBOX.Name = "YBOX";
            this.YBOX.Size = new System.Drawing.Size(322, 83);
            this.YBOX.TabIndex = 11;
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.BackColor = System.Drawing.Color.Transparent;
            this.ID_label.Font = new System.Drawing.Font("IRANYekan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ID_label.Location = new System.Drawing.Point(13, 68);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(44, 40);
            this.ID_label.TabIndex = 12;
            this.ID_label.Text = "ID:";
            this.ID_label.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 10);
            this.panel1.TabIndex = 5;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Transparent;
            this.result.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.result.Location = new System.Drawing.Point(9, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(184, 56);
            this.result.TabIndex = 13;
            this.result.Text = "RESULT";
            // 
            // NAME_label
            // 
            this.NAME_label.AutoSize = true;
            this.NAME_label.BackColor = System.Drawing.Color.Transparent;
            this.NAME_label.Font = new System.Drawing.Font("IRANYekan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NAME_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.NAME_label.Location = new System.Drawing.Point(13, 118);
            this.NAME_label.Name = "NAME_label";
            this.NAME_label.Size = new System.Drawing.Size(83, 40);
            this.NAME_label.TabIndex = 14;
            this.NAME_label.Text = "Name:";
            this.NAME_label.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // FOUNDER_label
            // 
            this.FOUNDER_label.AutoSize = true;
            this.FOUNDER_label.BackColor = System.Drawing.Color.Transparent;
            this.FOUNDER_label.Font = new System.Drawing.Font("IRANYekan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FOUNDER_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FOUNDER_label.Location = new System.Drawing.Point(458, 168);
            this.FOUNDER_label.Name = "FOUNDER_label";
            this.FOUNDER_label.Size = new System.Drawing.Size(108, 40);
            this.FOUNDER_label.TabIndex = 15;
            this.FOUNDER_label.Text = "Founder:";
            this.FOUNDER_label.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // X_label
            // 
            this.X_label.AutoSize = true;
            this.X_label.BackColor = System.Drawing.Color.Transparent;
            this.X_label.Font = new System.Drawing.Font("IRANYekan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.X_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.X_label.Location = new System.Drawing.Point(458, 68);
            this.X_label.Name = "X_label";
            this.X_label.Size = new System.Drawing.Size(38, 40);
            this.X_label.TabIndex = 16;
            this.X_label.Text = "X:";
            this.X_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // Y_label
            // 
            this.Y_label.AutoSize = true;
            this.Y_label.BackColor = System.Drawing.Color.Transparent;
            this.Y_label.Font = new System.Drawing.Font("IRANYekan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Y_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Y_label.Location = new System.Drawing.Point(458, 118);
            this.Y_label.Name = "Y_label";
            this.Y_label.Size = new System.Drawing.Size(37, 40);
            this.Y_label.TabIndex = 17;
            this.Y_label.Text = "Y:";
            // 
            // PROJECTS_label
            // 
            this.PROJECTS_label.AutoSize = true;
            this.PROJECTS_label.BackColor = System.Drawing.Color.Transparent;
            this.PROJECTS_label.Font = new System.Drawing.Font("IRANYekan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PROJECTS_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PROJECTS_label.Location = new System.Drawing.Point(13, 219);
            this.PROJECTS_label.Name = "PROJECTS_label";
            this.PROJECTS_label.Size = new System.Drawing.Size(109, 40);
            this.PROJECTS_label.TabIndex = 18;
            this.PROJECTS_label.Text = "Projects:";
            // 
            // COUNTRY_label
            // 
            this.COUNTRY_label.AutoSize = true;
            this.COUNTRY_label.BackColor = System.Drawing.Color.Transparent;
            this.COUNTRY_label.Font = new System.Drawing.Font("IRANYekan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COUNTRY_label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.COUNTRY_label.Location = new System.Drawing.Point(13, 168);
            this.COUNTRY_label.Name = "COUNTRY_label";
            this.COUNTRY_label.Size = new System.Drawing.Size(104, 40);
            this.COUNTRY_label.TabIndex = 19;
            this.COUNTRY_label.Text = "Country:";
            // 
            // result_group
            // 
            this.result_group.Controls.Add(this.COUNTRY_label);
            this.result_group.Controls.Add(this.PROJECTS_label);
            this.result_group.Controls.Add(this.Y_label);
            this.result_group.Controls.Add(this.X_label);
            this.result_group.Controls.Add(this.FOUNDER_label);
            this.result_group.Controls.Add(this.NAME_label);
            this.result_group.Controls.Add(this.panel1);
            this.result_group.Controls.Add(this.result);
            this.result_group.Controls.Add(this.ID_label);
            this.result_group.Location = new System.Drawing.Point(12, 381);
            this.result_group.Name = "result_group";
            this.result_group.Size = new System.Drawing.Size(887, 270);
            this.result_group.TabIndex = 20;
            this.result_group.TabStop = false;
            this.result_group.Visible = false;
            // 
            // error_group
            // 
            this.error_group.Controls.Add(this.Hor_line2);
            this.error_group.Controls.Add(this.result_label2);
            this.error_group.Controls.Add(this.error_label);
            this.error_group.Location = new System.Drawing.Point(12, 452);
            this.error_group.Name = "error_group";
            this.error_group.Size = new System.Drawing.Size(887, 119);
            this.error_group.TabIndex = 21;
            this.error_group.TabStop = false;
            this.error_group.Visible = false;
            // 
            // Hor_line2
            // 
            this.Hor_line2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Hor_line2.Location = new System.Drawing.Point(0, 52);
            this.Hor_line2.Name = "Hor_line2";
            this.Hor_line2.Size = new System.Drawing.Size(887, 10);
            this.Hor_line2.TabIndex = 5;
            // 
            // result_label2
            // 
            this.result_label2.AutoSize = true;
            this.result_label2.BackColor = System.Drawing.Color.Transparent;
            this.result_label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.result_label2.Location = new System.Drawing.Point(9, 12);
            this.result_label2.Name = "result_label2";
            this.result_label2.Size = new System.Drawing.Size(184, 56);
            this.result_label2.TabIndex = 13;
            this.result_label2.Text = "RESULT";
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.BackColor = System.Drawing.Color.Transparent;
            this.error_label.Font = new System.Drawing.Font("IRANYekan", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(13, 68);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(359, 40);
            this.error_label.TabIndex = 12;
            this.error_label.Text = "ERROR: the inputs aren\'t Number";
            this.error_label.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // GUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 663);
            this.Controls.Add(this.error_group);
            this.Controls.Add(this.result_group);
            this.Controls.Add(this.YBOX);
            this.Controls.Add(this.XBOX);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.Hor_Line);
            this.Controls.Add(this.Title_Panel);
            this.Name = "GUI";
            this.Text = "GETNearestAPP";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.Title_Panel.ResumeLayout(false);
            this.Title_Panel.PerformLayout();
            this.result_group.ResumeLayout(false);
            this.result_group.PerformLayout();
            this.error_group.ResumeLayout(false);
            this.error_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel Title_Panel;
        private System.Windows.Forms.Panel Hor_Line;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox XBOX;
        private System.Windows.Forms.TextBox YBOX;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label NAME_label;
        private System.Windows.Forms.Label FOUNDER_label;
        private System.Windows.Forms.Label X_label;
        private System.Windows.Forms.Label Y_label;
        private System.Windows.Forms.Label PROJECTS_label;
        private System.Windows.Forms.Label COUNTRY_label;
        private System.Windows.Forms.GroupBox result_group;
        private System.Windows.Forms.GroupBox error_group;
        private System.Windows.Forms.Panel Hor_line2;
        private System.Windows.Forms.Label result_label2;
        private System.Windows.Forms.Label error_label;
    }
}

