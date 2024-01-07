//uhes massiivis uhte tuupi andmed

//string[] fruit = { "apples", "bananas", "oranges" }; //string - ainult sone

string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[3] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;

Console.WriteLine($"There are {fruitArrayLength}in your array");

for (int i = 0; i < fruitArrayLength; i++) //muutmiseks
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach (string element in fruit) //kuvamiseks
{
    Console.WriteLine(element);
}

