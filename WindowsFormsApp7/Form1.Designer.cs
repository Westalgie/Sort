namespace WindowsFormsApp7
{
    partial class Form1
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.CountSort = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColvoMass = new System.Windows.Forms.ToolStripMenuItem();
            this.Random = new System.Windows.Forms.ToolStripMenuItem();
            this.sravnenie = new System.Windows.Forms.Label();
            this.massiv = new System.Windows.Forms.DataGridView();
            this.input = new System.Windows.Forms.TextBox();
            this.butInput = new System.Windows.Forms.Button();
            this.labVvod = new System.Windows.Forms.Label();
            this.additional = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additional)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sort,
            this.runToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(635, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // Sort
            // 
            this.Sort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CountSort});
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(85, 20);
            this.Sort.Text = "Сортировка";
            // 
            // CountSort
            // 
            this.CountSort.Name = "CountSort";
            this.CountSort.Size = new System.Drawing.Size(203, 22);
            this.CountSort.Text = "Сортировка подсчетом";
            this.CountSort.Click += new System.EventHandler(this.CountSort_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColvoMass,
            this.Random});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.runToolStripMenuItem.Text = "Массив";
            // 
            // ColvoMass
            // 
            this.ColvoMass.Name = "ColvoMass";
            this.ColvoMass.Size = new System.Drawing.Size(259, 22);
            this.ColvoMass.Text = "Ввести размер массива";
            this.ColvoMass.Click += new System.EventHandler(this.ColvoMass_Click);
            // 
            // Random
            // 
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(259, 22);
            this.Random.Text = "Заполнить случайными числами";
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // sravnenie
            // 
            this.sravnenie.AutoSize = true;
            this.sravnenie.Location = new System.Drawing.Point(257, 84);
            this.sravnenie.Name = "sravnenie";
            this.sravnenie.Size = new System.Drawing.Size(70, 13);
            this.sravnenie.TabIndex = 3;
            this.sravnenie.Text = "Сравниваем";
            // 
            // massiv
            // 
            this.massiv.AllowUserToAddRows = false;
            this.massiv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.massiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.massiv.ColumnHeadersVisible = false;
            this.massiv.EnableHeadersVisualStyles = false;
            this.massiv.Location = new System.Drawing.Point(12, 31);
            this.massiv.Name = "massiv";
            this.massiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.massiv.RowHeadersVisible = false;
            this.massiv.RowTemplate.Height = 24;
            this.massiv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.massiv.ShowEditingIcon = false;
            this.massiv.Size = new System.Drawing.Size(605, 66);
            this.massiv.TabIndex = 4;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(173, 221);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 5;
            this.input.Visible = false;
            // 
            // butInput
            // 
            this.butInput.Location = new System.Drawing.Point(306, 212);
            this.butInput.Name = "butInput";
            this.butInput.Size = new System.Drawing.Size(58, 37);
            this.butInput.TabIndex = 6;
            this.butInput.Text = "Ввод";
            this.butInput.UseVisualStyleBackColor = true;
            this.butInput.Visible = false;
            this.butInput.Click += new System.EventHandler(this.butInput_Click);
            // 
            // labVvod
            // 
            this.labVvod.AutoSize = true;
            this.labVvod.Location = new System.Drawing.Point(27, 215);
            this.labVvod.Name = "labVvod";
            this.labVvod.Size = new System.Drawing.Size(118, 26);
            this.labVvod.TabIndex = 7;
            this.labVvod.Text = "Введите количество \r\nэлементов в массиве";
            this.labVvod.Visible = false;
            // 
            // additional
            // 
            this.additional.AllowUserToAddRows = false;
            this.additional.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.additional.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.additional.ColumnHeadersVisible = false;
            this.additional.EnableHeadersVisualStyles = false;
            this.additional.Location = new System.Drawing.Point(12, 115);
            this.additional.Name = "additional";
            this.additional.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.additional.RowHeadersVisible = false;
            this.additional.RowTemplate.Height = 24;
            this.additional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.additional.ShowEditingIcon = false;
            this.additional.Size = new System.Drawing.Size(605, 66);
            this.additional.TabIndex = 8;
            this.additional.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(635, 272);
            this.Controls.Add(this.additional);
            this.Controls.Add(this.labVvod);
            this.Controls.Add(this.butInput);
            this.Controls.Add(this.input);
            this.Controls.Add(this.massiv);
            this.Controls.Add(this.sravnenie);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sort";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.massiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additional)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Sort;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CountSort;
        private System.Windows.Forms.Label sravnenie;
        private System.Windows.Forms.DataGridView massiv;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button butInput;
        private System.Windows.Forms.Label labVvod;
        private System.Windows.Forms.ToolStripMenuItem ColvoMass;
        private System.Windows.Forms.ToolStripMenuItem Random;
        private System.Windows.Forms.DataGridView additional;
    }
}

