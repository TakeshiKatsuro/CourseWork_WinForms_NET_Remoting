
namespace CourseWork_TP_2023
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ComboBoxModel = new System.Windows.Forms.ComboBox();
            this.ComboBoxBrand = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.articul_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.brand_label = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.model_label = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(255)))), ((int)(((byte)(214)))));
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.ComboBoxModel);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Controls.Add(this.ComboBoxBrand);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(832, 485);
            this.mainPanel.TabIndex = 1;
            // 
            // ComboBoxModel
            // 
            this.ComboBoxModel.BackColor = System.Drawing.Color.Azure;
            this.ComboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxModel.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 8F);
            this.ComboBoxModel.FormattingEnabled = true;
            this.ComboBoxModel.Location = new System.Drawing.Point(658, 72);
            this.ComboBoxModel.Name = "ComboBoxModel";
            this.ComboBoxModel.Size = new System.Drawing.Size(150, 24);
            this.ComboBoxModel.TabIndex = 8;
            this.ComboBoxModel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxModel_SelectedValueChanged);
            // 
            // ComboBoxBrand
            // 
            this.ComboBoxBrand.BackColor = System.Drawing.Color.Azure;
            this.ComboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBrand.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 8F);
            this.ComboBoxBrand.FormattingEnabled = true;
            this.ComboBoxBrand.Location = new System.Drawing.Point(447, 72);
            this.ComboBoxBrand.Name = "ComboBoxBrand";
            this.ComboBoxBrand.Size = new System.Drawing.Size(150, 24);
            this.ComboBoxBrand.TabIndex = 7;
            this.ComboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBrand_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.articul_label);
            this.groupBox1.Controls.Add(this.imageBox);
            this.groupBox1.Controls.Add(this.price_label);
            this.groupBox1.Controls.Add(this.brand_label);
            this.groupBox1.Controls.Add(this.descriptionBox);
            this.groupBox1.Controls.Add(this.model_label);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 357);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // articul_label
            // 
            this.articul_label.AutoSize = true;
            this.articul_label.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F);
            this.articul_label.Location = new System.Drawing.Point(215, 94);
            this.articul_label.Name = "articul_label";
            this.articul_label.Size = new System.Drawing.Size(79, 24);
            this.articul_label.TabIndex = 6;
            this.articul_label.Text = "Артикул:";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F);
            this.price_label.Location = new System.Drawing.Point(215, 128);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(54, 24);
            this.price_label.TabIndex = 4;
            this.price_label.Text = "Цена:";
            // 
            // brand_label
            // 
            this.brand_label.AutoSize = true;
            this.brand_label.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F);
            this.brand_label.Location = new System.Drawing.Point(212, 21);
            this.brand_label.Name = "brand_label";
            this.brand_label.Size = new System.Drawing.Size(134, 24);
            this.brand_label.TabIndex = 3;
            this.brand_label.Text = "Производитель:";
            // 
            // descriptionBox
            // 
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionBox.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F);
            this.descriptionBox.Location = new System.Drawing.Point(216, 165);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(546, 169);
            this.descriptionBox.TabIndex = 2;
            this.descriptionBox.Text = "";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F);
            this.model_label.Location = new System.Drawing.Point(215, 58);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(75, 24);
            this.model_label.TabIndex = 0;
            this.model_label.Text = "Модель:";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topPanel.Controls.Add(this.pictureBox2);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(832, 69);
            this.topPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "GuitarStore";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(255)))), ((int)(((byte)(214)))));
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.label2.Location = new System.Drawing.Point(392, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Brand";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(255)))), ((int)(((byte)(214)))));
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 10F);
            this.label3.Location = new System.Drawing.Point(603, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(255)))), ((int)(((byte)(214)))));
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F);
            this.label4.Location = new System.Drawing.Point(304, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "SEARCH: ";
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Location = new System.Drawing.Point(19, 21);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(174, 313);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 5;
            this.imageBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CourseWork_TP_2023.Properties.Resources._4831032_door_entrance_exit_leave_logout_icon;
            this.pictureBox2.Location = new System.Drawing.Point(736, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 485);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "GuitarStore";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label brand_label;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.ComboBox ComboBoxModel;
        private System.Windows.Forms.ComboBox ComboBoxBrand;
        private System.Windows.Forms.Label articul_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}