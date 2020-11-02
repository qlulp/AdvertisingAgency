namespace AdvertisingAgency.Forms.TablesForms
{
    partial class ClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsForm));
            this.ClientsTable = new System.Windows.Forms.DataGridView();
            this.TableTools = new System.Windows.Forms.ToolStrip();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.SearchByNameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.SortByNameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortBySurnameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByCityButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.CodeMoreThan2Button = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientCodeTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DocumentPrinter = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsTable)).BeginInit();
            this.TableTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientsTable
            // 
            this.ClientsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ClientsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsTable.Location = new System.Drawing.Point(12, 28);
            this.ClientsTable.Name = "ClientsTable";
            this.ClientsTable.Size = new System.Drawing.Size(884, 410);
            this.ClientsTable.TabIndex = 0;
            this.ClientsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsTable_CellClick);
            this.ClientsTable.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientsTable_CellMouseDown);
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
            this.TableTools.Size = new System.Drawing.Size(1219, 25);
            this.TableTools.TabIndex = 1;
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
            this.SearchByNameButton});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(55, 22);
            this.toolStripDropDownButton1.Text = "Поиск";
            // 
            // SearchByNameButton
            // 
            this.SearchByNameButton.Name = "SearchByNameButton";
            this.SearchByNameButton.Size = new System.Drawing.Size(165, 22);
            this.SearchByNameButton.Text = "Поиск по имени";
            this.SearchByNameButton.Click += new System.EventHandler(this.SearchByNameButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SortButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortByNameButton,
            this.SortBySurnameButton,
            this.SortByCityButton});
            this.SortButton.Image = ((System.Drawing.Image)(resources.GetObject("SortButton.Image")));
            this.SortButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(86, 22);
            this.SortButton.Text = "Сортировка";
            // 
            // SortByNameButton
            // 
            this.SortByNameButton.Name = "SortByNameButton";
            this.SortByNameButton.Size = new System.Drawing.Size(145, 22);
            this.SortByNameButton.Text = "По имени";
            this.SortByNameButton.Click += new System.EventHandler(this.SortByNameButton_Click);
            // 
            // SortBySurnameButton
            // 
            this.SortBySurnameButton.Name = "SortBySurnameButton";
            this.SortBySurnameButton.Size = new System.Drawing.Size(145, 22);
            this.SortBySurnameButton.Text = "По фамилии";
            this.SortBySurnameButton.Click += new System.EventHandler(this.SortBySurnameButton_Click);
            // 
            // SortByCityButton
            // 
            this.SortByCityButton.Name = "SortByCityButton";
            this.SortByCityButton.Size = new System.Drawing.Size(145, 22);
            this.SortByCityButton.Text = "По городу";
            this.SortByCityButton.Click += new System.EventHandler(this.SortByCityButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FilterButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CodeMoreThan2Button});
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(87, 22);
            this.FilterButton.Text = "Фильтрация";
            // 
            // CodeMoreThan2Button
            // 
            this.CodeMoreThan2Button.Name = "CodeMoreThan2Button";
            this.CodeMoreThan2Button.Size = new System.Drawing.Size(197, 22);
            this.CodeMoreThan2Button.Text = "Код клиента больше 2";
            this.CodeMoreThan2Button.Click += new System.EventHandler(this.CodeMoreThan2Button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код клиента";
            // 
            // ClientCodeTextBox
            // 
            this.ClientCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientCodeTextBox.Location = new System.Drawing.Point(1018, 26);
            this.ClientCodeTextBox.Name = "ClientCodeTextBox";
            this.ClientCodeTextBox.Size = new System.Drawing.Size(186, 20);
            this.ClientCodeTextBox.TabIndex = 3;
            this.ClientCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientCodeTextBox_KeyPress);
            // 
            // DepartmentTextBox
            // 
            this.DepartmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartmentTextBox.Location = new System.Drawing.Point(1018, 52);
            this.DepartmentTextBox.Name = "DepartmentTextBox";
            this.DepartmentTextBox.Size = new System.Drawing.Size(186, 20);
            this.DepartmentTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(902, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Организация/Отдел";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(1018, 78);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(186, 20);
            this.SurnameTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(902, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фамилия";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(1018, 104);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(186, 20);
            this.NameTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(903, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Имя";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PatronymicTextBox.Location = new System.Drawing.Point(1018, 130);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(186, 20);
            this.PatronymicTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(902, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отчество";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.Location = new System.Drawing.Point(1018, 156);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(186, 20);
            this.CityTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(902, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Город";
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressTextBox.Location = new System.Drawing.Point(1018, 182);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(186, 20);
            this.AdressTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(902, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Адрес";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(1018, 208);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(186, 20);
            this.PhoneNumberTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(902, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Телефон";
            // 
            // AddNewButton
            // 
            this.AddNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewButton.Location = new System.Drawing.Point(975, 293);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(186, 23);
            this.AddNewButton.TabIndex = 18;
            this.AddNewButton.Text = "Добавить";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Location = new System.Drawing.Point(975, 322);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(186, 23);
            this.UpdateButton.TabIndex = 19;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(975, 351);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(186, 23);
            this.EditButton.TabIndex = 20;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(975, 380);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(186, 23);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchNameTextBox.Enabled = false;
            this.SearchNameTextBox.Location = new System.Drawing.Point(975, 267);
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.Size = new System.Drawing.Size(113, 20);
            this.SearchNameTextBox.TabIndex = 22;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(1094, 267);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(67, 23);
            this.SearchButton.TabIndex = 23;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DocumentPrinter
            // 
            this.DocumentPrinter.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1219, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchNameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AdressTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DepartmentTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClientCodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableTools);
            this.Controls.Add(this.ClientsTable);
            this.Name = "ClientsForm";
            this.Text = "Рекламное Агентство: таблица Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.ClientsTable)).EndInit();
            this.TableTools.ResumeLayout(false);
            this.TableTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientsTable;
        private System.Windows.Forms.ToolStrip TableTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientCodeTextBox;
        private System.Windows.Forms.TextBox DepartmentTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox SearchNameTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem SearchByNameButton;
        private System.Drawing.Printing.PrintDocument DocumentPrinter;
        private System.Windows.Forms.ToolStripDropDownButton SortButton;
        private System.Windows.Forms.ToolStripMenuItem SortByNameButton;
        private System.Windows.Forms.ToolStripMenuItem SortBySurnameButton;
        private System.Windows.Forms.ToolStripMenuItem SortByCityButton;
        private System.Windows.Forms.ToolStripDropDownButton FilterButton;
        private System.Windows.Forms.ToolStripMenuItem CodeMoreThan2Button;
    }
}