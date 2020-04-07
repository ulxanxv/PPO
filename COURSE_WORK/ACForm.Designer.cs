namespace COURSE_WORK {
    partial class ACForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.someMessage = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.MaskedTextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.place = new System.Windows.Forms.NumericUpDown();
            this.dateOfBirth = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.ComboBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.serialAndNumberOfPassportLabel = new System.Windows.Forms.Label();
            this.serialAndNumberOfPassport = new System.Windows.Forms.MaskedTextBox();
            this.document = new System.Windows.Forms.ComboBox();
            this.documentLabel = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.TextBox();
            this.toLabel = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.findField = new System.Windows.Forms.MaskedTextBox();
            this.findFieldLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.place)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(829, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel1.Text = "Ульянов Артём";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "ПКсп-117";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel3.Text = "Курсовая работа";
            // 
            // someMessage
            // 
            this.someMessage.Enabled = false;
            this.someMessage.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.someMessage.Location = new System.Drawing.Point(259, 374);
            this.someMessage.Multiline = true;
            this.someMessage.Name = "someMessage";
            this.someMessage.ReadOnly = true;
            this.someMessage.Size = new System.Drawing.Size(557, 30);
            this.someMessage.TabIndex = 56;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(34, 112);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(60, 22);
            this.timeLabel.TabIndex = 55;
            this.timeLabel.Text = "Время";
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(100, 109);
            this.time.Mask = "00:00";
            this.time.Name = "time";
            this.time.PromptChar = ' ';
            this.time.Size = new System.Drawing.Size(180, 30);
            this.time.TabIndex = 54;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.Location = new System.Drawing.Point(258, 335);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(240, 30);
            this.changeButton.TabIndex = 52;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(12, 372);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(240, 30);
            this.addButton.TabIndex = 51;
            this.addButton.Text = "Внести в базу данных";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // place
            // 
            this.place.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place.Location = new System.Drawing.Point(100, 217);
            this.place.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.place.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(180, 30);
            this.place.TabIndex = 50;
            this.place.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Enabled = false;
            this.dateOfBirth.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirth.Location = new System.Drawing.Point(538, 70);
            this.dateOfBirth.MaxLength = 128;
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ReadOnly = true;
            this.dateOfBirth.Size = new System.Drawing.Size(266, 30);
            this.dateOfBirth.TabIndex = 49;
            this.dateOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar1.Location = new System.Drawing.Point(652, 109);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(34, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 47;
            this.label10.Text = "Место";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(54, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Пол";
            // 
            // gender
            // 
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.gender.Location = new System.Drawing.Point(100, 181);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(180, 30);
            this.gender.TabIndex = 45;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOfBirthLabel.Location = new System.Drawing.Point(534, 34);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(270, 22);
            this.dateOfBirthLabel.TabIndex = 44;
            this.dateOfBirthLabel.Text = "Дата рождения (ДД:ММ:ГГГГ)";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleNameLabel.Location = new System.Drawing.Point(286, 255);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(90, 22);
            this.middleNameLabel.TabIndex = 43;
            this.middleNameLabel.Text = "Отчество";
            // 
            // middleName
            // 
            this.middleName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.middleName.Location = new System.Drawing.Point(382, 252);
            this.middleName.MaxLength = 128;
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(258, 30);
            this.middleName.TabIndex = 42;
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastName.Location = new System.Drawing.Point(382, 217);
            this.lastName.MaxLength = 128;
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(258, 30);
            this.lastName.TabIndex = 41;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameLabel.Location = new System.Drawing.Point(336, 184);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(40, 22);
            this.firstNameLabel.TabIndex = 40;
            this.firstNameLabel.Text = "Имя";
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstName.Location = new System.Drawing.Point(382, 181);
            this.firstName.MaxLength = 128;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(258, 30);
            this.firstName.TabIndex = 39;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.Location = new System.Drawing.Point(296, 220);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(80, 22);
            this.lastNameLabel.TabIndex = 38;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // serialAndNumberOfPassportLabel
            // 
            this.serialAndNumberOfPassportLabel.AutoSize = true;
            this.serialAndNumberOfPassportLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serialAndNumberOfPassportLabel.Location = new System.Drawing.Point(146, 148);
            this.serialAndNumberOfPassportLabel.Name = "serialAndNumberOfPassportLabel";
            this.serialAndNumberOfPassportLabel.Size = new System.Drawing.Size(230, 22);
            this.serialAndNumberOfPassportLabel.TabIndex = 37;
            this.serialAndNumberOfPassportLabel.Text = "Серия и номер паспорта";
            // 
            // serialAndNumberOfPassport
            // 
            this.serialAndNumberOfPassport.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.serialAndNumberOfPassport.Location = new System.Drawing.Point(382, 145);
            this.serialAndNumberOfPassport.Mask = "0000 000000";
            this.serialAndNumberOfPassport.Name = "serialAndNumberOfPassport";
            this.serialAndNumberOfPassport.PromptChar = ' ';
            this.serialAndNumberOfPassport.Size = new System.Drawing.Size(258, 30);
            this.serialAndNumberOfPassport.TabIndex = 36;
            // 
            // document
            // 
            this.document.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.document.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.document.FormattingEnabled = true;
            this.document.Items.AddRange(new object[] {
            "Загранпаспорт РФ",
            "Иностранный документ",
            "Паспорт РФ",
            "Свидетельство о рождении"});
            this.document.Location = new System.Drawing.Point(382, 109);
            this.document.Name = "document";
            this.document.Size = new System.Drawing.Size(258, 30);
            this.document.TabIndex = 35;
            // 
            // documentLabel
            // 
            this.documentLabel.AutoSize = true;
            this.documentLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.documentLabel.Location = new System.Drawing.Point(286, 112);
            this.documentLabel.Name = "documentLabel";
            this.documentLabel.Size = new System.Drawing.Size(90, 22);
            this.documentLabel.TabIndex = 34;
            this.documentLabel.Text = "Документ";
            // 
            // to
            // 
            this.to.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.to.Location = new System.Drawing.Point(100, 70);
            this.to.MaxLength = 128;
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(420, 30);
            this.to.TabIndex = 33;
            this.to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toLabel.Location = new System.Drawing.Point(44, 73);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(50, 22);
            this.toLabel.TabIndex = 32;
            this.toLabel.Text = "Куда";
            // 
            // from
            // 
            this.from.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.from.Location = new System.Drawing.Point(100, 34);
            this.from.MaxLength = 128;
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(420, 30);
            this.from.TabIndex = 31;
            this.from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromLabel.Location = new System.Drawing.Point(24, 37);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(70, 22);
            this.fromLabel.TabIndex = 30;
            this.fromLabel.Text = "Откуда";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(12, 335);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(240, 30);
            this.saveButton.TabIndex = 57;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.Location = new System.Drawing.Point(12, 410);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(240, 30);
            this.findButton.TabIndex = 58;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            // 
            // findField
            // 
            this.findField.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findField.Location = new System.Drawing.Point(258, 411);
            this.findField.Mask = "0000 000000";
            this.findField.Name = "findField";
            this.findField.PromptChar = ' ';
            this.findField.Size = new System.Drawing.Size(258, 30);
            this.findField.TabIndex = 59;
            // 
            // findFieldLabel
            // 
            this.findFieldLabel.AutoSize = true;
            this.findFieldLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findFieldLabel.Location = new System.Drawing.Point(522, 414);
            this.findFieldLabel.Name = "findFieldLabel";
            this.findFieldLabel.Size = new System.Drawing.Size(260, 22);
            this.findFieldLabel.TabIndex = 60;
            this.findFieldLabel.Text = "<- Серия и номер паспорта";
            // 
            // ACForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 451);
            this.Controls.Add(this.findFieldLabel);
            this.Controls.Add(this.findField);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.someMessage);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.time);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.place);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.serialAndNumberOfPassportLabel);
            this.Controls.Add(this.serialAndNumberOfPassport);
            this.Controls.Add(this.document);
            this.Controls.Add(this.documentLabel);
            this.Controls.Add(this.to);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.from);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ACForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/изменение элемента базы данных";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.place)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.TextBox someMessage;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.MaskedTextBox time;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown place;
        private System.Windows.Forms.TextBox dateOfBirth;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox middleName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label serialAndNumberOfPassportLabel;
        private System.Windows.Forms.MaskedTextBox serialAndNumberOfPassport;
        private System.Windows.Forms.ComboBox document;
        private System.Windows.Forms.Label documentLabel;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.MaskedTextBox findField;
        private System.Windows.Forms.Label findFieldLabel;
    }
}