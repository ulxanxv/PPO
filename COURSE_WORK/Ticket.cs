using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Gen {
    Male,
    Famale
}

public class Ticket {
    private Gen gender;
    private string time;
    private int    place;
    private string from;
    private string to;
    private string document;
    private string firstName;
    private string middleName;
    private string lastName;
    private string birthDay;
    private string serial;
    private string number;

    public string Serial { get => serial; set => serial = value; }
    public string Number { get => number; set => number = value; }
    public string From { get => from; set => from = value; }
    public string To { get => to; set => to = value; }
    public string Time { get => time; set => time = value; }
    public string Document { get => document; set => document = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string MiddleName { get => middleName; set => middleName = value; }
    public string LastName { get => lastName; set => lastName = value; }
    public string BirthDay { get => birthDay; set => birthDay = value; }
    public int Place { get => place; set => place = value; }
    public string Gender {
        get {
            return gender == 0 ? "Мужской" : "Женский";
        }
    }

    public Ticket(string uniqNumber) {
        this.Serial = uniqNumber.Split(' ')[0].Trim();
        this.Number = uniqNumber.Split(' ')[1].Trim();
    }

    public Ticket(string[] info) {
        loadInfo(info);
    }

    private void loadInfo(string[] info) {
        this.Serial =     info[0].Split(' ')[0].Trim();
        this.Number =     info[0].Split(' ')[1].Trim();

        this.From =       info[1];
        this.To =         info[2];
        this.Time =       info[3];
        this.Document =   info[4];
        this.FirstName =  info[5];
        this.MiddleName = info[6];
        this.LastName =   info[7];
        this.BirthDay =   info[8];
        this.Place =      Convert.ToInt32(info[9]);

        this.gender =     info[10][0] == 'М' || info[10][0] == 'M' ? Gen.Male : Gen.Famale;
    }

    public override bool Equals(object obj) {
        if (obj == null || obj.GetType() != this.GetType())
            return false;
        if ((obj as Ticket).Serial == Serial &&
            (obj as Ticket).Number == Number)
            return true;
        return false;
    }

    public override string ToString() {
        return Serial + ";" + Number + ";" + From + ";" + To + ";" + Time + ";" + Document
               + ";" + FirstName + ";" + MiddleName + ";" + LastName + ";" + BirthDay
               + ";" + Place + ";" + (gender == Gen.Male ? "Мужской" : "Женский") + "\n";
    }
}
