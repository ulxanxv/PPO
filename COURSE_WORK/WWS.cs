using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

abstract class WWS {
    public static BindingList<Ticket> tickets = new BindingList<Ticket>();
    public static SortedSet<int> places = new SortedSet<int>();


    public static string path = @"dataBase.txt";

    // Загрузка данных в программу
    public static string loadData() {
        string[] allData = File.ReadAllText(path).Split('\n');

        if (allData.Length == 1) {
            return "База данных пуста";
        } else {
            for (int i = 0; i < allData.Length - 1; i++) {
                Ticket ticket = new Ticket(allData[i].Split(';'));

                tickets.Add(ticket);
                places.Add(ticket.Place);
            } return "База данных загружена в программу";
        }
    }
}
