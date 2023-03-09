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
IList<Person> people = new List<Person>()
{
    new Person() {Id = 1, Name = "Juca", Age = 25},
    new Person() {Id = 2, Name = "Maria", Age = 32},
    new Person() {Id = 3, Name = "Karlos", Age = 17},
    new Person() {Id = 4, Name = "Mattheus", Age = 56},
    new Person() {Id = 5, Name = "Maria", Age = 14},
    new Person() {Id = 6, Name = "Eduardo", Age = 39},
    new Person() {Id = 7, Name = "Maria", Age = 73}
};

var thenByResult = people.OrderBy(e => e.Name).ThenBy(e => e.Age);
var thenByDescResult = people.OrderBy(e => e.Name).ThenByDescending(e => e.Age);

Console.WriteLine("OrderBy: Name & ThenBy: Age");
foreach (var person in thenByResult)
    Console.WriteLine(person.ToString());

Console.WriteLine("OrderBy: Name & ThenByDescending: Age");
foreach (var person in thenByDescResult)
    Console.WriteLine(person.ToString());

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
        => $"\t{Name} - {Age}";
}

#endregion




















