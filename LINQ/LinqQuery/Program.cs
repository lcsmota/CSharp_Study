IList<string> languages = new List<string>
{
    "C#",
    "Java",
    "C++",
    "Ruby",
    "Rust",
    "JavaScript",
    "PHP",
    "Python",
    "Elixir",
    "Lua",
    "Haskell"
};

var result = from lang in languages
             where lang.Contains("u")
             select lang;

foreach (var rst in result)
    Console.WriteLine(rst);

var result2 = languages.Where(e => e.Contains("a"));
foreach (var rst2 in result2)
    Console.WriteLine(rst2);