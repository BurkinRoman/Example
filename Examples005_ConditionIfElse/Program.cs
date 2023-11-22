Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "роман")
{
    Console.WriteLine("Ура, это же РОМАН!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}