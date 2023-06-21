using SelfValue;

// try-catch хваща грешките и ги изписва на конзолата (валидацията която направихме)
try
{
    Console.WriteLine($"Enter the count for the necessery work: ");
    int n = int.Parse(Console.ReadLine());
    var necesseryWorkData = new List<PaymentPerHour>(); // лист в който ще съхраняваме всички данни
    StreamWriter writer = new("NecesseryWork.txt"); // Създаваме streamWriter в който да запишем данните

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Enter data for necessery work - (Code Type Payment Hours)");
        string[] command = Console.ReadLine().Split(" ");

        WorkData workData = new PaymentPerHour(int.Parse(command[0]), command[1], double.Parse(command[2]), int.Parse(command[3])); // Потрбителя вкарва информацията - Тук е осъществен полиморфизъм (WorkData workData = new PaymentPerHour)

        necesseryWorkData.Add((PaymentPerHour)workData); // Тук добавяме цялата информация въведена от потребителя в листа ни по-горе

        using (writer) // Тук записваме данните в streamWriter-a
        {
            writer.WriteLine(command[0]);
            writer.WriteLine(command[1]);
            writer.WriteLine(command[2]);
            writer.WriteLine(command[3]);
        }
    }
    necesseryWorkData.Sort(); // сортираме листа
    necesseryWorkData.ForEach(x => x.Print()); // и го принтираме на конзолата

    Console.Write("Enter code: ");
    int code = int.Parse(Console.ReadLine()); // въвеждаме код 
    Console.WriteLine(necesseryWorkData.Find(x => code == x.Code)); // изписваме информацията за кода който ни е подаден
    // намирaме най-високото заплащане
    var highestMoneyAvailable = necesseryWorkData.Select(x => x.Payment).Max();
    Console.WriteLine($"Biggest payment for the work: {highestMoneyAvailable}");
}
catch (ArgumentNullException exeption)
{
    Console.WriteLine(exeption.Message);
}

