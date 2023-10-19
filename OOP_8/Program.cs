using OOP_8;

class Programm
{
    static void Main(string[] args)
    {
        Client client = new Client("Ilya", 250, 10);
        client.AddMoney(125);
        Console.WriteLine("Кол-во денег на счете: "+client.CurrentSum);
        client.RemoveMoney(100);
        Console.WriteLine("Кол-во денег на счете: " + client.CurrentSum);
        client.CalculateInterest();

    }
}