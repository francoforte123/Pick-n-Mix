using System.Collections;

Console.WriteLine("inserisci qualcosa all'interno della lista:");
ArrayList listOfValue = new()
{
    "query", 
    12, 
    13.34,
    "Marco", 
    "Luca",
    354,
    3.14,
    2.72,
    3
};

foreach (object x in listOfValue)
{
    Console.WriteLine(x);
}
