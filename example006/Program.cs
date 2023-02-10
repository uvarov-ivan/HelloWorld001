Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ох ты ж нах, это ж Машка!");   
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
