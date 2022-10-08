int num, rem, sum = 0, temp;
num = PrintAndGetValue("Введите рассматриваемое число");
temp = num;
while (Convert.ToBoolean(num))
{
    rem = num % 10;
    num = num / 10;
    sum = sum * 10 + rem;
}
if (temp == sum)
{
    Console.WriteLine("Палиндром найден");
}
else
{
    Console.WriteLine("Неудача попребуйте другое число");
}




int PrintAndGetValue(string message)
{
    Console.WriteLine("Приступим к проверке является ли число палиндромом");
    Console.WriteLine(message);
    int input = int.Parse(Console.ReadLine());
    return input;
}