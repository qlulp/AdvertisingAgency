namespace AdvertisingAgency
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.ServicesButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.CooperatorsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(282, 52);
            this.label.TabIndex = 0;
            this.label.Text = "Рекламное Агентство";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OrdersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersButton.Location = new System.Drawing.Point(13, 65);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(135, 91);
            this.OrdersButton.TabIndex = 1;
            this.OrdersButton.TabStop = false;
            this.OrdersButton.Text = "Заказы";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // ServicesButton
            // 
            this.ServicesButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServicesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServicesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServicesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ServicesButton.Location = new System.Drawing.Point(159, 65);
            this.ServicesButton.Name = "ServicesButton";
            this.ServicesButton.Size = new System.Drawing.Size(135, 91);
            this.ServicesButton.TabIndex = 2;
            this.ServicesButton.TabStop = false;
            this.ServicesButton.Text = "Услуги";
            this.ServicesButton.UseVisualStyleBackColor = true;
            this.ServicesButton.Click += new System.EventHandler(this.ServicesButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientsButton.Location = new System.Drawing.Point(159, 161);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(135, 91);
            this.ClientsButton.TabIndex = 4;
            this.ClientsButton.TabStop = false;
            this.ClientsButton.Text = "Клиенты";
            this.ClientsButton.UseVisualStyleBackColor = true;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // CooperatorsButton
            // 
            this.CooperatorsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CooperatorsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CooperatorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CooperatorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CooperatorsButton.Location = new System.Drawing.Point(13, 162);
            this.CooperatorsButton.Name = "CooperatorsButton";
            this.CooperatorsButton.Size = new System.Drawing.Size(135, 91);
            this.CooperatorsButton.TabIndex = 3;
            this.CooperatorsButton.TabStop = false;
            this.CooperatorsButton.Text = "Сотрудники";
            this.CooperatorsButton.UseVisualStyleBackColor = true;
            this.CooperatorsButton.Click += new System.EventHandler(this.CooperatorsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(306, 269);
            this.Controls.Add(this.ClientsButton);
            this.Controls.Add(this.CooperatorsButton);
            this.Controls.Add(this.ServicesButton);
            this.Controls.Add(this.OrdersButton);
            this.Controls.Add(this.label);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Рекламное агентство";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button ServicesButton;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button CooperatorsButton;
    }
}

