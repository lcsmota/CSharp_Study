#region LINQ Query Syntax and Query Method
// IList<string> languages = new List<string>
// {
//     "C#",
//     "Java",
//     "C++",
//     "Ruby",
//     "Rust",
//     "JavaScript",
//     "PHP",
//     "Python",
//     "Elixir",
//     "Lua",
//     "Haskell"
// };

// var result = from lang in languages
//              where lang.Contains("u")
//              select lang;

// foreach (var rst in result)
//     Console.WriteLine(rst);

// var result2 = languages.Where(e => e.Contains("a"));
// foreach (var rst2 in result2)
//     Console.WriteLine(rst2);

#endregion

#region Lambda Expression, Func, Action, Query Operator: Where 
// IList<Student> students = new List<Student>()
// {
//     new Student() {Id = 1, Name = "Bill", Age = 25},
//     new Student() {Id = 2, Name = "John", Age = 35},
//     new Student() {Id = 3, Name = "Mary", Age = 22},
//     new Student() {Id = 4, Name = "Ricardo", Age = 32},
//     new Student() {Id = 5, Name = "Sophie", Age = 17},
//     new Student() {Id = 6, Name = "Josh", Age = 55},
//     new Student() {Id = 7, Name = "Aaron", Age = 67},
//     new Student() {Id = 7, Name = "Julia", Age = 14},
//     new Student() {Id = 7, Name = "Gustavo", Age = 19},
//     new Student() {Id = 7, Name = "Mirian", Age = 11}
// };

// Func<Student, bool> isStudentTeenAger = e => e.Age > 12 && e.Age < 20;
// Action<Student> PrintStudentDetail = e => Console.WriteLine($"\t{e.Name} - {e.Age}");

// var filteredAdultStudents = from adult in students
//                             where adult.Age > 18
//                             select adult;

// var filteredTeenAgerStudents = students.Where(isStudentTeenAger).ToList<Student>();

// var filteredStudentsWithIndex = students.Where((std, index) =>
// {
//     if (index % 2 == 0) return true;

//     return false;
// });

// Console.WriteLine();
// foreach (var std in filteredStudentsWithIndex)
//     PrintStudentDetail(std);

// Console.WriteLine("Teen: ");
// foreach (var teen in filteredTeenAgerStudents)
//     PrintStudentDetail(teen);

// Console.WriteLine("Adult: ");
// foreach (var adult in filteredAdultStudents)
//     PrintStudentDetail(adult);

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }
// }
#endregion

#region Query Operator: OfType
// IList<object> mixedList = new List<object>();
// mixedList.Add(0);
// mixedList.Add("One");
// mixedList.Add("Juca Monteiro");
// mixedList.Add(3);
// mixedList.Add(new Person { Name = "Karlos", Age = 25 });

// var stringResult = from result in mixedList.OfType<string>()
//                    select result;

// var intResult = from result in mixedList.OfType<int>()
//                 select result;

// var objectResult = mixedList.OfType<Person>();

// Console.WriteLine("String type:");
// foreach (var str in stringResult)
//     Console.WriteLine(str);

// Console.WriteLine("Int type:");
// foreach (var integer in intResult)
//     Console.WriteLine(integer);

// Console.WriteLine("Object type:");
// foreach (var obj in objectResult)
//     Console.WriteLine(obj.ToString());

// class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public override string ToString()
//         => $"{Name} - {Age}";
// }
#endregion

#region Query Operator: OrderBy and OrderByDescending
// IList<Student> students = new List<Student>()
// {
//     new Student() { Id = 1, Name = "John", Age = 18 },
//     new Student() { Id = 2, Name = "Mary", Age = 32 },
//     new Student() { Id = 3, Name = "Josh", Age = 29 },
//     new Student() { Id = 4, Name = "Aaron", Age = 24 },
//     new Student() { Id = 5, Name = "Alysson", Age = 56 },
//     new Student() { Id = 6, Name = "Karlos", Age = 43 },
// };

// var orderByResult = from std in students
//                     orderby std.Name
//                     select std;

// var orderByDescendingResult = from std in students
//                               orderby std.Age descending
//                               select std;

// var orderByMultipleSorting = from std in students
//                              orderby std.Name, std.Age
//                              select new { std.Name, std.Age };

// var studentsInDescOrder = students.OrderByDescending(e => e.Id);

// Console.WriteLine("OrderBy: Name");
// foreach (var stdsAsc in orderByResult)
//     Console.WriteLine(stdsAsc.ToString());

// Console.WriteLine("OrderByDescending: Age");
// foreach (var stdsDes in orderByDescendingResult)
//     Console.WriteLine(stdsDes.ToString());

// Console.WriteLine("OrderByMultipleSorting: Name and Age");
// foreach (var stdsMultSort in orderByMultipleSorting)
//     Console.WriteLine(stdsMultSort.ToString());

// Console.WriteLine("OrderByDescending Method: Id");
// foreach (var stdsDesMeth in studentsInDescOrder)
//     Console.WriteLine(stdsDesMeth.ToString());
// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public override string ToString()
//         => $"\t{Id}: {Name} - {Age}";
// }

#endregion

#region Query Operator: ThenBy and ThenByDescending
// IList<Person> people = new List<Person>()
// {
//     new Person() {Id = 1, Name = "Juca", Age = 25},
//     new Person() {Id = 2, Name = "Maria", Age = 32},
//     new Person() {Id = 3, Name = "Karlos", Age = 17},
//     new Person() {Id = 4, Name = "Mattheus", Age = 56},
//     new Person() {Id = 5, Name = "Maria", Age = 14},
//     new Person() {Id = 6, Name = "Eduardo", Age = 39},
//     new Person() {Id = 7, Name = "Maria", Age = 73}
// };

// var thenByResult = people.OrderBy(e => e.Name).ThenBy(e => e.Age);
// var thenByDescResult = people.OrderBy(e => e.Name).ThenByDescending(e => e.Age);

// Console.WriteLine("OrderBy: Name & ThenBy: Age");
// foreach (var person in thenByResult)
//     Console.WriteLine(person.ToString());

// Console.WriteLine("OrderBy: Name & ThenByDescending: Age");
// foreach (var person in thenByDescResult)
//     Console.WriteLine(person.ToString());

// class Person
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public override string ToString()
//         => $"\t{Name} - {Age}";
// }

#endregion

#region Query Operator: GroupBy and ToLookup
// IList<Student> students = new List<Student>()
// {
//     new Student() {Id = 1, Name = "Karlos", Age = 26, Job = "Dev Backend", Gender = "Male"},
//     new Student() {Id = 2, Name = "Juca", Age = 34, Job = "Dev Frontend", Gender = "Male"},
//     new Student() {Id = 3, Name = "Mary", Age = 29, Job = "DevOps", Gender = "Female"},
//     new Student() {Id = 4, Name = "Nicole", Age = 26, Job = "Dev Backend", Gender = "Female"},
//     new Student() {Id = 5, Name = "Nancy", Age = 34, Job = "Dev Backend", Gender = "Female"},
//     new Student() {Id = 6, Name = "Robert", Age = 29, Job = "Dev Frontend", Gender = "Male"},
//     new Student() {Id = 6, Name = "Gustavo", Age = 57, Job = "DevOps", Gender = "Male"},
//     new Student() {Id = 6, Name = "John", Age = 61, Job = "DevOps", Gender = "Male"}
// };

// var groupedResult = from std in students
//                     group std by std.Age;

// var secondGroupedResult = students.GroupBy(e => e.Job);

// var thirdGroupResult = students.ToLookup(e => e.Gender);

// foreach (var ageGroup in groupedResult)
// {
//     Console.WriteLine($"Age Group: {ageGroup.Key}");

//     foreach (var std in ageGroup)
//         Console.WriteLine(std.ToString());
// }

// Console.WriteLine();

// foreach (var jobGroup in secondGroupedResult)
// {
//     Console.WriteLine($"Job Group: {jobGroup.Key}");

//     foreach (var std in jobGroup)
//         Console.WriteLine(std.ToString());
// }

// Console.WriteLine();

// foreach (var genderGroup in thirdGroupResult)
// {
//     Console.WriteLine($"Gender Group: {genderGroup.Key}");

//     foreach (var std in genderGroup)
//         Console.WriteLine(std.ToString());
// }

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public string Job { get; set; }
//     public string Gender { get; set; }

//     public override string ToString()
//         => $"\t{Name}";
// }
#endregion

#region Query Operator: Join
// IList<Student> students = new List<Student>()
// {
//     new Student() { Id = 1, Name = "Karlos", StandardId = 1},
//     new Student() { Id = 1, Name = "Mary", StandardId = 3},
//     new Student() { Id = 1, Name = "Juca", StandardId = 2},
//     new Student() { Id = 1, Name = "Eduardo", StandardId = 12},
//     new Student() { Id = 1, Name = "Mario", StandardId = 7},
//     new Student() { Id = 1, Name = "Katia"},
//     new Student() { Id = 1, Name = "Bia"},
// };

// IList<Standard> standards = new List<Standard>()
// {
//     new Standard() {StandardId = 1, StandardName = "Standard 1"},
//     new Standard() {StandardId = 2, StandardName = "Standard 2"},
//     new Standard() {StandardId = 3, StandardName = "Standard 3"},
//     new Standard() {StandardId = 7, StandardName = "Standard 7"},
//     new Standard() {StandardId = 12, StandardName = "Standard 12"},
// };

// var innerJoinQuery = from student in students
//                      join standard in standards
//                      on student.StandardId equals standard.StandardId
//                      select new
//                      {
//                          StandardName = standard.StandardName,
//                          StudentName = student.Name
//                      };

// var innerJoinMethod = students.Join(
//     standards,
//     student => student.StandardId,
//     standard => standard.StandardId,
//     (student, standard) => new
//     {
//         StudentName = student.Name,
//         StandardName = standard.StandardName
//     }
// );

// foreach (var std in innerJoinQuery)
//     Console.WriteLine($"\t{std.StandardName} - {std.StudentName}");

// Console.WriteLine();

// foreach (var std in innerJoinMethod)
//     Console.WriteLine($"\t{std.StudentName} - {std.StandardName}");

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int StandardId { get; set; }
// }

// class Standard
// {
//     public int StandardId { get; set; }
//     public string StandardName { get; set; }
// }

#endregion

#region Query Operator: GroupJoin
// IList<Student> students = new List<Student>()
// {
//     new Student() { Id = 1, Name = "Karlos", StandardId = 1},
//     new Student() { Id = 2, Name = "Mary", StandardId = 3},
//     new Student() { Id = 3, Name = "Juca", StandardId = 2},
//     new Student() { Id = 4, Name = "Eduardo", StandardId = 12},
//     new Student() { Id = 5, Name = "Mario", StandardId = 2},
//     new Student() { Id = 6, Name = "Katia", StandardId = 7},
//     new Student() { Id = 7, Name = "Bia", StandardId = 1},
//     new Student() { Id = 8, Name = "Mirian"},
//     new Student() { Id = 9, Name = "Anna", StandardId = 1},
// };

// IList<Standard> standards = new List<Standard>()
// {
//     new Standard() {StandardId = 1, StandardName = "Standard 1"},
//     new Standard() {StandardId = 2, StandardName = "Standard 2"},
//     new Standard() {StandardId = 3, StandardName = "Standard 3"},
//     new Standard() {StandardId = 7, StandardName = "Standard 7"},
//     new Standard() {StandardId = 12, StandardName = "Standard 12"},
// };

// var groupJoinMethod = standards.GroupJoin(
//     students,
//     student => student.StandardId,
//     standard => standard.StandardId,
//     (student, studentsGroup) => new
//     {
//         Students = studentsGroup,
//         StandardName = student.StandardName
//     }
// );

// var groupJoinQuery = from standard in standards
//                      join student in students
//                      on standard.StandardId equals student.StandardId
//                      into studentGroup
//                      select new
//                      {
//                          Students = studentGroup,
//                          StandardName = standard.StandardName
//                      };

// foreach (var item in groupJoinMethod)
// {
//     Console.WriteLine(item.StandardName);

//     foreach (var stud in item.Students)
//         Console.WriteLine(stud.ToString());
// }

// Console.WriteLine();

// foreach (var item in groupJoinQuery)
// {
//     Console.WriteLine(item.StandardName);

//     foreach (var stud in item.Students)
//         Console.WriteLine(stud.ToString());
// }

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int StandardId { get; set; }

//     public override string ToString() => $"\t{Name}";
// }

// class Standard
// {
//     public int StandardId { get; set; }
//     public string StandardName { get; set; }
// }

#endregion

#region Query Operator: Select and SelectMany
IList<Student> students = new List<Student>()
{
    new Student() { Id = 1, Name = "John", Gender = "Male", Age = 25},
    new Student() { Id = 2, Name = "Aaron", Gender = "Male", Age = 32},
    new Student() { Id = 3, Name = "Karlos", Gender = "Male", Age = 17},
    new Student() { Id = 3, Name = "Fabiana", Gender = "Male", Age = 19},
    new Student() { Id = 4, Name = "Robert", Gender = "Male", Age = 28},
    new Student() { Id = 5, Name = "Anny", Gender = "Female", Age = 23},
    new Student() { Id = 6, Name = "Mary", Gender = "Female", Age = 46}
};

var listName = from student in students
               select student.Name;

var listNameAndGender = from student in students
                        select new
                        {
                            Name = $"Hello, {student.Name}",
                            Gender = student.Gender
                        };

var listNameAndAge = students.Select(std => new { Name = $"My is {std.Name}", Age = std.Age });

Console.WriteLine("Name: ");
foreach (var name in listName)
    Console.WriteLine($"\t{name}");

Console.WriteLine("Name and Gender: ");
foreach (var studInfo in listNameAndGender)
    Console.WriteLine($"\t{studInfo.Name} - {studInfo.Gender}");

Console.WriteLine("Name and Age: ");
foreach (var studInfo in listNameAndAge)
    Console.WriteLine($"\t{studInfo.Name} - {studInfo.Age}");

Console.WriteLine();
List<string> phrases = new() { "an apple a day", "the quick brown fox" };

var query = from phrase in phrases
            from word in phrase.Split(' ')
            select word;

foreach (string str in query)
    Console.WriteLine(str);
class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
}
#endregion










