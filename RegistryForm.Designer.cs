
namespace CourseWork_TP_2023
{
    partial class RegistryForm
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
            this.hide_btn = new System.Windows.Forms.PictureBox();
            this.linkSignIn = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.name2nd = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.name1st = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.confirmField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(255)))), ((int)(((byte)(214)))));
            this.mainPanel.Controls.Add(this.hide_btn);
            this.mainPanel.Controls.Add(this.linkSignIn);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.name2nd);
            this.mainPanel.Controls.Add(this.passField);
            this.mainPanel.Controls.Add(this.name1st);
            this.mainPanel.Controls.Add(this.buttonRegister);
            this.mainPanel.Controls.Add(this.confirmField);
            this.mainPanel.Controls.Add(this.pictureBox2);
            this.mainPanel.Controls.Add(this.userNameField);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(419, 657);
            this.mainPanel.TabIndex = 1;
            // 
            // hide_btn
            // 
            this.hide_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hide_btn.BackgroundImage = global::CourseWork_TP_2023.Properties.Resources.non_visible;
            this.hide_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hide_btn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hide_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hide_btn.Location = new System.Drawing.Point(279, 344);
            this.hide_btn.Name = "hide_btn";
            this.hide_btn.Size = new System.Drawing.Size(43, 35);
            this.hide_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hide_btn.TabIndex = 10;
            this.hide_btn.TabStop = false;
            this.hide_btn.Click += new System.EventHandler(this.hide_btn_Click);
            // 
            // linkSignIn
            // 
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkSignIn.Location = new System.Drawing.Point(231, 631);
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.Size = new System.Drawing.Size(108, 16);
            this.linkSignIn.TabIndex = 9;
            this.linkSignIn.TabStop = true;
            this.linkSignIn.Text = "Авторизуйтесь";
            this.linkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignIn_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 631);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Уже есть аккаунт?";
            // 
            // name2nd
            // 
            this.name2nd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name2nd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name2nd.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name2nd.ForeColor = System.Drawing.Color.Gray;
            this.name2nd.Location = new System.Drawing.Point(105, 267);
            this.name2nd.Name = "name2nd";
            this.name2nd.Size = new System.Drawing.Size(217, 35);
            this.name2nd.TabIndex = 4;
            this.name2nd.Text = "Введите фамилию";
            this.name2nd.Enter += new System.EventHandler(this.name2nd_Enter);
            this.name2nd.Leave += new System.EventHandler(this.name2nd_Leave);
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passField.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.ForeColor = System.Drawing.Color.Gray;
            this.passField.Location = new System.Drawing.Point(105, 344);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(178, 35);
            this.passField.TabIndex = 5;
            this.passField.Text = "Придумайте пароль";
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // name1st
            // 
            this.name1st.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.name1st.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name1st.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name1st.ForeColor = System.Drawing.Color.Gray;
            this.name1st.Location = new System.Drawing.Point(105, 194);
            this.name1st.Name = "name1st";
            this.name1st.Size = new System.Drawing.Size(217, 35);
            this.name1st.TabIndex = 3;
            this.name1st.Text = "Введите имя";
            this.name1st.Enter += new System.EventHandler(this.name1st_Enter);
            this.name1st.Leave += new System.EventHandler(this.name1st_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.AutoSize = true;
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.Color.White;
            this.buttonRegister.Location = new System.Drawing.Point(3, 587);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(419, 41);
            this.buttonRegister.TabIndex = 7;
            this.buttonRegister.Text = "Зарегистрироваться";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // confirmField
            // 
            this.confirmField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.confirmField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmField.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmField.ForeColor = System.Drawing.Color.Gray;
            this.confirmField.Location = new System.Drawing.Point(105, 413);
            this.confirmField.Name = "confirmField";
            this.confirmField.Size = new System.Drawing.Size(217, 35);
            this.confirmField.TabIndex = 6;
            this.confirmField.Text = "Подтвердите пароль";
            this.confirmField.Enter += new System.EventHandler(this.confirmField_Enter);
            this.confirmField.Leave += new System.EventHandler(this.confirmField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CourseWork_TP_2023.Properties.Resources._299105_lock_icon;
            this.pictureBox2.Location = new System.Drawing.Point(33, 344);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // userNameField
            // 
            this.userNameField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameField.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameField.ForeColor = System.Drawing.Color.Gray;
            this.userNameField.Location = new System.Drawing.Point(105, 126);
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(217, 35);
            this.userNameField.TabIndex = 2;
            this.userNameField.Text = "Логин";
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork_TP_2023.Properties.Resources._403019_avatar_male_man_person_user_icon;
            this.pictureBox1.Location = new System.Drawing.Point(33, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(419, 100);
            this.topPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(766, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(22, 25);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "x";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "РЕГИСТРАЦИЯ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(419, 657);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistryForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hide_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox confirmField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.TextBox name1st;
        private System.Windows.Forms.TextBox name2nd;
        private System.Windows.Forms.LinkLabel linkSignIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox hide_btn;
    }
}