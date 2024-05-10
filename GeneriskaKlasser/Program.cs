while (true)
{
    List<string> Namn = new();
    Console.WriteLine("Hej skriv Något");
    string x = Console.ReadLine();
    Namn.Add(x);
    // säger åt användaren att inputa något och sparar det i listan Namn
    Console.WriteLine("skriv något mer");
    string y = Console.ReadLine();
    Namn.Add(y);
    //kollar efter en ny input och skriver in det i listan

    Console.WriteLine("Vill du ta bort det första eller sista saken du skrev");
    Console.WriteLine("1 för den första 2 för den sista");
    string z = Console.ReadLine();
    //frågar vad användaren vill ta bort och sparar det i string Z

    if (z == "1")
    {
        Queue<string> NamnQueue = new(Namn);
        NamnQueue.Dequeue();
        List<string> NamnFinal = new(NamnQueue);
        foreach (var item in NamnFinal)
        {
            Console.WriteLine(item);
        }
    }
    //om första gör programmet en queue och skriver ut Listan
    else
    {
        Stack<string> NamnStack = new(Namn);
        NamnStack.Pop();
        List<string> NamnFinal = new(NamnStack);
        foreach (var item in NamnFinal)
        {
            Console.WriteLine(item);
        }
    }
    //Om sista så gör programmet en Stack och skriver ut listan

    Console.WriteLine("vill du köra igen Y/N");
    string? i = Console.ReadLine();
    if (i.ToUpper() == "Y")
    {
        Console.Clear();
    }
    else
    {
        return;
    }
    //funktion för att spelaren ska kunna köra igen, kollar input Y/N
}
//loop för programet