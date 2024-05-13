while (true)
{
    List<string> Namn = new();
    //skapar listan Namn
    Console.WriteLine("Hej skriv Något");
    string x = Console.ReadLine();
    Namn.Add(x);
    // säger åt användaren att inputa något och sparar det i listan Namn
    Console.WriteLine("skriv något mer");
    string y = Console.ReadLine();
    Namn.Add(y);
    //kollar efter en ny input och skriver in det i samma lista

    Console.WriteLine("Vill du ta bort det första eller sista saken du skrev");
    Console.WriteLine("1 för den första 2 för den sista");
    string z = Console.ReadLine();
    //frågar vad användaren vill ta bort första eller sista input och sparar det i string Z

    if (z == "1")
    {
        Queue<string> NamnQueue = new(Namn);
        //skapar en Queue av Listan Namn
        NamnQueue.Dequeue();
        //tar bort den med lägst index i queue listan, vilket är den första jag la till
        foreach (var item in NamnQueue)
        {
            Console.WriteLine(item);
        }
        //skriver ut alla items i NamnQueue listan
    }
    //om första gör programmet en queue och skriver ut Listan
    else
    {
        Stack<string> NamnStack = new(Namn);
        //skapar en lista NamnStack av listan Namn
        NamnStack.Pop();
        //tar bort översta i stack Namnstack, alltså den som la till senast
        foreach (var item in NamnStack)
        {
            Console.WriteLine(item);
        }
        //skriver ut alla items i NamnStack listan
    }
    //Om sista så gör programmet en Stack och skriver ut listan

    Console.WriteLine("vill du köra igen Y/N");
    string? i = Console.ReadLine();
    //frågar användaren om input och sparar den i string i
    if (i.ToUpper() == "Y")
    {
        Console.Clear();
    }
    //om string i är Y så kommer den ta bort console text
    else
    {
        return;
        //annars så returnerar den vilket avslutar programet
    }
    //funktion för att spelaren ska kunna köra igen, kollar input Y/N
}
//loop för programet