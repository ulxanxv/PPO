namespace COURSE_WORK {
    partial class Main {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.realStudentName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.realGroupName = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.realNameWork = new System.Windows.Forms.ToolStripLabel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.openNewWindowButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nameOfProgram = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteField = new System.Windows.Forms.MaskedTextBox();
            this.deleteFieldLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realStudentName,
            this.toolStripSeparator1,
            this.realGroupName,
            this.toolStripSeparator2,
            this.realNameWork});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1254, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // realStudentName
            // 
            this.realStudentName.Name = "realStudentName";
            this.realStudentName.Size = new System.Drawing.Size(91, 22);
            this.realStudentName.Text = "Ульянов Артём";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // realGroupName
            // 
            this.realGroupName.Name = "realGroupName";
            this.realGroupName.Size = new System.Drawing.Size(59, 22);
            this.realGroupName.Text = "ПКсп-117";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // realNameWork
            // 
            this.realNameWork.Name = "realNameWork";
            this.realNameWork.Size = new System.Drawing.Size(99, 22);
            this.realNameWork.Text = "Курсовая работа";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 28);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(150, 35);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // openNewWindowButton
            // 
            this.openNewWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openNewWindowButton.Location = new System.Drawing.Point(12, 69);
            this.openNewWindowButton.Name = "openNewWindowButton";
            this.openNewWindowButton.Size = new System.Drawing.Size(149, 35);
            this.openNewWindowButton.TabIndex = 2;
            this.openNewWindowButton.Text = "Добавить или изменить";
            this.openNewWindowButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(168, 69);
            this.textBox1.MaxLength = 64;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(250, 35);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameOfProgram
            // 
            this.nameOfProgram.AutoSize = true;
            this.nameOfProgram.Font = new System.Drawing.Font("Garamond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOfProgram.Location = new System.Drawing.Point(706, 60);
            this.nameOfProgram.Name = "nameOfProgram";
            this.nameOfProgram.Size = new System.Drawing.Size(536, 42);
            this.nameOfProgram.TabIndex = 6;
            this.nameOfProgram.Text = "База данных списка Ж/Д билетов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1230, 438);
            this.dataGridView1.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(425, 69);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(110, 36);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // deleteField
            // 
            this.deleteField.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteField.Location = new System.Drawing.Point(168, 30);
            this.deleteField.Mask = "0000 000000";
            this.deleteField.Name = "deleteField";
            this.deleteField.PromptChar = ' ';
            this.deleteField.Size = new System.Drawing.Size(250, 30);
            this.deleteField.TabIndex = 60;
            // 
            // deleteFieldLabel
            // 
            this.deleteFieldLabel.AutoSize = true;
            this.deleteFieldLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteFieldLabel.Location = new System.Drawing.Point(421, 33);
            this.deleteFieldLabel.Name = "deleteFieldLabel";
            this.deleteFieldLabel.Size = new System.Drawing.Size(260, 22);
            this.deleteFieldLabel.TabIndex = 61;
            this.deleteFieldLabel.Text = "<- Серия и номер паспорта";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 561);
            this.Controls.Add(this.deleteFieldLabel);
            this.Controls.Add(this.deleteField);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nameOfProgram);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.openNewWindowButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel realStudentName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel realGroupName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel realNameWork;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button openNewWindowButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nameOfProgram;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.MaskedTextBox deleteField;
        private System.Windows.Forms.Label deleteFieldLabel;
    }
}

