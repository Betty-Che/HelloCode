Console.Write("Введите Ваше имя: ");
string usrename = Console.ReadLine();

if (usrename.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(usrename);
}