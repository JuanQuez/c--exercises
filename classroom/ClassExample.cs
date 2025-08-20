// Loops:
// for loops: For when you know how many times the loop will repeat.
// for (int i = 0; i <= 2; i += 2)
// {
//     Console.WriteLine("Age");
//     sbyte age = sbyte.Parse(Console.ReadLine());
//     Console.WriteLine("Age is: " + age);
// }
// while loops: For when you don't know how many times the loop will repeat.
// Console.WriteLine("Age");
// sbyte age = sbyte.Parse(Console.ReadLine());
// sbyte sentinel_parameter_age = 99; // sentinel parameter

// while (age != sentinel_parameter_age)
// {
//     // when you want to do what is in the code block
//     Console.WriteLine("You may enter");
//     age = sbyte.Parse(Console.ReadLine());

//     Console.WriteLine("Age is: ");
//     age = sbyte.Parse(Console.ReadLine());
// }

// do while loops: For when you don't know how many times the loop will repeat, but it must run at least once.
// sbyte sentinel_parameter_age = 99;
// Console.WriteLine("Age: ");
// sbyte age = sbyte.Parse(Console.ReadLine());
// do
// {
//     Console.WriteLine("Age is: ");
//     age = sbyte.Parse(Console.ReadLine());
// } while (age != sentinel_parameter_age);


// array 
// array - list (string - numbers) - dictionaries
// string[] names = { "Ana", "Maria", "Jose", "Adres" };
// foreach (var name in names)
// {
//     Console.WriteLine(names);
// }

// list
// List<string> names = new List<string>() { "Ana", "Maria", "Jose", "Andres" };

// fill list
// names.Capacity;
// names.Add()
// names.Add("Ana");
// names.Add("Maria");
// names.Add("Jose"); 
// names.Add("Andres");

// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// numeric list
// List<int> years = new List<int>();

// years.Add(2001);
// years.Add(2010);
// years.Add(2020);
// years.Add(2024);

// foreach (int year in years)
// {
//     Console.WriteLine($" {year}");
// }

// dictionary (syntax)
// dictionary<key data type, value data type> dictionary_name = new Dictionary<string, int>(key data type, value data type);
// Dictionary<string, int> product_list = new Dictionary<string, int>()
// {
//    {"key" , "value"},
//    {"key" , "value"},
//    {"key" , "value"},
// };
