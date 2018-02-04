namespace DClient
{
    partial class formMain
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
            this.tabPageCurrentOrder = new System.Windows.Forms.TabPage();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonCurrent = new System.Windows.Forms.Button();
            this.tabControlWindows.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlWindows
            // 
            this.tabControlWindows.Controls.Add(this.tabPageCurrentOrder);
            this.tabControlWindows.Controls.Add(this.tabPageOrders);
            this.tabControlWindows.Controls.Add(this.tabPageProfile);
            this.tabControlWindows.Location = new System.Drawing.Point(8, 44);
            this.tabControlWindows.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlWindows.Name = "tabControlWindows";
            this.tabControlWindows.SelectedIndex = 0;
            this.tabControlWindows.Size = new System.Drawing.Size(448, 306);
            this.tabControlWindows.TabIndex = 0;
            // 
            // tabPageCurrentOrder
            // 
            this.tabPageCurrentOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPageCurrentOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageCurrentOrder.Name = "tabPageCurrentOrder";
            this.tabPageCurrentOrder.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageCurrentOrder.Size = new System.Drawing.Size(440, 280);
            this.tabPageCurrentOrder.TabIndex = 0;
            this.tabPageCurrentOrder.Text = "CurrentOrder";
            this.tabPageCurrentOrder.UseVisualStyleBackColor = true;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageOrders.Size = new System.Drawing.Size(440, 280);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Orders";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Size = new System.Drawing.Size(440, 280);
            this.tabPageProfile.TabIndex = 2;
            this.tabPageProfile.Text = "Profile";
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Location = new System.Drawing.Point(8, 8);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(75, 19);
            this.buttonProfile.TabIndex = 1;
            this.buttonProfile.Text = "Профиль";
            this.buttonProfile.UseVisualStyleBackColor = true;
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(87, 8);
            this.buttonOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(78, 19);
            this.buttonOrders.TabIndex = 2;
            this.buttonOrders.Text = "Мои заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            // 
            // buttonCurrent
            // 
            this.buttonCurrent.Location = new System.Drawing.Point(169, 8);
            this.buttonCurrent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCurrent.Name = "buttonCurrent";
            this.buttonCurrent.Size = new System.Drawing.Size(91, 19);
            this.buttonCurrent.TabIndex = 3;
            this.buttonCurrent.Text = "Текущий заказ";
            this.buttonCurrent.UseVisualStyleBackColor = true;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 357);
            this.Controls.Add(this.buttonCurrent);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.tabControlWindows);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formMain";
            this.Text = "formMain";
            this.tabControlWindows.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlWindows;
        private System.Windows.Forms.TabPage tabPageCurrentOrder;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonCurrent;
    }
}