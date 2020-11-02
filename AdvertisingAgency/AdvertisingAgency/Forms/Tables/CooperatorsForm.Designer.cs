namespace AdvertisingAgency.Forms.Tables
{
    partial class CooperatorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CooperatorsForm));
            this.TableTools = new System.Windows.Forms.ToolStrip();
            this.PrintButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.SearchByNameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.SortByNameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortBySurnameButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SortByPositionButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ShowManagersButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CooperatorsTable = new System.Windows.Forms.DataGridView();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CooperatorCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchNameTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.DocumentPrinter = new System.Drawing.Printing.PrintDocument();
            this.TableTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CooperatorsTable)).BeginInit();
            this.SuspendLayout();
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
            this.TableTools.Size = new System.Drawing.Size(1050, 25);
            this.TableTools.TabIndex = 2;
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
            this.SortByPositionButton});
            this.SortButton.Image = ((System.Drawing.Image)(resources.GetObject("SortButton.Image")));
            this.SortButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(86, 22);
            this.SortButton.Text = "Сортировка";
            // 
            // SortByNameButton
            // 
            this.SortByNameButton.Name = "SortByNameButton";
            this.SortByNameButton.Size = new System.Drawing.Size(154, 22);
            this.SortByNameButton.Text = "По имени";
            this.SortByNameButton.Click += new System.EventHandler(this.SortByNameButton_Click);
            // 
            // SortBySurnameButton
            // 
            this.SortBySurnameButton.Name = "SortBySurnameButton";
            this.SortBySurnameButton.Size = new System.Drawing.Size(154, 22);
            this.SortBySurnameButton.Text = "По фамилии";
            this.SortBySurnameButton.Click += new System.EventHandler(this.SortBySurnameButton_Click);
            // 
            // SortByPositionButton
            // 
            this.SortByPositionButton.Name = "SortByPositionButton";
            this.SortByPositionButton.Size = new System.Drawing.Size(154, 22);
            this.SortByPositionButton.Text = "По должности";
            this.SortByPositionButton.Click += new System.EventHandler(this.SortByPositionButton_Click);
            // 
            // FilterButton
            // 
            this.FilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FilterButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowManagersButton});
            this.FilterButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterButton.Image")));
            this.FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(87, 22);
            this.FilterButton.Text = "Фильтрация";
            // 
            // ShowManagersButton
            // 
            this.ShowManagersButton.Name = "ShowManagersButton";
            this.ShowManagersButton.Size = new System.Drawing.Size(287, 22);
            this.ShowManagersButton.Text = "Сотрудники с должностью менеджера";
            this.ShowManagersButton.Click += new System.EventHandler(this.ShowManagersButton_Click);
            // 
            // CooperatorsTable
            // 
            this.CooperatorsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CooperatorsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CooperatorsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CooperatorsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CooperatorsTable.Location = new System.Drawing.Point(12, 28);
            this.CooperatorsTable.Name = "CooperatorsTable";
            this.CooperatorsTable.Size = new System.Drawing.Size(715, 410);
            this.CooperatorsTable.TabIndex = 3;
            this.CooperatorsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CooperatorsTable_CellClick);
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionTextBox.Location = new System.Drawing.Point(849, 129);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(186, 20);
            this.PositionTextBox.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(733, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Должность";
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PatronymicTextBox.Location = new System.Drawing.Point(849, 103);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(186, 20);
            this.PatronymicTextBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(733, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Отчество";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(849, 77);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(186, 20);
            this.NameTextBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(734, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Имя";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SurnameTextBox.Location = new System.Drawing.Point(849, 51);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(186, 20);
            this.SurnameTextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(733, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Фамилия";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(849, 155);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(186, 20);
            this.PhoneNumberTextBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(733, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Телефон";
            // 
            // CooperatorCodeTextBox
            // 
            this.CooperatorCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CooperatorCodeTextBox.Location = new System.Drawing.Point(849, 25);
            this.CooperatorCodeTextBox.Name = "CooperatorCodeTextBox";
            this.CooperatorCodeTextBox.Size = new System.Drawing.Size(186, 20);
            this.CooperatorCodeTextBox.TabIndex = 15;
            this.CooperatorCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CooperatorCodeTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(733, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Код сотрудника";
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(916, 259);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(67, 23);
            this.SearchButton.TabIndex = 31;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchNameTextBox
            // 
            this.SearchNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchNameTextBox.Enabled = false;
            this.SearchNameTextBox.Location = new System.Drawing.Point(797, 259);
            this.SearchNameTextBox.Name = "SearchNameTextBox";
            this.SearchNameTextBox.Size = new System.Drawing.Size(113, 20);
            this.SearchNameTextBox.TabIndex = 30;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Location = new System.Drawing.Point(797, 372);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(186, 23);
            this.DeleteButton.TabIndex = 29;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Location = new System.Drawing.Point(797, 343);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(186, 23);
            this.EditButton.TabIndex = 28;
            this.EditButton.Text = "Изменить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Location = new System.Drawing.Point(797, 314);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(186, 23);
            this.UpdateButton.TabIndex = 27;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewButton.Location = new System.Drawing.Point(797, 285);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(186, 23);
            this.AddNewButton.TabIndex = 26;
            this.AddNewButton.Text = "Добавить";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
            // 
            // DocumentPrinter
            // 
            this.DocumentPrinter.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DocumentPrinter_PrintPage);
            // 
            // CooperatorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchNameTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CooperatorCodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CooperatorsTable);
            this.Controls.Add(this.TableTools);
            this.Name = "CooperatorsForm";
            this.Text = "Рекламное Агентство: таблица Сотрудники";
            this.TableTools.ResumeLayout(false);
            this.TableTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CooperatorsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TableTools;
        private System.Windows.Forms.ToolStripButton PrintButton;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem SearchByNameButton;
        private System.Windows.Forms.ToolStripDropDownButton SortButton;
        private System.Windows.Forms.ToolStripMenuItem SortByNameButton;
        private System.Windows.Forms.ToolStripMenuItem SortBySurnameButton;
        private System.Windows.Forms.ToolStripMenuItem SortByPositionButton;
        private System.Windows.Forms.ToolStripDropDownButton FilterButton;
        private System.Windows.Forms.ToolStripMenuItem ShowManagersButton;
        private System.Windows.Forms.DataGridView CooperatorsTable;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CooperatorCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchNameTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Drawing.Printing.PrintDocument DocumentPrinter;
    }
}