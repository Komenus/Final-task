Console.Clear();
Console.Write("Введите количество строк, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
string[] strs = new string[n]; //Объявляем массив строк длиной n (которую ввёл пользователь)
for (int i = 0; i < n; i++)
{
    Console.Write("Введите строку №{0}:\r\n    ", i + 1);
    strs[i] = Console.ReadLine(); //Заполняем его
}
Console.WriteLine("Вы ввели следующие строки :");
for (int i = 0; i < n; i++)
{
    Console.Write($"{strs[i] + " " }");
    
}
Console.WriteLine();
Console.WriteLine("Массив из строк, длинна которых меньше  или равен трем символам :");
for (int i = 0; i < n; i++)
{
    int len = strs[i].Length;
    if( len <= 3)
    {
         Console.Write($"{strs[i] + " " }");
    }
    
}
// Console.Write("Нажмите [Enter] для выхода...");
// Console.ReadLine();
// int len = strs[0].Length;
// for (int i = 0; i < n; i++)
// int len = strs[i].Length;
// {
//     if
// }