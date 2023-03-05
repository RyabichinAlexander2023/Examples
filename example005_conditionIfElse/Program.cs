Console.Write ("введите им пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.write("Привет,");
    Console.WriteLine(username);
}