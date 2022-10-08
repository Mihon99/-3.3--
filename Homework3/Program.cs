Console.WriteLine("Введите желаемое число");
int n = int.Parse(Console.ReadLine());
int x = 1;
if (n < -x)
{
    while (n < -x){
        Console.Write(Math.Pow(n,3) + ", ");
        n++;}
    Console.Write(Math.Pow(-x,3) + ".");
}
else
{
    while (x < n){
    Console.Write(Math.Pow(x,3) + ", ");
    x++;}
Console.Write(Math.Pow(n,3) + ".");
}