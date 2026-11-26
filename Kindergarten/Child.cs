using System;
using System.Globalization;

namespace Kindergarten
{
    /// Ребёнок, посещающий детский сад
    public class Child
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public int GroupId { get; set; }
        public string ParentFio { get; set; }
        public string ParentPhone { get; set; }

        // Возраст ребёнка в полных годах
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        public string ToLine()
        {
            return Id + ";" + Fio + ";" + BirthDate.ToString("dd.MM.yyyy") + ";" + Gender + ";"
                + GroupId + ";" + ParentFio + ";" + ParentPhone;
        }

        public static Child FromLine(string line)
        {
            string[] parts = line.Split(';');
            Child c = new Child();
            c.Id = int.Parse(parts[0]);
            c.Fio = parts[1];
            c.BirthDate = DateTime.ParseExact(parts[2], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            c.Gender = parts[3];
            c.GroupId = int.Parse(parts[4]);
            c.ParentFio = parts[5];
            c.ParentPhone = parts[6];
            return c;
        }
    }
}
