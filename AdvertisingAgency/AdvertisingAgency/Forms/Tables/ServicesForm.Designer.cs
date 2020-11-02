namespace AdvertisingAgency.Forms.Tables
{
    partial class ServicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServicesForm));
            this.PriceMoreThan5000Button = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.TableTools = new System.Windows.Forms.ToolStrip();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.SearchByServiceNameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.SortByPriceButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByServiceNameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ServicesTable = new System.Windows.Forms.DataGridView();
            this.DocumentPrinter = new System.Drawing.Printing.PrintDocument();
            this.label5 = new System.Windows.Forms.Label();
            this.ServicePriceTextBox = new System.Windows.Forms.TextBox();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ServiceNameTextBox = new System.Windows.Forms.TextBox();
            this.PriceLessThan5000Button = new System.Windows.Forms.ToolStripMenuItem();
            this.TableTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceMoreThan5000Button
            // 
            this.PriceMoreThan5000Button.Name = "PriceMoreThan5000Button";
            this.PriceMoreThan5000Button.Size = new System.Drawing.Size(203, 22);
            this.PriceMoreThan5000Button.Text = "Стоимость выше 5000р";
            this.PriceMoreThan5000Button.Click += new System.EventHandler(this.PriceMoreThan5000Button_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FilterButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PriceMoreThan5000Button,
            this.PriceLessThan5000Button});
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(87, 22);
            this.FilterButton.Text = "Фильтрация";
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
            this.TableTools.Size = new System.Drawing.Size(660, 25);
            this.TableTools.TabIndex = 54;
            this.TableTools.Text = "toolStrip1";
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
            this.SearchByServiceNameButton});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(55, 22);
            this.toolStripDropDownButton1.Text = "Поиск";
            // 
            // SearchByServiceNameButton
            // 
            this.SearchByServiceNameButton.Name = "SearchByServiceNameButton";
            this.SearchByServiceNameButton.Size = new System.Drawing.Size(208, 22);
            this.SearchByServiceNameButton.Text = "Поиск по номеру заказа";
            this.SearchByServiceNameButton.Click += new System.EventHandler(this.SearchByServiceNameButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SortButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortByPriceButton,
            this.SortByServiceNameButton});
            this.SortButton.Image = ((System.Drawing.Image)(resources.GetObject("SortButton.Image")));
            this.SortButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(86, 22);
            this.SortButton.Text = "Сортировка";
            // 
            // SortByPriceButton
            // 
            this.SortByPriceButton.Name = "SortByPriceButton";
            this.SortByPriceButton.Size = new System.Drawing.Size(192, 22);
            this.SortByPriceButton.Text = "По стоимости услуги";
            this.SortByPriceButton.Click += new System.EventHandler(this.SortByPriceButton_Click);
            // 
            // SortByServiceNameButton
            // 
            this.SortByServiceNameButton.Name = "SortByServiceNameButton";
            this.SortByServiceNameButton.Size = new System.Drawing.Size(192, 22);
            this.SortByServiceNameButton.Text = "По названию услуги";
            this.SortByServiceNameButton.Click += new System.EventHandler(this.SortByServiceNameButton_Click);
            // 
            // ServicesTable
            // 
            this.ServicesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ServicesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServicesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicesTable.Location = new System.Drawing.Point(12, 28);
            this.ServicesTable.Name = "ServicesTable";
            this.ServicesTable.Size = new System.Drawing.Size(324, 410);
            this.ServicesTable.TabIndex = 55;
            this.ServicesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServicesTable_CellClick);
            // 
            // DocumentPrinter
            // 
            this.DocumentPrinter.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DocumentPrinter_PrintPage);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Стоимость";
            // 
            // ServicePriceTextBox
            // 
            this.ServicePriceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicePriceTextBox.Location = new System.Drawing.Point(463, 54);
            this.ServicePriceTextBox.Name = "ServicePriceTextBox";
            this.ServicePriceTextBox.Size = new System.Drawing.Size(186, 20);
            this.ServicePriceTextBox.TabIndex = 63;
            this.ServicePriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServicePriceTextBox_KeyPress);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewButton.Location = new System.Drawing.Point(397, 291);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(186, 23);
            this.AddNewButton.TabIndex = 66;
            this.AddNewButton.Text = "Добавить";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Location = new System.Drawing.Point(397, 320);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(186, 23);
            this.UpdateButton.TabIndex = 67;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(397, 349);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(186, 23);
            this.EditButton.TabIndex = 68;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(397, 378);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(186, 23);
            this.DeleteButton.TabIndex = 69;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchNameTextBox.Enabled = false;
            this.SearchNameTextBox.Location = new System.Drawing.Point(397, 265);
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.Size = new System.Drawing.Size(113, 20);
            this.SearchNameTextBox.TabIndex = 70;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(516, 265);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(67, 23);
            this.SearchButton.TabIndex = 71;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Название услуги";
            // 
            // ServiceNameTextBox
            // 
            this.ServiceNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceNameTextBox.Location = new System.Drawing.Point(462, 28);
            this.ServiceNameTextBox.Name = "ServiceNameTextBox";
            this.ServiceNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.ServiceNameTextBox.TabIndex = 61;
            // 
            // PriceLessThan5000Button
            // 
            this.PriceLessThan5000Button.Name = "PriceLessThan5000Button";
            this.PriceLessThan5000Button.Size = new System.Drawing.Size(203, 22);
            this.PriceLessThan5000Button.Text = "Стоимость ниже 5000р";
            this.PriceLessThan5000Button.Click += new System.EventHandler(this.PriceLessThan5000Button_Click);
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.TableTools);
            this.Controls.Add(this.ServiceNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ServicesTable);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchNameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.ServicePriceTextBox);
            this.Controls.Add(this.label5);
            this.Name = "ServicesForm";
            this.Text = "Рекламное Агентство: таблица Услуги";
            this.TableTools.ResumeLayout(false);
            this.TableTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem PriceMoreThan5000Button;
        private System.Windows.Forms.ToolStripDropDownButton FilterButton;
        private System.Windows.Forms.ToolStrip TableTools;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem SearchByServiceNameButton;
        private System.Windows.Forms.ToolStripDropDownButton SortButton;
        private System.Windows.Forms.ToolStripMenuItem SortByPriceButton;
        private System.Windows.Forms.ToolStripMenuItem SortByServiceNameButton;
        private System.Windows.Forms.DataGridView ServicesTable;
        private System.Drawing.Printing.PrintDocument DocumentPrinter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ServicePriceTextBox;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox SearchNameTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ServiceNameTextBox;
        private System.Windows.Forms.ToolStripMenuItem PriceLessThan5000Button;
    }
}