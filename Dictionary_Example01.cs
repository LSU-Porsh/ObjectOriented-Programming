 Dictionary<string, string> records = new Dictionary<string, string>();

 records.Add("Fantasy", "Percy Jackson");
 records.Add("Greek Mythology", "Odyssey");
 records.Add("Non-Fiction", "Henry");
 Console.WriteLine("------Adding and displaying Dictionary------");
 foreach (var name in records)
 {
     Console.WriteLine($"ID: {name.Key} , Name: {name.Value}");
 }

 Console.WriteLine("------Remove item using Key------");
 records.Remove("Fantasy");
 foreach (var name in records)
 {
     Console.WriteLine($"ID: {name.Key} , Name: {name.Value}");
 }
 Console.WriteLine("------Using Contains and Count------");
 Console.WriteLine(records.ContainsValue("Henry"));
 Console.WriteLine(records.ContainsKey("Fantasy"));
 Console.WriteLine(records.Count);


 //Creating project
 //Example of dictionary that has one key with multiple values
 Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

 courses["Math"] = new List<string> { "Mary", "Martha", "Mel" };
 courses["Science"] = new List<string> { "Samantha", "Sam", "Sonny" };
 courses["ICT"] = new List<string> { "Ivan", "Isabelle", "Ian" };

 foreach (var subject in courses)
 {
     Console.WriteLine(subject.Key);
     foreach (string student in subject.Value)
     {
         Console.WriteLine("  -" + student);
     }
 }
 //Checking if mary is in math
 Console.WriteLine(courses["Math"].Contains("Mary"));
 //Checking if the subject Science exists
 Console.WriteLine(courses.ContainsKey("Science"));
 //Removing the subject Science and its class 
 courses.Remove("Science");
 //Removing Mary in Math
 courses["Math"].Remove("Mary");
 foreach (var subject in courses)
 {
     Console.WriteLine(subject.Key);
     foreach (string student in subject.Value)
     {
         Console.WriteLine("  -" + student);
     }
 }

 Console.WriteLine("------Adding a new subject and class------");
 courses.Add("English", new List<string> { "Ella", "Eric", "Ellen" });

 foreach (var subject in courses)
 {
     Console.WriteLine(subject.Key);
     foreach (string student in subject.Value)
     {
         Console.WriteLine("  -" + student);
     }
 }

//adding a new key but empty value
 courses.Add("GMRC", new List<string>());
  Console.WriteLine("------Adding a new subject but no students------");
foreach (var subject in courses)
{
    Console.WriteLine(subject.Key);
    foreach (string student in subject.Value)
    {
        Console.WriteLine("  -" + student);
    }
}