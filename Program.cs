string[] InArray = new string[8] { "R2-D2", "Han Solo", "Anakin Skywalker", "Boba Fett", "Chewbacca", "Yoda", "C-3PO", "Jabba" };
Console.WriteLine($" Вот исходный массив-> [{string.Join(", ", InArray)}]");
int lenOut = new Random().Next(0, 4);

string[] ArrayFormat(string[] array)

{
    string[] OutArray = new string[lenOut];

    int randIndex = 0;
    for (int i = 0; i < lenOut; i++)
    {
        randIndex = new Random().Next(0, InArray.Length);
        while (ComporateRepeat(randIndex, OutArray,InArray))
        {
            randIndex = new Random().Next(0, InArray.Length);

        }
        OutArray[i] = InArray[randIndex];

    }
    return OutArray;

}


bool ComporateRepeat(int n, string[] array1, string[] array2)

{

    for (int i = 0; i < array1.Length; i++)
    {
        if ( array1[i]!= "" && array1[i] == array2[n])
        {
            return true;
        }

    }
    return false;
}
