
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ComboBoxModel = new System.Windows.Forms.ComboBox();
            this.ComboBoxBrand = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.articul_label = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.price_label = new System.Windows.Forms.Label();
            this.brand_label = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.model_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(255)))), ((int)(((byte)(214)))));
            this.mainPanel.Controls.Add(this.ComboBoxModel);
            this.mainPanel.Controls.Add(this.ComboBoxBrand);
            this.mainPanel.Controls.Add(this.groupBox1);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(832, 485);
            this.mainPanel.TabIndex = 1;
            // 
            // ComboBoxModel
            // 
            this.ComboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxModel.FormattingEnabled = true;
            this.ComboBoxModel.Location = new System.Drawing.Point(652, 77);
            this.ComboBoxModel.Name = "ComboBoxModel";
            this.ComboBoxModel.Size = new System.Drawing.Size(150, 24);
            this.ComboBoxModel.TabIndex = 8;
            this.ComboBoxModel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxModel_SelectedValueChanged);
            // 
            // ComboBoxBrand
            // 
            this.ComboBoxBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxBrand.FormattingEnabled = true;
            this.ComboBoxBrand.Location = new System.Drawing.Point(475, 77);
            this.ComboBoxBrand.Name = "ComboBoxBrand";
            this.ComboBoxBrand.Size = new System.Drawing.Size(150, 24);
            this.ComboBoxBrand.TabIndex = 7;
            this.ComboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBrand_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.articul_label);
            this.groupBox1.Controls.Add(this.imageBox);
            this.groupBox1.Controls.Add(this.price_label);
            this.groupBox1.Controls.Add(this.brand_label);
            this.groupBox1.Controls.Add(this.descriptionBox);
            this.groupBox1.Controls.Add(this.model_label);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(3, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 385);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Каталог";
            // 
            // articul_label
            // 
            this.articul_label.AutoSize = true;
            this.articul_label.Location = new System.Drawing.Point(251, 115);
            this.articul_label.Name = "articul_label";
            this.articul_label.Size = new System.Drawing.Size(62, 16);
            this.articul_label.TabIndex = 6;
            this.articul_label.Text = "Артикул";
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Location = new System.Drawing.Point(15, 21);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(227, 217);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 5;
            this.imageBox.TabStop = false;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Location = new System.Drawing.Point(251, 149);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(39, 16);
            this.price_label.TabIndex = 4;
            this.price_label.Text = "цена";
            // 
            // brand_label
            // 
            this.brand_label.AutoSize = true;
            this.brand_label.Location = new System.Drawing.Point(248, 42);
            this.brand_label.Name = "brand_label";
            this.brand_label.Size = new System.Drawing.Size(111, 16);
            this.brand_label.TabIndex = 3;
            this.brand_label.Text = "Производитель";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(15, 244);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(416, 124);
            this.descriptionBox.TabIndex = 2;
            this.descriptionBox.Text = "";
            // 
            // model_label
            // 
            this.model_label.AutoSize = true;
            this.model_label.Location = new System.Drawing.Point(251, 79);
            this.model_label.Name = "model_label";
            this.model_label.Size = new System.Drawing.Size(57, 16);
            this.model_label.TabIndex = 0;
            this.model_label.Text = "Модель";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(832, 55);
            this.topPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главная страница";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 485);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label model_label;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label brand_label;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.ComboBox ComboBoxModel;
        private System.Windows.Forms.ComboBox ComboBoxBrand;
        private System.Windows.Forms.Label articul_label;
    }
}