Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine ();

if (username.ToLower() == "софья")
{
    Console.WriteLine("Ура, это же Соня!");
}
else
{
   Console.Write("Привет, ");
    Console.WriteLine(username);
}
Console.WriteLine("");
