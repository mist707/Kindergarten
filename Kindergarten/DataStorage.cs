using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Kindergarten
{
    /// Хранение данных в текстовых файлах (по одной записи в строке, поля через ";")
    public static class DataStorage
    {
        public static List<Child> Children = new List<Child>();
        public static List<Group> Groups = new List<Group>();
        public static List<Teacher> Teachers = new List<Teacher>();

        static string ChildrenFile = Path.Combine(Application.StartupPath, "children.txt");
        static string GroupsFile = Path.Combine(Application.StartupPath, "groups.txt");
        static string TeachersFile = Path.Combine(Application.StartupPath, "teachers.txt");
        static string AdminFile = Path.Combine(Application.StartupPath, "admin.txt");

        // Загрузка всех данных из файлов
        public static void Load()
        {
            if (!File.Exists(TeachersFile) && !File.Exists(GroupsFile) && !File.Exists(ChildrenFile))
            {
                CreateDemoData();
                Save();
                return;
            }

            Teachers.Clear();
            Groups.Clear();
            Children.Clear();

            try
            {
                if (File.Exists(TeachersFile))
                    foreach (string line in File.ReadAllLines(TeachersFile, Encoding.UTF8))
                        if (line.Trim() != "") Teachers.Add(Teacher.FromLine(line));

                if (File.Exists(GroupsFile))
                    foreach (string line in File.ReadAllLines(GroupsFile, Encoding.UTF8))
                        if (line.Trim() != "") Groups.Add(Group.FromLine(line));

                if (File.Exists(ChildrenFile))
                    foreach (string line in File.ReadAllLines(ChildrenFile, Encoding.UTF8))
                        if (line.Trim() != "") Children.Add(Child.FromLine(line));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка чтения файлов данных: " + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Сохранение всех данных в файлы
        public static void Save()
        {
            List<string> lines = new List<string>();
            foreach (Teacher t in Teachers) lines.Add(t.ToLine());
            File.WriteAllLines(TeachersFile, lines, Encoding.UTF8);

            lines = new List<string>();
            foreach (Group g in Groups) lines.Add(g.ToLine());
            File.WriteAllLines(GroupsFile, lines, Encoding.UTF8);

            lines = new List<string>();
            foreach (Child c in Children) lines.Add(c.ToLine());
            File.WriteAllLines(ChildrenFile, lines, Encoding.UTF8);
        }

        // Проверка логина и пароля заведующей
        public static bool CheckLogin(string login, string password)
        {
            if (!File.Exists(AdminFile))
                File.WriteAllText(AdminFile, "admin;12345", Encoding.UTF8);

            string[] parts = File.ReadAllText(AdminFile, Encoding.UTF8).Trim().Split(';');
            return parts.Length == 2 && parts[0] == login && parts[1] == password;
        }

        // ----- Новые номера записей -----
        public static int NextChildId()
        {
            int max = 0;
            foreach (Child c in Children) if (c.Id > max) max = c.Id;
            return max + 1;
        }

        public static int NextGroupId()
        {
            int max = 0;
            foreach (Group g in Groups) if (g.Id > max) max = g.Id;
            return max + 1;
        }

        public static int NextTeacherId()
        {
            int max = 0;
            foreach (Teacher t in Teachers) if (t.Id > max) max = t.Id;
            return max + 1;
        }

        // ----- Поиск по номеру -----
        public static Child FindChild(int id)
        {
            foreach (Child c in Children) if (c.Id == id) return c;
            return null;
        }

        public static Group FindGroup(int id)
        {
            foreach (Group g in Groups) if (g.Id == id) return g;
            return null;
        }

        public static Teacher FindTeacher(int id)
        {
            foreach (Teacher t in Teachers) if (t.Id == id) return t;
            return null;
        }

        public static string GetGroupName(int groupId)
        {
            Group g = FindGroup(groupId);
            return g == null ? "—" : g.Name;
        }

        public static string GetTeacherName(int teacherId)
        {
            Teacher t = FindTeacher(teacherId);
            return t == null ? "не назначен" : t.Fio;
        }

        // Количество детей в группе
        public static int CountChildren(int groupId)
        {
            int count = 0;
            foreach (Child c in Children) if (c.GroupId == groupId) count++;
            return count;
        }

        // Группа, которую ведёт воспитатель (или null)
        public static Group GetGroupOfTeacher(int teacherId)
        {
            foreach (Group g in Groups) if (g.TeacherId == teacherId) return g;
            return null;
        }

        // Тестовые данные при первом запуске
        static void CreateDemoData()
        {
            Teachers.Add(new Teacher { Id = 1, Fio = "Иванова Мария Сергеевна", Phone = "+7 918 123-45-67", Experience = 12 });
            Teachers.Add(new Teacher { Id = 2, Fio = "Петрова Анна Викторовна", Phone = "+7 918 234-56-78", Experience = 7 });
            Teachers.Add(new Teacher { Id = 3, Fio = "Сидорова Елена Павловна", Phone = "+7 961 345-67-89", Experience = 3 });
            Teachers.Add(new Teacher { Id = 4, Fio = "Кузнецова Ольга Игоревна", Phone = "+7 988 456-78-90", Experience = 15 });

            Groups.Add(new Group { Id = 1, Name = "Солнышко", AgeCategory = "Младшая (3-4 года)", MaxCount = 20, TeacherId = 1 });
            Groups.Add(new Group { Id = 2, Name = "Звёздочки", AgeCategory = "Средняя (4-5 лет)", MaxCount = 22, TeacherId = 2 });
            Groups.Add(new Group { Id = 3, Name = "Радуга", AgeCategory = "Старшая (5-6 лет)", MaxCount = 25, TeacherId = 4 });

            Children.Add(new Child { Id = 1, Fio = "Смирнов Артём Алексеевич", BirthDate = new DateTime(2022, 3, 14), Gender = "М", GroupId = 1, ParentFio = "Смирнова Ирина Олеговна", ParentPhone = "+7 918 111-22-33" });
            Children.Add(new Child { Id = 2, Fio = "Ковалёва София Денисовна", BirthDate = new DateTime(2022, 7, 2), Gender = "Ж", GroupId = 1, ParentFio = "Ковалёв Денис Андреевич", ParentPhone = "+7 918 222-33-44" });
            Children.Add(new Child { Id = 3, Fio = "Морозов Иван Петрович", BirthDate = new DateTime(2021, 11, 20), Gender = "М", GroupId = 2, ParentFio = "Морозова Анна Сергеевна", ParentPhone = "+7 961 333-44-55" });
            Children.Add(new Child { Id = 4, Fio = "Волкова Алиса Романовна", BirthDate = new DateTime(2021, 5, 9), Gender = "Ж", GroupId = 2, ParentFio = "Волков Роман Ильич", ParentPhone = "+7 988 444-55-66" });
            Children.Add(new Child { Id = 5, Fio = "Лебедев Максим Олегович", BirthDate = new DateTime(2020, 9, 30), Gender = "М", GroupId = 3, ParentFio = "Лебедева Ольга Ивановна", ParentPhone = "+7 918 555-66-77" });
            Children.Add(new Child { Id = 6, Fio = "Новикова Ева Артёмовна", BirthDate = new DateTime(2020, 12, 17), Gender = "Ж", GroupId = 3, ParentFio = "Новиков Артём Сергеевич", ParentPhone = "+7 961 666-77-88" });
            Children.Add(new Child { Id = 7, Fio = "Фёдоров Тимофей Ильич", BirthDate = new DateTime(2020, 4, 5), Gender = "М", GroupId = 3, ParentFio = "Фёдорова Мария Андреевна", ParentPhone = "+7 988 777-88-99" });
        }
    }
}
