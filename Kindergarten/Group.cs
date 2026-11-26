namespace Kindergarten
{
    /// Группа детского сада
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AgeCategory { get; set; }
        public int MaxCount { get; set; }
        public int TeacherId { get; set; }

        public string ToLine()
        {
            return Id + ";" + Name + ";" + AgeCategory + ";" + MaxCount + ";" + TeacherId;
        }

        public static Group FromLine(string line)
        {
            string[] parts = line.Split(';');
            Group g = new Group();
            g.Id = int.Parse(parts[0]);
            g.Name = parts[1];
            g.AgeCategory = parts[2];
            g.MaxCount = int.Parse(parts[3]);
            g.TeacherId = int.Parse(parts[4]);
            return g;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
