namespace DClient
{
    partial class FormMain
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
            this.tabControlWindows = new System.Windows.Forms.TabControl();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.buttonChangeProfile = new System.Windows.Forms.Button();
            this.textBoxCustomerPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPasswordR = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdres1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdres2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCurentOrder = new System.Windows.Forms.TabPage();
            this.textBoxPayMethod = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.buttonRefuse = new System.Windows.Forms.Button();
            this.buttonGetPhone = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.comboBoxPayMethod = new System.Windows.Forms.ComboBox();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.textBoxNumberCard = new System.Windows.Forms.TextBox();
            this.textBoxAdres2 = new System.Windows.Forms.TextBox();
            this.textBoxAdres1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlWindows.SuspendLayout();
            this.tabPageProfile.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.tabPageCurentOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlWindows
            // 
            this.tabControlWindows.Controls.Add(this.tabPageProfile);
            this.tabControlWindows.Controls.Add(this.tabPageOrders);
            this.tabControlWindows.Controls.Add(this.tabPageCurentOrder);
            this.tabControlWindows.Location = new System.Drawing.Point(2, 3);
            this.tabControlWindows.Name = "tabControlWindows";
            this.tabControlWindows.SelectedIndex = 0;
            this.tabControlWindows.Size = new System.Drawing.Size(672, 471);
            this.tabControlWindows.TabIndex = 0;
            this.tabControlWindows.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControlWindows_Selecting);
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Controls.Add(this.buttonChangeProfile);
            this.tabPageProfile.Controls.Add(this.textBoxCustomerPhone);
            this.tabPageProfile.Controls.Add(this.label7);
            this.tabPageProfile.Controls.Add(this.textBoxPasswordR);
            this.tabPageProfile.Controls.Add(this.textBoxPassword);
            this.tabPageProfile.Controls.Add(this.textBoxLogin);
            this.tabPageProfile.Controls.Add(this.textBoxLName);
            this.tabPageProfile.Controls.Add(this.textBoxFName);
            this.tabPageProfile.Controls.Add(this.label6);
            this.tabPageProfile.Controls.Add(this.label8);
            this.tabPageProfile.Controls.Add(this.label9);
            this.tabPageProfile.Controls.Add(this.label10);
            this.tabPageProfile.Controls.Add(this.label11);
            this.tabPageProfile.Location = new System.Drawing.Point(4, 29);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Size = new System.Drawing.Size(664, 438);
            this.tabPageProfile.TabIndex = 2;
            this.tabPageProfile.Text = "Профиль";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // buttonChangeProfile
            // 
            this.buttonChangeProfile.Location = new System.Drawing.Point(216, 334);
            this.buttonChangeProfile.Name = "buttonChangeProfile";
            this.buttonChangeProfile.Size = new System.Drawing.Size(149, 31);
            this.buttonChangeProfile.TabIndex = 27;
            this.buttonChangeProfile.Text = "Сохранить";
            this.buttonChangeProfile.UseVisualStyleBackColor = true;
            this.buttonChangeProfile.Click += new System.EventHandler(this.buttonChangeProfile_Click);
            // 
            // textBoxCustomerPhone
            // 
            this.textBoxCustomerPhone.Location = new System.Drawing.Point(310, 154);
            this.textBoxCustomerPhone.MaxLength = 11;
            this.textBoxCustomerPhone.Name = "textBoxCustomerPhone";
            this.textBoxCustomerPhone.Size = new System.Drawing.Size(204, 26);
            this.textBoxCustomerPhone.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Телефон";
            // 
            // textBoxPasswordR
            // 
            this.textBoxPasswordR.Location = new System.Drawing.Point(309, 285);
            this.textBoxPasswordR.MaxLength = 10;
            this.textBoxPasswordR.Name = "textBoxPasswordR";
            this.textBoxPasswordR.PasswordChar = '*';
            this.textBoxPasswordR.Size = new System.Drawing.Size(205, 26);
            this.textBoxPasswordR.TabIndex = 24;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(309, 241);
            this.textBoxPassword.MaxLength = 10;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(205, 26);
            this.textBoxPassword.TabIndex = 23;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(309, 198);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(205, 26);
            this.textBoxLogin.TabIndex = 22;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(310, 112);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(205, 26);
            this.textBoxLName.TabIndex = 21;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(311, 76);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(204, 26);
            this.textBoxFName.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Повтор пароля";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Пароль";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Логин";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(171, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Фамилия";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Имя";
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.dataGridViewOrders);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(664, 438);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Мои заказы";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnData,
            this.ColumnAdres1,
            this.ColumnAdres2,
            this.ColumnStatus});
            this.dataGridViewOrders.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowTemplate.Height = 28;
            this.dataGridViewOrders.Size = new System.Drawing.Size(655, 426);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // ColumnData
            // 
            this.ColumnData.HeaderText = "Время заказа";
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            // 
            // ColumnAdres1
            // 
            this.ColumnAdres1.HeaderText = "Начальный адрес";
            this.ColumnAdres1.Name = "ColumnAdres1";
            this.ColumnAdres1.ReadOnly = true;
            // 
            // ColumnAdres2
            // 
            this.ColumnAdres2.HeaderText = "Конечный адрес";
            this.ColumnAdres2.Name = "ColumnAdres2";
            this.ColumnAdres2.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Статус";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            // 
            // tabPageCurentOrder
            // 
            this.tabPageCurentOrder.Controls.Add(this.textBoxPayMethod);
            this.tabPageCurentOrder.Controls.Add(this.textBoxClass);
            this.tabPageCurentOrder.Controls.Add(this.buttonRefuse);
            this.tabPageCurentOrder.Controls.Add(this.buttonGetPhone);
            this.tabPageCurentOrder.Controls.Add(this.textBoxPhone);
            this.tabPageCurentOrder.Controls.Add(this.textBoxStatus);
            this.tabPageCurentOrder.Controls.Add(this.labelStatus);
            this.tabPageCurentOrder.Controls.Add(this.buttonOrder);
            this.tabPageCurentOrder.Controls.Add(this.comboBoxPayMethod);
            this.tabPageCurentOrder.Controls.Add(this.comboBoxClass);
            this.tabPageCurentOrder.Controls.Add(this.textBoxNumberCard);
            this.tabPageCurentOrder.Controls.Add(this.textBoxAdres2);
            this.tabPageCurentOrder.Controls.Add(this.textBoxAdres1);
            this.tabPageCurentOrder.Controls.Add(this.label5);
            this.tabPageCurentOrder.Controls.Add(this.label4);
            this.tabPageCurentOrder.Controls.Add(this.label3);
            this.tabPageCurentOrder.Controls.Add(this.label2);
            this.tabPageCurentOrder.Controls.Add(this.label1);
            this.tabPageCurentOrder.Location = new System.Drawing.Point(4, 29);
            this.tabPageCurentOrder.Name = "tabPageCurentOrder";
            this.tabPageCurentOrder.Size = new System.Drawing.Size(664, 438);
            this.tabPageCurentOrder.TabIndex = 3;
            this.tabPageCurentOrder.Text = "Оформить заказ";
            this.tabPageCurentOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxPayMethod
            // 
            this.textBoxPayMethod.Location = new System.Drawing.Point(196, 178);
            this.textBoxPayMethod.Name = "textBoxPayMethod";
            this.textBoxPayMethod.Size = new System.Drawing.Size(340, 26);
            this.textBoxPayMethod.TabIndex = 17;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(196, 130);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(340, 26);
            this.textBoxClass.TabIndex = 16;
            // 
            // buttonRefuse
            // 
            this.buttonRefuse.Location = new System.Drawing.Point(6, 372);
            this.buttonRefuse.Name = "buttonRefuse";
            this.buttonRefuse.Size = new System.Drawing.Size(166, 48);
            this.buttonRefuse.TabIndex = 15;
            this.buttonRefuse.Text = "Отказаться\r\nот заказа";
            this.buttonRefuse.UseVisualStyleBackColor = true;
            this.buttonRefuse.Click += new System.EventHandler(this.buttonRefuse_Click);
            // 
            // buttonGetPhone
            // 
            this.buttonGetPhone.Location = new System.Drawing.Point(6, 318);
            this.buttonGetPhone.Name = "buttonGetPhone";
            this.buttonGetPhone.Size = new System.Drawing.Size(166, 48);
            this.buttonGetPhone.TabIndex = 14;
            this.buttonGetPhone.Text = "Связаться \r\nс водителем";
            this.buttonGetPhone.UseVisualStyleBackColor = true;
            this.buttonGetPhone.Click += new System.EventHandler(this.buttonGetPhone_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(196, 329);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(340, 26);
            this.textBoxPhone.TabIndex = 13;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(196, 271);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(340, 26);
            this.textBoxStatus.TabIndex = 12;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(55, 274);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(117, 20);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Статус заказа";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(120, 274);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(117, 52);
            this.buttonOrder.TabIndex = 10;
            this.buttonOrder.Text = "Заказать\r\nтакси";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // comboBoxPayMethod
            // 
            this.comboBoxPayMethod.FormattingEnabled = true;
            this.comboBoxPayMethod.Location = new System.Drawing.Point(196, 177);
            this.comboBoxPayMethod.Name = "comboBoxPayMethod";
            this.comboBoxPayMethod.Size = new System.Drawing.Size(340, 28);
            this.comboBoxPayMethod.TabIndex = 9;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(196, 130);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(340, 28);
            this.comboBoxClass.TabIndex = 8;
            // 
            // textBoxNumberCard
            // 
            this.textBoxNumberCard.Location = new System.Drawing.Point(196, 226);
            this.textBoxNumberCard.Name = "textBoxNumberCard";
            this.textBoxNumberCard.Size = new System.Drawing.Size(340, 26);
            this.textBoxNumberCard.TabIndex = 7;
            // 
            // textBoxAdres2
            // 
            this.textBoxAdres2.Location = new System.Drawing.Point(196, 79);
            this.textBoxAdres2.Name = "textBoxAdres2";
            this.textBoxAdres2.Size = new System.Drawing.Size(340, 26);
            this.textBoxAdres2.TabIndex = 6;
            // 
            // textBoxAdres1
            // 
            this.textBoxAdres1.Location = new System.Drawing.Point(196, 33);
            this.textBoxAdres1.Name = "textBoxAdres1";
            this.textBoxAdres1.Size = new System.Drawing.Size(340, 26);
            this.textBoxAdres1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Номер карты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Способ оплаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Класс автомобиля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Конечный адрес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальный адрес";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 479);
            this.Controls.Add(this.tabControlWindows);
            this.Name = "FormMain";
            this.Text = "formMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlWindows.ResumeLayout(false);
            this.tabPageProfile.ResumeLayout(false);
            this.tabPageProfile.PerformLayout();
            this.tabPageOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.tabPageCurentOrder.ResumeLayout(false);
            this.tabPageCurentOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlWindows;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.TabPage tabPageCurentOrder;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.ComboBox comboBoxPayMethod;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.TextBox textBoxNumberCard;
        private System.Windows.Forms.TextBox textBoxAdres2;
        private System.Windows.Forms.TextBox textBoxAdres1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonGetPhone;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonRefuse;
        private System.Windows.Forms.TextBox textBoxPayMethod;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdres1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdres2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.Button buttonChangeProfile;
        private System.Windows.Forms.TextBox textBoxCustomerPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPasswordR;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}