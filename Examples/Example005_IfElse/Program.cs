Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
        Console.WriteLine("можно Машку за ляжку");
}
else 
{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}