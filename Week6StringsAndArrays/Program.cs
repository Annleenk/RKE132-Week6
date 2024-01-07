string hello = "hello, world!";

int stringLength = hello.Length;

//string trimmedString = hello.Trim();

hello = hello.Trim();

//Console.WriteLine(trimmedString.Length); //kustutab ebavajalikud tyhikud

//
//for(int i = 0; i < hello.Length ; i++)
//{
//Console.WriteLine($"{i} symbol in string: {hello[i]}");
//if (hello[i]== ' ')
//{
// wordCounter++;
//}
//if (char.IsWhiteSpace(hello[i])) // true or false, kui ühik siis paneb +1 sõna 
// {
//  wordCounter++;
// }
//}
//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");



char firstLetter = hello[0];
Console.WriteLine(firstLetter);


hello = hello.Replace(hello[0], char.ToUpper(hello[0])); //.Replace('?', '!');

firstLetter = hello[0];
Console.WriteLine(firstLetter);
