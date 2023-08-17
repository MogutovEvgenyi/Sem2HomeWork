Console.Write("Введите цифру, обозначающую день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 6 || dayWeek == 7)
{
    Console.WriteLine("{0} -> да", dayWeek);
}
else if (dayWeek >= 1 && dayWeek <= 5)
{
    Console.WriteLine("{0} -> нет ", dayWeek);
}
else
{
    Console.WriteLine("{0} -> дня недели с такой цифрой нет", dayWeek);
}
