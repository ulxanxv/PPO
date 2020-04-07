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
            document.SelectedIndex = 0;
            gender.SelectedIndex = 0;

            // Установка даты по умолчанию
            dateOfBirth.Text = DateTime.Now.ToShortDateString();

            // Добавление всех компонентов в единый список для более удобной навигации
            allComponents.Add(serialAndNumberOfPassport); // Серия и номер паспорта
            allComponents.Add(from);       // Откуда
            allComponents.Add(to);       // Куда
            allComponents.Add(time); // Время
            allComponents.Add(document);      // Документы
            allComponents.Add(firstName);       // Имя
            allComponents.Add(lastName);       // Фамилия
            allComponents.Add(middleName);       // Отчество
            allComponents.Add(dateOfBirth);       // Дата рождения
            allComponents.Add(place); // Место
            allComponents.Add(gender);      // Пол

            // Добавить в базу данных
            addButton.Click += AddToDataBase_Click;

            // Изменить позицию
            changeButton.Click += ChangeInDataBase_Click;

            // Сохранить
            saveButton.Click += SaveButton_Click;

            // Найти
            findButton.Click += FindButton_Click;

            // Изменение даты рождения
            monthCalendar1.DateChanged += MonthCalendar1_DateChanged;
        }

        private void FindButton_Click(object sender, EventArgs e) {
            outputInForm(findElement(findField.Text));
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            saveFile();
        }
        private void ChangeInDataBase_Click(object sender, EventArgs e) {
            change();
        }

        private void AddToDataBase_Click(object sender, EventArgs e) {
            add();
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {
            dateOfBirth.Text = e.End.ToShortDateString();
        }

        private void change() {
            if (mutableTicket != null) {
                if (correct()) {
                    Ticket added = getTicket();

                    // Добавляем новую
                    WWS.tickets.Add(added);

                    // Удаляем старую
                    WWS.tickets.Remove(mutableTicket);

                    someMessage.Text = "Элемент изменен!";

                    mutableTicket = null;
                } else {
                    someMessage.Text = "Проверьте правильность полей!";
                }
            } else {
                someMessage.Text = "Сначала воспользутесь поиском и найдите элемент!";
            }
        }

        private bool add() {
            // Проверка доступности выбранного места
            if (!WWS.places.Contains((int)place.Value)) {
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
                        someMessage.Text = "Такой человек уже есть!";
                        return false;
                    }
                }
            } else {
                someMessage.Text = "Место уже занято";
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
                someMessage.Text = "Запись найдена!";

                string[] outputText = ticket.ToString().Split(';');

                serialAndNumberOfPassport.Text = outputText[0] + outputText[1];
                from.Text = outputText[2];
                to.Text = outputText[3];
                time.Text = outputText[4];

                switch (outputText[5]) {
                    case "Загранпаспорт РФ":
                        document.SelectedIndex = 0;
                        break;
                    case "Иностранный документ":
                        document.SelectedIndex = 1;
                        break;
                    case "Паспорт РФ":
                        document.SelectedIndex = 2;
                        break;
                    case "Свидетельство о рождении":
                        document.SelectedIndex = 3;
                        break;
                }

                firstName.Text = outputText[6];
                lastName.Text = outputText[7];
                middleName.Text = outputText[8];
                dateOfBirth.Text = outputText[9];

                place.Text = outputText[10];

                gender.SelectedIndex = outputText[11].Trim() == "Мужской" ? 0 : 1;

                mutableTicket = ticket;

                return;
            }

            mutableTicket = null;

            someMessage.Text = "Запись не найдена!";
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
                someMessage.Text = "Ошибка! " + io.Message;
                return false;
            }
        }

        // Метод проверки правильности введенных данных
        private bool correct() {
            int x = 0, y = 0;
            try {
                x = Convert.ToInt32(time.Text.Split(':')[0]);
                y = Convert.ToInt32(time.Text.Split(':')[1]);
            } catch (FormatException) {
                someMessage.Text = "Проверьте поле \"Время\"";
                return false;
            }

            if (from.Text.Length == 0 || to.Text.Length == 0 || firstName.Text.Length == 0 || lastName.Text.Length == 0 || middleName.Text.Length == 0) {
                someMessage.Text = "Проверьте правильность введенных данных";
                return false;
            } else if (x > 23 || y > 59) {
                someMessage.Text = "Проверьте правильность поля \"Время\"";
                return false;
            } else if (serialAndNumberOfPassport.Text.Length < 11) {
                someMessage.Text = "Проверьте правильность поля \"Серия и номер паспорта\"";
                return false;
            } else {
                return true;
            }
        }
    }
}
