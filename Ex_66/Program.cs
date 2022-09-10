Console.WriteLine("Введите первое число:");
string? aString = Console.ReadLine();
int a = int.Parse(aString);
Console.WriteLine("Введите второе число:");
string? bString = Console.ReadLine();
int b = int.Parse(bString);
int i = a;
int sum = 0;
while (i <= b){
    sum = sum + i;
    i ++;
}
Console.WriteLine(sum);