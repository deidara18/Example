Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "Даша")
{
    Console.WriteLine("Ура, это же Даша");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);

}