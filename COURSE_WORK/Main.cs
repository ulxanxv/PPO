using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COURSE_WORK {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Загрузка базы данных
            textBox1.Text = WWS.loadData();

            // Автоматическая генерация столбцов
            dataGridView1.AutoGenerateColumns = true;

            // Привязка источника данных
            dataGridView1.DataSource = WWS.tickets;

            // Назначение имен столбцов
            dataGridView1.Columns[0].HeaderText = "Серия";
            dataGridView1.Columns[1].HeaderText = "Номер";
            dataGridView1.Columns[2].HeaderText = "Откуда";
            dataGridView1.Columns[3].HeaderText = "Куда";
            dataGridView1.Columns[4].HeaderText = "Время";
            dataGridView1.Columns[5].HeaderText = "Документ";
            dataGridView1.Columns[6].HeaderText = "Имя";
            dataGridView1.Columns[7].HeaderText = "Фамилия";
            dataGridView1.Columns[8].HeaderText = "Отчество";
            dataGridView1.Columns[9].HeaderText = "Дата рождения";
            dataGridView1.Columns[10].HeaderText = "Место";
            dataGridView1.Columns[11].HeaderText = "Пол";

            // Удалить
            deleteButton.Click += Delete_Click;

            // Добавить или изменить
            openNewWindowButton.Click += OpenNewWindow_Click;

            // Сохранить
            saveButton.Click += Save_Click;

            // Нумерация строк
            dataGridView1.RowPrePaint += DataGridView1_RowPrePaint;
        }

        private void Delete_Click(object sender, EventArgs e) {
            delete();
        }

        private void OpenNewWindow_Click(object sender, EventArgs e) {
            new ACForm().Show();
        }
        private void Save_Click(object sender, EventArgs e) {
            saveFile();
        }

        // Создание индексов для строк
        private void DataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e) {
            int index = e.RowIndex;

            string indexStr = index.ToString();

            object header = this.dataGridView1.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridView1.Rows[index].HeaderCell.Value = indexStr;
        }

        private void delete() {
            if (WWS.tickets.Remove(findElement(deleteField.Text))) {
                textBox1.Text = "Запись удалена";
            } else {
                textBox1.Text = "Запись не найдена";
            }
        }

        private Ticket findElement(string uniqNumber) {
            Ticket search = new Ticket(uniqNumber);

            foreach (Ticket x in WWS.tickets) {
                if (x.Equals(search)) return x;
            }

            return null;
        }

        private void saveFile() {
            string readyText = "";

            foreach (Ticket x in WWS.tickets) {
                char[] changeText = x.ToString().ToCharArray();
                changeText[4] = ' ';

                readyText += new string(changeText);
            }

            File.WriteAllText(WWS.path, readyText);
        }
    }
}
