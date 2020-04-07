using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COURSE_WORK {
    public partial class ACForm : Form {
        private List<Control> allComponents = new List<Control>();

        private Ticket mutableTicket = null;

        public ACForm() {
            InitializeComponent();

            // Значение по умолчанию
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            // Установка даты по умолчанию
            textBox6.Text = DateTime.Now.ToShortDateString();

            // Добавление всех компонентов в единый список для более удобной навигации
            allComponents.Add(maskedTextBox1); // Серия и номер паспорта
            allComponents.Add(textBox1);       // Откуда
            allComponents.Add(textBox2);       // Куда
            allComponents.Add(maskedTextBox2); // Время
            allComponents.Add(comboBox1);      // Документы
            allComponents.Add(textBox3);       // Имя
            allComponents.Add(textBox4);       // Фамилия
            allComponents.Add(textBox5);       // Отчество
            allComponents.Add(textBox6);       // Дата рождения
            allComponents.Add(numericUpDown1); // Место
            allComponents.Add(comboBox2);      // Пол

            // Добавить в базу данных
            button1.Click += Button1_Click;

            // Изменить позицию
            button2.Click += Button2_Click;

            // Сохранить
            button3.Click += Button3_Click;

            // Найти
            button4.Click += Button4_Click;

            // Изменение даты рождения
            monthCalendar1.DateChanged += MonthCalendar1_DateChanged;
        }

        private void Button4_Click(object sender, EventArgs e) {
            outputInForm(findElement(maskedTextBox3.Text));
        }

        private void Button3_Click(object sender, EventArgs e) {
            saveFile();
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {
            textBox6.Text = e.End.ToShortDateString();
        }

        private void Button2_Click(object sender, EventArgs e) {
            change();
        }

        private void Button1_Click(object sender, EventArgs e) {
            add();
        }

        private void change() {
            if (mutableTicket != null) {
                if (correct()) {
                    Ticket added = getTicket();

                    // Добавляем новую
                    WWS.tickets.Add(added);

                    // Удаляем старую
                    WWS.tickets.Remove(mutableTicket);

                    textBox7.Text = "Элемент изменен!";

                    mutableTicket = null;
                } else {
                    textBox7.Text = "Проверьте правильность полей!";
                }
            } else {
                textBox7.Text = "Сначала воспользутесь поиском и найдите элемент!";
            }
        }

        private bool add() {
            // Проверка доступности выбранного места
            if (!WWS.places.Contains((int)numericUpDown1.Value)) {
                // Проверка правильности полей
                if (correct()) {
                    // Если место доступно, то сформировать входную строку для передачи в конструктор обьекта класса Ticket
                    Ticket newTicket = getTicket();
                    // Проверка уникальности человека
                    if (!WWS.tickets.Contains(newTicket)) {
                        // Добавление нового человека
                        WWS.tickets.Add(newTicket);
                        // Добавляем место данного человека в список занятых мест (место свободно, так как проверка была выше)
                        WWS.places.Add(newTicket.Place);
                    } else {
                        textBox7.Text = "Такой человек уже есть!";
                        return false;
                    }
                }
            } else {
                textBox7.Text = "Место уже занято";
                return false;
            }

            return false;
        }

        // Найти запись по серии и номеру паспорта
        private Ticket findElement(string uniqNumber) {
            Ticket search = new Ticket(uniqNumber);

            foreach (Ticket x in WWS.tickets) {
                if (x.Equals(search)) return x;
            }

            return null;
        }

        // Вывести данные в форму (касаемо кнопки 'Найти')
        private void outputInForm(Ticket ticket) {
            if (ticket != null) {
                textBox7.Text = "Запись найдена!";

                string[] outputText = ticket.ToString().Split(';');

                maskedTextBox1.Text = outputText[0] + outputText[1];
                textBox1.Text = outputText[2];
                textBox2.Text = outputText[3];
                maskedTextBox2.Text = outputText[4];

                switch (outputText[5]) {
                    case "Загранпаспорт РФ":
                        comboBox1.SelectedIndex = 0;
                        break;
                    case "Иностранный документ":
                        comboBox1.SelectedIndex = 1;
                        break;
                    case "Паспорт РФ":
                        comboBox1.SelectedIndex = 2;
                        break;
                    case "Свидетельство о рождении":
                        comboBox1.SelectedIndex = 3;
                        break;
                }

                textBox3.Text = outputText[6];
                textBox4.Text = outputText[7];
                textBox5.Text = outputText[8];
                textBox6.Text = outputText[9];

                numericUpDown1.Text = outputText[10];

                comboBox2.SelectedIndex = outputText[11].Trim() == "Мужской" ? 0 : 1;

                mutableTicket = ticket;

                return;
            }

            mutableTicket = null;

            textBox7.Text = "Запись не найдена!";
        }

        // Получения полноценной информации о билете 
        private Ticket getTicket() {
            List<Control>.Enumerator allComp = allComponents.GetEnumerator();
            string[] aboutTicket = new string[allComponents.Count];

            for (int i = 0; allComp.MoveNext(); i++)
                aboutTicket[i] = allComp.Current.Text;
            return new Ticket(aboutTicket);
        }

        // Кнопка сохранения
        private bool saveFile() {
            try {
                string readyText = "";

                foreach (Ticket x in WWS.tickets) {
                    char[] changeText = x.ToString().ToCharArray();
                    changeText[4] = ' ';

                    readyText += new string(changeText);
                }

                File.WriteAllText(WWS.path, readyText);

                return true;

            } catch (IOException io) {
                textBox7.Text = "Ошибка! " + io.Message;
                return false;
            }
        }

        // Метод проверки правильности введенных данных
        private bool correct() {
            int x = 0, y = 0;
            try {
                x = Convert.ToInt32(maskedTextBox2.Text.Split(':')[0]);
                y = Convert.ToInt32(maskedTextBox2.Text.Split(':')[1]);
            } catch (FormatException) {
                textBox7.Text = "Проверьте поле \"Время\"";
                return false;
            }

            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox5.Text.Length == 0) {
                textBox7.Text = "Проверьте правильность введенных данных";
                return false;
            } else if (x > 23 || y > 59) {
                textBox7.Text = "Проверьте правильность поля \"Время\"";
                return false;
            } else if (maskedTextBox1.Text.Length < 11) {
                textBox7.Text = "Проверьте правильность поля \"Серия и номер паспорта\"";
                return false;
            } else {
                return true;
            }
        }
    }
}
