﻿Console.WriteLine("inserisci qualcosa all'interno della lista:");
List<object> ListOfValue = new();
int i = 0;

while (i <= ListOfValue.Count)
{
    object Input = Console.ReadLine();
    ListOfValue.Add(Input);
    i++;
    
    if(ListOfValue.Count == 10)
    {
        break;
    }
}

Console.WriteLine("-------------------------------------");

foreach(object x in ListOfValue)
{
    Console.WriteLine(x);
}



