Console.WriteLine("Введите первое число:");
string? aString = Console.ReadLine();
int a = int.Parse(aString);
Console.WriteLine("Введите второе число:");
string? bString = Console.ReadLine();
int b = int.Parse(bString);
int i = a;
while (i < b){
    Console.WriteLine(i);
    i ++;
}
