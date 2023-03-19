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
// IList<Student> students = new List<Student>()
// {
//     new Student() { Id = 1, Name = "John", Gender = "Male", Age = 25},
//     new Student() { Id = 2, Name = "Aaron", Gender = "Male", Age = 32},
//     new Student() { Id = 3, Name = "Karlos", Gender = "Male", Age = 17},
//     new Student() { Id = 3, Name = "Fabiana", Gender = "Male", Age = 19},
//     new Student() { Id = 4, Name = "Robert", Gender = "Male", Age = 28},
//     new Student() { Id = 5, Name = "Anny", Gender = "Female", Age = 23},
//     new Student() { Id = 6, Name = "Mary", Gender = "Female", Age = 46}
// };

// var listName = from student in students
//                select student.Name;

// var listNameAndGender = from student in students
//                         select new
//                         {
//                             Name = $"Hello, {student.Name}",
//                             Gender = student.Gender
//                         };

// var listNameAndAge = students.Select(std => new { Name = $"My is {std.Name}", Age = std.Age });

// Console.WriteLine("Name: ");
// foreach (var name in listName)
//     Console.WriteLine($"\t{name}");

// Console.WriteLine("Name and Gender: ");
// foreach (var studInfo in listNameAndGender)
//     Console.WriteLine($"\t{studInfo.Name} - {studInfo.Gender}");

// Console.WriteLine("Name and Age: ");
// foreach (var studInfo in listNameAndAge)
//     Console.WriteLine($"\t{studInfo.Name} - {studInfo.Age}");

// Console.WriteLine();
// List<string> phrases = new() { "an apple a day", "the quick brown fox" };

// var query = from phrase in phrases
//             from word in phrase.Split(' ')
//             select word;

// foreach (string str in query)
//     Console.WriteLine(str);
// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public string Gender { get; set; }
//     public int Age { get; set; }
// }
#endregion

#region Query Operator: All and Any
// IList<Student> students = new List<Student>()
// {
//     new Student("Juca", "Male", 39),
//     new Student("Mary", "Female", 12),
//     new Student("Nicole", "Female", 18),
//     new Student("Karlos", "Male", 43),
//     new Student("Eduardo", "Male", 17),
// };

// bool areAllStudentsTeenAger = students.All(e => e.Age > 12 && e.Age < 20);
// bool areAllStudentsMale = students.All(e => e.Gender.Equals("Male"));

// bool isAnyStudentTeenAger = students.Any(e => e.Age > 12 && e.Age < 20);
// bool isAnyStudentFemale = students.Any(e => e.Gender.Equals("Female"));

// Console.WriteLine($"{areAllStudentsTeenAger}\n{areAllStudentsMale}");
// Console.WriteLine($"{isAnyStudentTeenAger}\n{isAnyStudentFemale}");

// public record Student(string Name, string Gender, int Age);

#endregion

#region Query Operator: Contains
// using System.Diagnostics.CodeAnalysis;

// IList<Student> students = new List<Student>()
// {
//     new Student() {Id = 1, Name = "Karlos", Age = 57},
//     new Student() {Id = 2, Name = "Anny", Age = 27},
//     new Student() {Id = 3, Name = "Lucas", Age = 33},
//     new Student() {Id = 4, Name = "Josh", Age = 16}
// };

// var stud = new Student() { Id = 1, Name = "Karlos" };

// var hasStudent = students.Contains(stud, new StudentComparer());

// Console.WriteLine(hasStudent);
// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public override string ToString()
//         => $"{Id}: {Name} - {Age}";
// }

// class StudentComparer : IEqualityComparer<Student>
// {
//     public bool Equals(Student? x, Student? y)
//     {
//         if (x?.Id == y?.Id && x?.Name == y?.Name)
//             return true;

//         return false;
//     }

//     public int GetHashCode([DisallowNull] Student obj)
//         => obj.GetHashCode();
// }
#endregion

#region Query Operator: Aggregate
// IList<string> strs = new List<string>()
// {
//     "Marcos", "Mary", "Josh", "Nicole", "Karlos"
// };

// var commaSeperatedString = strs.Aggregate((firstStr, secondStr) => $"{firstStr}, {secondStr}");
// Console.WriteLine(commaSeperatedString);

// IList<Student> students = new List<Student>()
// {
//     new Student("John", 23),
//     new Student("Moin", 51),
//     new Student("Ram", 19),
//     new Student("Ron", 34),
//     new Student("Bill", 47)
// };

// var commaSeperatedStudentNames =
//     students.Aggregate<Student, string>(
//         "Student Names: ",
//         (str, stud) => str += $"{stud.Name}, "
//     );

// var commaSeperatedStudentNamesWithoutLastComma =
//     students.Aggregate<Student, string, string>(
//         string.Empty,
//         (str, stud) => str += $"{stud.Name}, ",
//         str => str.Substring(0, str.Length - 2)
//     );

// Console.WriteLine(commaSeperatedStudentNames);
// Console.WriteLine(commaSeperatedStudentNamesWithoutLastComma);


// var sumOfStudentsAge =
//     students.Aggregate<Student, int>(0, (totalAge, stud) => totalAge += stud.Age);
// Console.WriteLine(sumOfStudentsAge);

// public record Student(string Name, int Age);

#endregion

#region Query Operator: Average, Count, Max and Sum
// IList<Person> people = new List<Person>()
// {
//     new Person() {Name = "Karlos", Age = 25},
//     new Person() {Name = "Mary", Age = 33},
//     new Person() {Name = "Juca", Age = 42},
//     new Person() {Name = "Eduardo", Age = 49},
//     new Person() {Name = "Anny", Age = 16}
// };

// var avgAge = people.Average(e => e.Age);

// var totalPeople = people.Count();
// var adult = people.Count(e => e.Age > 18);

// var totalAge = (from person in people
//                 select person.Age).Count();

// var oldest = people.Max(e => e.Age);
// var personWithLongName = people.Max();

// var sumOfAge = people.Sum(e => e.Age);
// var numOfTeenAger = people.Sum(e =>
// {
//     return e.Age > 12 && e.Age < 20
//         ? 1
//         : default;
// });

// Console.WriteLine($"Total age: {totalAge}");
// Console.WriteLine($"Average age: {avgAge}");
// Console.WriteLine($"Total of people: {totalPeople}");
// Console.WriteLine($"Total of Adult: {adult}");
// Console.WriteLine($"Oldest person age: {oldest}");
// Console.WriteLine($"Person with long name: {personWithLongName?.Name}");
// Console.WriteLine($"Total of teen: {numOfTeenAger}");
// Console.WriteLine($"Sum of age: {sumOfAge}");
// class Person : IComparable<Person>
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public int CompareTo(Person? other)
//     {
//         return this.Name.Length > other?.Name.Length
//             ? 1
//             : default;
//     }
// }
#endregion

#region Query Operator: ElementAt and ElementAtOrDefault
// IList<int> intList = new List<int>() { 12, 34, 54, 76, 87, 98, 29 };
// IList<string> intString = new List<string>() { "One", "Seven", "Four", "Five", "Nine", "Eight" };

// Console.WriteLine($"1st element in intList: {intList.ElementAt(0)}");
// Console.WriteLine($"1st element in intString: {intString.ElementAt(0)}");

// Console.WriteLine($"2nd element in intList: {intList.ElementAt(1)}");
// Console.WriteLine($"2nd element in intString: {intString.ElementAt(1)}");

// Console.WriteLine($"10th element in intList: {intList.ElementAtOrDefault(9)}");
// Console.WriteLine($"10th element in intString: {intString.ElementAtOrDefault(9)}");
#endregion

#region Query Operator: First and FirstOrDefault
// IList<int> numbers = new List<int>() { 43, 767, 121, 89, 56, 234, 568, 93 };
// IList<string> names = new List<string>() { "Juca", "null", "Robert", "Karlos", "Joana", "John", default };

// Console.WriteLine($"1st element in numbers: {numbers.First()}");
// Console.WriteLine($"1st even element in numbers: {numbers.First(x => x % 2 == 0)}");

// Console.WriteLine($"1st element in names: {names.First()}");

// Console.WriteLine($"1st element which is greater than 500 in numbers: {numbers.FirstOrDefault(x => x > 500)}");
// Console.WriteLine($"1st element contain 's' in names: {names.FirstOrDefault(x => x.Contains("s"))}");
#endregion

#region Query Operator: Last and LastOrDefault
// IList<int> numbers = new List<int>() { 43, 767, 121, 89, 56, 234, 568, 93, 879, 1024, 87 };
// IList<string> names = new List<string>() { "Juca", "Eduardo", "Robert", "Karlos", "Joana", "John", "Lucas" };

// Console.WriteLine($"Last element in numbers: {numbers.Last()}");
// Console.WriteLine($"Last even element in numbers: {numbers.Last(x => x % 2 == 0)}");

// Console.WriteLine($"Last element in names: {names.Last()}");

// Console.WriteLine($"Last element which is greater than 500 in numbers: {numbers.LastOrDefault(x => x > 500)}");
// Console.WriteLine($"Last element contain 'o' in names: {names.LastOrDefault(x => x.Contains("o"))}");
// Console.WriteLine($"Last element contain 'T' in names: {names.LastOrDefault(x => x.Contains("T"))}");

#endregion

#region Query Operator: Single and SingleOrDefault
// List<int> oneElement = new() { 26 };
// IList<int> numbers = new List<int>() { 43, 767, 121, 89, 56, 234, 568, 93, 879, 1024, 87, 8, 3 };
// IList<string> names = new List<string>() { "Juca", "Eduardo", "Robert", "Karlos", "Joana", "John", "Lucas", "Ram", "Bill", "Thaunny" };

// Console.WriteLine($"The only element in oneElement: {oneElement.Single()}");
// Console.WriteLine($"The only element which is less than 5 in numbers: {numbers.SingleOrDefault(x => x < 5)}");
// Console.WriteLine($"The only element which is greater than 1000 in numbers: {numbers.SingleOrDefault(x => x > 1000)}");

// Console.WriteLine($"The only element contain 'T' in names: {names.SingleOrDefault(x => x.Contains("T"))}");
#endregion

#region Query Operator: SequenceEqual
// using System.Diagnostics.CodeAnalysis;

// Student std1 = new("John", 25);
// Student std2 = new("Anny", 23);

// IList<Student> studentListOne = new List<Student>() { std1, std2 };
// IList<Student> studentListTwo = new List<Student>() { std1, std2 };

// bool isEqual = studentListOne.SequenceEqual(studentListTwo);
// Console.WriteLine($"studentListOne == studentListTwo: {isEqual}");

// Student std3 = new("Mary", 45);
// Student std4 = new("Karlos", 19);

// IList<Student> studentListThree = new List<Student>() { std3 };
// IList<Student> studentListFour = new List<Student>() { std4 };

// isEqual = studentListThree.SequenceEqual(studentListFour);
// Console.WriteLine($"studentListThree == studentListFour: {isEqual}");

// IList<Student> listOfStudents1 = new List<Student>()
// {
//     new Student("Josh", 56),
//     new Student("Lucas", 27),
//     new Student("Eduardo", 22),
//     new Student("Igor", 17)
// };

// IList<Student> listOfStudents2 = new List<Student>()
// {
//     new Student("Josh", 56),
//     new Student("Lucas", 27),
//     new Student("Eduardo", 22),
//     new Student("Igor", 17)
// };

// isEqual = listOfStudents1.SequenceEqual(listOfStudents2, new StudentComparer());
// Console.WriteLine($"listOfStudents1 == listOfStudents2: {isEqual}");


// public record Student(string Name, int Age);
// class StudentComparer : IEqualityComparer<Student>
// {
//     public bool Equals(Student? x, Student? y)
//     {
//         if (x?.Name == y?.Name) return true;

//         return false;
//     }

//     public int GetHashCode([DisallowNull] Student obj)
//         => obj.GetHashCode();
// }
#endregion

#region Query Operator: Concat
// IList<string> names1 = new List<string>() { "Mary", "John", "Ricardo", "Katia" };
// IList<string> names2 = new List<string>() { "Juca", "Lucas", "Robert", "Allyson" };

// var collectionOfNames = names1.Concat(names2);

// foreach (var name in collectionOfNames)
//     Console.WriteLine($"Hello, {name}.");

// IList<Student> listOfStudents1 = new List<Student>()
// {
//     new Student() { Name = "John", Age = 31},
//     new Student() { Name = "Kathia", Age = 42},
//     new Student() { Name = "Josh", Age = 39},
//     new Student() { Name = "Maria", Age = 27}
// };

// IList<Student> listOfStudents2 = new List<Student>()
// {
//     new Student() { Name = "Karlos", Age = 33},
//     new Student() { Name = "Eduardo", Age = 29},
//     new Student() { Name = "Rodrigo", Age = 56},
//     new Student() { Name = "Yanny", Age = 17}
// };

// var students = listOfStudents1.Concat(listOfStudents2);
// foreach (var stud in students)
//     Console.WriteLine(stud.ToString());
// class Student
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public override string ToString()
//         => $"My name is {Name} and I'm {Age} years old.";
// }
#endregion

#region Query Operator: DefaultIfEmpty
// IList<string> emptyList = new List<string>();

// var newList1 = emptyList.DefaultIfEmpty();
// var newList2 = emptyList.DefaultIfEmpty("None");

// Console.WriteLine($"Count: {newList1.Count()}");
// Console.WriteLine($"Value: {newList1.ElementAt(0)}");

// Console.WriteLine($"Count: {newList2.Count()}");
// Console.WriteLine($"Value: {newList2.ElementAt(0)}");

#endregion

#region Query Operator: Empty, Range and Repeat
// var emptyCollection1 = Enumerable.Empty<string>();
// var emptyCollection2 = Enumerable.Empty<bool>();

// Console.WriteLine($"Count: {emptyCollection1.Count()}");
// Console.WriteLine($"Type: {emptyCollection1.GetType().Name}");

// Console.WriteLine($"Count: {emptyCollection2.Count()}");
// Console.WriteLine($"Type: {emptyCollection2.GetType().Name}");

// var intCollection = Enumerable.Range(10, 9);
// Console.WriteLine($"Total count: {intCollection.Count()}");

// for (int i = 0; i < intCollection.Count(); i++)
//     Console.WriteLine($"Value at index {i}: {intCollection.ElementAt(i)}");

// var strCollection = Enumerable.Repeat("Never give up!", 3);
// Console.WriteLine($"Total count: {strCollection.Count()}");

// for (int i = 0; i < strCollection.Count(); i++)
//     Console.WriteLine($"Value at index {i}: {strCollection.ElementAt(i)}");

#endregion

#region Query Operator: Distinct

// using System.Diagnostics.CodeAnalysis;

// IList<Student> students = new List<Student>()
// {
//     new Student() { Id = 1, Name = "Juca", Age = 22},
//     new Student() { Id = 2, Name = "Mary", Age = 33},
//     new Student() { Id = 3, Name = "Karlos", Age = 19},
//     new Student() { Id = 2, Name = "Mary", Age = 33},
//     new Student() { Id = 5, Name = "Kathia", Age = 27},
//     new Student() { Id = 1, Name = "Juca", Age = 22},
//     new Student() { Id = 7, Name = "Mary", Age = 59}
// };

// var distinctStudents = students.Distinct(new StudentComparer());

// foreach (var stud in distinctStudents)
//     System.Console.WriteLine(stud.ToString());

// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public override string ToString()
//         => $"{Id}: {Name} - {Age}";
// }

// class StudentComparer : IEqualityComparer<Student>
// {
//     public bool Equals(Student? x, Student? y)
//     {
//         if (x?.Id == y?.Id && x?.Name.ToLower() == y?.Name.ToLower())
//             return true;

//         return false;
//     }

//     public int GetHashCode([DisallowNull] Student obj)
//         => obj.Id.GetHashCode();
// }
#endregion

#region Query Operator: Except

// using System.Diagnostics.CodeAnalysis;

// List<Person> firstGroup = new()
// {
//     new Person() {Document = "132456", Name = "Karlos", Gender = "Male", Age = 26},
//     new Person() {Document = "982452", Name = "Mary", Gender = "Female", Age = 22},
//     new Person() {Document = "234241", Name = "Eduardo", Gender = "Male", Age = 19},
//     new Person() {Document = "672456", Name = "Kathia", Gender = "Female", Age = 32},
//     new Person() {Document = "882453", Name = "Anny", Gender = "Female", Age = 38},
//     new Person() {Document = "992455", Name = "Beatriz", Gender = "Female", Age = 41}
// };

// List<Person> secondGroup = new()
// {
//     new Person() {Document = "132466", Name = "Ronaldo", Gender = "Male", Age = 29},
//     new Person() {Document = "982452", Name = "Mary", Gender = "Female", Age = 22},
//     new Person() {Document = "234241", Name = "Eduardo", Gender = "Male", Age = 19},
//     new Person() {Document = "670056", Name = "Thauany", Gender = "Female", Age = 23},
//     new Person() {Document = "882453", Name = "Anny", Gender = "Female", Age = 38},
//     new Person() {Document = "992400", Name = "Chris", Gender = "Female", Age = 33}
// };

// var thirdGroup = firstGroup.Except(secondGroup, new PersonComparer());
// var fourthGroup = secondGroup.Except(firstGroup, new PersonComparer());

// Console.WriteLine("First Group:");
// foreach (var stud in thirdGroup)
//     Console.WriteLine(stud.ToString());

// Console.WriteLine("Second Group:");
// foreach (var stud in fourthGroup)
//     Console.WriteLine(stud.ToString());

// class Person
// {
//     public string Document { get; set; }
//     public string Name { get; set; }
//     public string Gender { get; set; }
//     public int Age { get; set; }

//     public override string ToString()
//         => $"\t{Name}\t{Document}\t{Gender} - {Age}";
// }

// class PersonComparer : IEqualityComparer<Person>
// {
//     public bool Equals(Person? x, Person? y)
//     {
//         if (x?.Document == y?.Document && x?.Name.ToLower() == y?.Name.ToLower())
//             return true;

//         return false;
//     }

//     public int GetHashCode([DisallowNull] Person obj)
//         => obj.Document.GetHashCode();
// }

#endregion

#region Query Operator: Intersect

// using System.Diagnostics.CodeAnalysis;

// List<Person> firstGroupOfPeople = new()
// {
//     new Person() {Id = 1, Name = "Juca", Age = 25, Gender = "Male"},
//     new Person() {Id = 2, Name = "Karlos", Age = 49, Gender = "Male"},
//     new Person() {Id = 3, Name = "Eduardo", Age = 18, Gender = "Male"},
//     new Person() {Id = 4, Name = "Mary", Age = 33, Gender = "Female"}
// };

// List<Person> secondGroupOfPeople = new()
// {
//     new Person() {Id = 1, Name = "Juca", Age = 25, Gender = "Male"},
//     new Person() {Id = 2, Name = "Karlos", Age = 49, Gender = "Male"},
//     new Person() {Id = 6, Name = "Anny", Age = 49, Gender = "Female"},
//     new Person() {Id = 8, Name = "Kathia", Age = 49, Gender = "Female"},
//     new Person() {Id = 9, Name = "Kassandra", Age = 49, Gender = "Female"}
// };

// var thirdGroupResult = firstGroupOfPeople.Intersect(secondGroupOfPeople, new PersonComparer());

// foreach (var person in thirdGroupResult)
//     Console.WriteLine(person.ToString());

// class Person
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }
//     public string Gender { get; set; }

//     public override string ToString()
//         => $"{Name} - {Age} - Gender";
// }

// class PersonComparer : IEqualityComparer<Person>
// {
//     public bool Equals(Person? x, Person? y)
//     {
//         if (x?.Id == y?.Id && x?.Name == y?.Name)
//             return true;

//         return false;
//     }

//     public int GetHashCode([DisallowNull] Person obj)
//         => obj.Id.GetHashCode();

// }
#endregion

#region Query Operator: Union

// using System.Diagnostics.CodeAnalysis;

// List<Student> firstListOfStudents = new()
// {
//     new Student() { Id = 13, Name = "Mario", Age = 38},
//     new Student() { Id = 24, Name = "Marcos", Age = 16},
//     new Student() { Id = 53, Name = "Marcello", Age = 24},
//     new Student() { Id = 84, Name = "Marcio", Age = 27},
//     new Student() { Id = 75, Name = "Maria", Age = 42},
//     new Student() {Id = 31, Name = "Anna", Age = 19},
//     new Student() {Id = 7, Name = "Amanda", Age = 22}
// };

// List<Student> secondListOfStudents = new()
// {
//     new Student() {Id = 31, Name = "Anna", Age = 19},
//     new Student() {Id = 7, Name = "Amanda", Age = 22},
//     new Student() { Id = 53, Name = "Marcello", Age = 24},
//     new Student() { Id = 84, Name = "Marcio", Age = 27},
//     new Student() {Id = 11, Name = "Annabelle", Age = 36},
//     new Student() {Id = 91, Name = "Isadora", Age = 27}
// };

// var students = firstListOfStudents.Union(secondListOfStudents, new StudentComparer());

// foreach (var stud in students)
//     Console.WriteLine(stud.ToString());
// class Student
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public override string ToString()
//         => $"{Name} - {Age}";
// }

// class StudentComparer : IEqualityComparer<Student>
// {
//     public bool Equals(Student? x, Student? y)
//     {
//         if (x?.Id == y?.Id && x?.Name == y?.Name)
//             return true;

//         return false;
//     }

//     public int GetHashCode([DisallowNull] Student obj)
//         => obj.Id.GetHashCode();
// }
#endregion

#region Query Operator: Skip, SkipLast and SkipWhile
// List<int> numbers = new()
// {
//     1, 2, 56, 78, 11, 87, 95, 6, 232
// };

// List<string> names = new()
// {
//     "Juca", "Marcos", "Eduardo",
//     "Anny", "Kassandra", "John"
// };

// var intList = numbers.Skip(4);
// foreach (var number in intList)
//     Console.Write($"{number} ");

// Console.WriteLine();
// var nameList = names.SkipWhile(e => e.Length < 7);
// foreach (var name in nameList)
//     Console.Write($"{name} ");

// Console.WriteLine();
// var nameList2 = names.SkipLast(3);
// foreach (var name in nameList2)
//     Console.Write($"{name} ");

// Console.WriteLine();
#endregion

#region Query Operator: Take, TakeLast and TakeWhile
List<string> names = new()
{
    "Mary", "Andrea", "Gustavo",
    "Thauanny", "Laedson", "Lucas"
};

var nameList1 = names.Take(3);
foreach (var name in nameList1)
    Console.Write($"{name} ");

Console.WriteLine();
var nameList2 = names.TakeLast(3);
foreach (var name in nameList2)
    Console.Write($"{name} ");

Console.WriteLine();
var nameList3 = names.TakeWhile(e => e.Length < 5);
foreach (var name in nameList3)
    Console.Write($"{name} ");

Console.WriteLine();
#endregion














