namespace OOP3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ManufactorerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorsePowerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doorAmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPassangersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CruiseSpeedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton2 = new System.Windows.Forms.Button();
            this.plugButton = new System.Windows.Forms.Button();
            this.readFileButton4 = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1363, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ManufactorerColumn,
            this.ModelColumn,
            this.WeightColumn,
            this.HorsePowerColumn,
            this.PriceColumn,
            this.doorAmountColumn,
            this.MaxPassangersColumn,
            this.CruiseSpeedColumn,
            this.frameColumn,
            this.TypeColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1315, 495);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellLeave);
            // 
            // ManufactorerColumn
            // 
            this.ManufactorerColumn.HeaderText = "Производитель";
            this.ManufactorerColumn.MinimumWidth = 6;
            this.ManufactorerColumn.Name = "ManufactorerColumn";
            this.ManufactorerColumn.Width = 140;
            // 
            // ModelColumn
            // 
            this.ModelColumn.HeaderText = "Модель";
            this.ModelColumn.MinimumWidth = 6;
            this.ModelColumn.Name = "ModelColumn";
            this.ModelColumn.Width = 140;
            // 
            // WeightColumn
            // 
            this.WeightColumn.HeaderText = "Масса";
            this.WeightColumn.MinimumWidth = 6;
            this.WeightColumn.Name = "WeightColumn";
            this.WeightColumn.Width = 140;
            // 
            // HorsePowerColumn
            // 
            this.HorsePowerColumn.HeaderText = "ЛС";
            this.HorsePowerColumn.MinimumWidth = 6;
            this.HorsePowerColumn.Name = "HorsePowerColumn";
            this.HorsePowerColumn.Width = 140;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Цена";
            this.PriceColumn.MinimumWidth = 6;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Width = 140;
            // 
            // doorAmountColumn
            // 
            this.doorAmountColumn.HeaderText = "Количество дверей";
            this.doorAmountColumn.MinimumWidth = 6;
            this.doorAmountColumn.Name = "doorAmountColumn";
            this.doorAmountColumn.Width = 125;
            // 
            // MaxPassangersColumn
            // 
            this.MaxPassangersColumn.HeaderText = "Максимум пассажиров";
            this.MaxPassangersColumn.MinimumWidth = 6;
            this.MaxPassangersColumn.Name = "MaxPassangersColumn";
            this.MaxPassangersColumn.Width = 140;
            // 
            // CruiseSpeedColumn
            // 
            this.CruiseSpeedColumn.HeaderText = "Крейсерская скорость";
            this.CruiseSpeedColumn.MinimumWidth = 6;
            this.CruiseSpeedColumn.Name = "CruiseSpeedColumn";
            this.CruiseSpeedColumn.Width = 140;
            // 
            // frameColumn
            // 
            this.frameColumn.HeaderText = "Рама";
            this.frameColumn.MinimumWidth = 6;
            this.frameColumn.Name = "frameColumn";
            this.frameColumn.Width = 140;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Спортивный?";
            this.TypeColumn.MinimumWidth = 6;
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TypeColumn.Width = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1321, 516);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1367, 106);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(96, 42);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton2
            // 
            this.deleteButton2.Location = new System.Drawing.Point(1367, 175);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(96, 42);
            this.deleteButton2.TabIndex = 4;
            this.deleteButton2.Text = "Удалить";
            this.deleteButton2.UseVisualStyleBackColor = true;
            this.deleteButton2.Click += new System.EventHandler(this.deleteButton2_Click);
            // 
            // plugButton
            // 
            this.plugButton.Location = new System.Drawing.Point(1363, 377);
            this.plugButton.Name = "plugButton";
            this.plugButton.Size = new System.Drawing.Size(75, 23);
            this.plugButton.TabIndex = 5;
            this.plugButton.Text = "plug";
            this.plugButton.UseVisualStyleBackColor = true;
            this.plugButton.Click += new System.EventHandler(this.plugButton_Click);
            // 
            // readFileButton4
            // 
            this.readFileButton4.Location = new System.Drawing.Point(1367, 313);
            this.readFileButton4.Name = "readFileButton4";
            this.readFileButton4.Size = new System.Drawing.Size(96, 42);
            this.readFileButton4.TabIndex = 6;
            this.readFileButton4.Text = "Загрузить";
            this.readFileButton4.UseVisualStyleBackColor = true;
            this.readFileButton4.Click += new System.EventHandler(this.readFileButton4_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1367, 244);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 42);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.InitialDirectory = "D:\\Cal\\projects\\OOP\\OOP3\\OOP3\\bin\\Debug";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 548);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.readFileButton4);
            this.Controls.Add(this.plugButton);
            this.Controls.Add(this.deleteButton2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton2;
        private System.Windows.Forms.Button plugButton;
        private System.Windows.Forms.Button readFileButton4;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManufactorerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorsePowerColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doorAmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPassangersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CruiseSpeedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TypeColumn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

