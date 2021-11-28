Console.WriteLine("Введите имя пользоавтеля: ");
string username = Console.ReadLine();

if(username.ToLower() == "jopa")
{
    Console.WriteLine("Ну здарова, тварына");
}
else
{
    Console.Write("Пшёл вон, ");
    Console.Write(username);
}