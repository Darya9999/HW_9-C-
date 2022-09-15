
Console.WriteLine("Введите первое число:");
string? nString = Console.ReadLine();
int n = int.Parse(nString);
Console.WriteLine("Введите второе число:");
string? mString = Console.ReadLine();
int m = int.Parse(mString);

  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));

