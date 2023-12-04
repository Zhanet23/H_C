Console.Write("введите ваше имя: ");
string UserName = Console.ReadLine();

if(UserName.ToLower()=="zhanna")
{
    Console.WriteLine("Ура,это Zhanna!");
}
else
{
    Console.Write("привет, ");
    Console.Write(UserName);
}