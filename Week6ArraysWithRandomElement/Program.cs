string[] snacks = { "sushi", "pizza", "burger", "fries" }; //0-3

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"tongihs we are going to eat {snacks[randomIndex]}");