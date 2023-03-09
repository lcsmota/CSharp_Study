// #region LINQ Query Syntax and Query Method
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

// #endregion

#region Lambda Expression, Func, Action, Query Operator: Where 
IList<Student> students = new List<Student>()
{
    new Student() {Id = 1, Name = "Bill", Age = 25},
    new Student() {Id = 2, Name = "John", Age = 35},
    new Student() {Id = 3, Name = "Mary", Age = 22},
    new Student() {Id = 4, Name = "Ricardo", Age = 32},
    new Student() {Id = 5, Name = "Sophie", Age = 17},
    new Student() {Id = 6, Name = "Josh", Age = 55},
    new Student() {Id = 7, Name = "Aaron", Age = 67},
    new Student() {Id = 7, Name = "Julia", Age = 14},
    new Student() {Id = 7, Name = "Gustavo", Age = 19},
    new Student() {Id = 7, Name = "Mirian", Age = 11}
};

Func<Student, bool> isStudentTeenAger = e => e.Age > 12 && e.Age < 20;
Action<Student> PrintStudentDetail = e => Console.WriteLine($"\t{e.Name} - {e.Age}");

var filteredAdultStudents = from adult in students
                            where adult.Age > 18
                            select adult;

var filteredTeenAgerStudents = students.Where(isStudentTeenAger).ToList<Student>();

var filteredStudentsWithIndex = students.Where((std, index) =>
{
    if (index % 2 == 0) return true;

    return false;
});

Console.WriteLine();
foreach (var std in filteredStudentsWithIndex)
    PrintStudentDetail(std);

Console.WriteLine("Teen: ");
foreach (var teen in filteredTeenAgerStudents)
    PrintStudentDetail(teen);

Console.WriteLine("Adult: ");
foreach (var adult in filteredAdultStudents)
    PrintStudentDetail(adult);

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}
#endregion

