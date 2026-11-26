namespace Kindergarten
{
    /// Воспитатель детского сада
    public class Teacher
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public string Phone { get; set; }
        public int Experience { get; set; }

        // Строка для сохранения в файл
        public string ToLine()
        {
            return Id + ";" + Fio + ";" + Phone + ";" + Experience;
        }

        // Создание объекта из строки файла
        public static Teacher FromLine(string line)
        {
            string[] parts = line.Split(';');
            Teacher t = new Teacher();
            t.Id = int.Parse(parts[0]);
            t.Fio = parts[1];
            t.Phone = parts[2];
            t.Experience = int.Parse(parts[3]);
            return t;
        }

        public override string ToString()
        {
            return Fio;
        }
    }
}
