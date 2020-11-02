namespace AdvertisingAgency.Forms.Tables
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.DocumentPrinter = new System.Drawing.Printing.PrintDocument();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.CooperatorCodeTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ClientCodeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.SearchByOrderCodeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdersTable = new System.Windows.Forms.DataGridView();
            this.SortButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.SortByDateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByServiceNameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TableTools = new System.Windows.Forms.ToolStrip();
            this.FilterButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ShowDoneOrderssButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DoneCheckBox = new System.Windows.Forms.CheckBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTable)).BeginInit();
            this.TableTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocumentPrinter
            // 
            this.DocumentPrinter.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DocumentPrinter_PrintPage);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(921, 265);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(67, 23);
            this.SearchButton.TabIndex = 51;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchNameTextBox.Enabled = false;
            this.SearchNameTextBox.Location = new System.Drawing.Point(802, 265);
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.Size = new System.Drawing.Size(113, 20);
            this.SearchNameTextBox.TabIndex = 50;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(802, 378);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(186, 23);
            this.DeleteButton.TabIndex = 49;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(802, 349);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(186, 23);
            this.EditButton.TabIndex = 48;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Location = new System.Drawing.Point(802, 320);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(186, 23);
            this.UpdateButton.TabIndex = 47;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewButton.Location = new System.Drawing.Point(802, 291);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(186, 23);
            this.AddNewButton.TabIndex = 46;
            this.AddNewButton.Text = "Добавить";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // CooperatorCodeTextBox
            // 
            this.CooperatorCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CooperatorCodeTextBox.Location = new System.Drawing.Point(854, 135);
            this.CooperatorCodeTextBox.Name = "CooperatorCodeTextBox";
            this.CooperatorCodeTextBox.Size = new System.Drawing.Size(186, 20);
            this.CooperatorCodeTextBox.TabIndex = 45;
            this.CooperatorCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CooperatorCodeTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(738, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Код сотрудника";
            // 
            // ClientCodeTextBox
            // 
            this.ClientCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientCodeTextBox.Location = new System.Drawing.Point(854, 109);
            this.ClientCodeTextBox.Name = "ClientCodeTextBox";
            this.ClientCodeTextBox.Size = new System.Drawing.Size(186, 20);
            this.ClientCodeTextBox.TabIndex = 43;
            this.ClientCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientCodeTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(738, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Код клиента";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Выполнено";
            // 
            // PrintButton
            // 
            this.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PrintButton.Image = ((System.Drawing.Image)(resources.GetObject("PrintButton.Image")));
            this.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(50, 22);
            this.PrintButton.Text = "Печать";
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchByOrderCodeButton});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(55, 22);
            this.toolStripDropDownButton1.Text = "Поиск";
            // 
            // SearchByOrderCodeButton
            // 
            this.SearchByOrderCodeButton.Name = "SearchByOrderCodeButton";
            this.SearchByOrderCodeButton.Size = new System.Drawing.Size(208, 22);
            this.SearchByOrderCodeButton.Text = "Поиск по номеру заказа";
            this.SearchByOrderCodeButton.Click += new System.EventHandler(this.SearchByOrderCodeButton_Click);
            // 
            // ServiceNameTextBox
            // 
            this.ServiceNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceNameTextBox.Location = new System.Drawing.Point(854, 83);
            this.ServiceNameTextBox.Name = "ServiceNameTextBox";
            this.ServiceNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.ServiceNameTextBox.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(739, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Название услуги";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(738, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Дата";
            // 
            // OrderCodeTextBox
            // 
            this.OrderCodeTextBox.AcceptsReturn = true;
            this.OrderCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderCodeTextBox.Location = new System.Drawing.Point(854, 31);
            this.OrderCodeTextBox.Name = "OrderCodeTextBox";
            this.OrderCodeTextBox.Size = new System.Drawing.Size(186, 20);
            this.OrderCodeTextBox.TabIndex = 35;
            this.OrderCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OrderCodeTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "НомерЗаказа";
            // 
            // OrdersTable
            // 
            this.OrdersTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrdersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrdersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersTable.Location = new System.Drawing.Point(12, 28);
            this.OrdersTable.Name = "OrdersTable";
            this.OrdersTable.Size = new System.Drawing.Size(715, 410);
            this.OrdersTable.TabIndex = 33;
            this.OrdersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersTable_CellClick);
            // 
            // SortButton
            // 
            this.SortButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SortButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortByDateButton,
            this.SortByServiceNameButton});
            this.SortButton.Image = ((System.Drawing.Image)(resources.GetObject("SortButton.Image")));
            this.SortButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(86, 22);
            this.SortButton.Text = "Сортировка";
            // 
            // SortByDateButton
            // 
            this.SortByDateButton.Name = "SortByDateButton";
            this.SortByDateButton.Size = new System.Drawing.Size(147, 22);
            this.SortByDateButton.Text = "По дате";
            this.SortByDateButton.Click += new System.EventHandler(this.SortByDateButton_Click);
            // 
            // SortByServiceNameButton
            // 
            this.SortByServiceNameButton.Name = "SortByServiceNameButton";
            this.SortByServiceNameButton.Size = new System.Drawing.Size(147, 22);
            this.SortByServiceNameButton.Text = "По названию";
            this.SortByServiceNameButton.Click += new System.EventHandler(this.SortByServiceNameButton_Click);
            // 
            // TableTools
            // 
            this.TableTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintButton,
            this.toolStripDropDownButton1,
            this.SortButton,
            this.FilterButton});
            this.TableTools.Location = new System.Drawing.Point(0, 0);
            this.TableTools.Name = "TableTools";
            this.TableTools.Size = new System.Drawing.Size(1048, 25);
            this.TableTools.TabIndex = 32;
            this.TableTools.Text = "toolStrip1";
            // 
            // FilterButton
            // 
            this.FilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FilterButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowDoneOrderssButton});
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(87, 22);
            this.FilterButton.Text = "Фильтрация";
            // 
            // ShowDoneOrderssButton
            // 
            this.ShowDoneOrderssButton.Name = "ShowDoneOrderssButton";
            this.ShowDoneOrderssButton.Size = new System.Drawing.Size(193, 22);
            this.ShowDoneOrderssButton.Text = "Выполненные заказы";
            this.ShowDoneOrderssButton.Click += new System.EventHandler(this.ShowDoneOrderssButton_Click);
            // 
            // DoneCheckBox
            // 
            this.DoneCheckBox.AutoSize = true;
            this.DoneCheckBox.Location = new System.Drawing.Point(854, 164);
            this.DoneCheckBox.Name = "DoneCheckBox";
            this.DoneCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DoneCheckBox.TabIndex = 52;
            this.DoneCheckBox.UseVisualStyleBackColor = true;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker.Location = new System.Drawing.Point(854, 57);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.DateTimePicker.TabIndex = 53;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.DoneCheckBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchNameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.CooperatorCodeTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClientCodeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ServiceNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OrderCodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdersTable);
            this.Controls.Add(this.TableTools);
            this.Name = "OrdersForm";
            this.Text = "Рекламное Агентство: таблица Заказы";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersTable)).EndInit();
            this.TableTools.ResumeLayout(false);
            this.TableTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument DocumentPrinter;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchNameTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.TextBox CooperatorCodeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ClientCodeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem SearchByOrderCodeButton;
        private System.Windows.Forms.TextBox ServiceNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrderCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OrdersTable;
        private System.Windows.Forms.ToolStripDropDownButton SortButton;
        private System.Windows.Forms.ToolStripMenuItem SortByDateButton;
        private System.Windows.Forms.ToolStripMenuItem SortByServiceNameButton;
        private System.Windows.Forms.ToolStrip TableTools;
        private System.Windows.Forms.ToolStripDropDownButton FilterButton;
        private System.Windows.Forms.ToolStripMenuItem ShowDoneOrderssButton;
        private System.Windows.Forms.CheckBox DoneCheckBox;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
    }
}