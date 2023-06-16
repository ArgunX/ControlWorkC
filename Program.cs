string[] InArray = new string[8] { "R2-D2", "Han Solo", "Anakin Skywalker", "Boba Fett", "Chewbacca", "Yoda", "C-3PO", "Jabba" };
Console.WriteLine($" Вот исходный массив-> [{string.Join(", ", InArray)}]");
int lenOut = new Random().Next(0, 4);