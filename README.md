
```
if (a == 1 && a == 2 && a == 3)
{
    System.Console.WriteLine("I'm here.");
}
```

```
public static bool Something(out int a, out int b)
{
    a = 45;
    b = 90;

    return a == b;
}
```

```
Console.WriteLine($"x > y is {x > y}");
Console.WriteLine($"!(x <= y) is {!(x <= y)}");

Output:
x > y is False
!(x <= y) is True
```