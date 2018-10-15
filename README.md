

Ako je možné dosiahnúť to aby bola splnená daná podmienka?
```
if (a == 1 && a == 2 && a == 3)
{
    System.Console.WriteLine("I'm here.");
}
```

Ako zavolať danú metódu tak, aby jej návratová hodnota bola `true`?
```
public static bool Something(out int a, out int b)
{
    a = 45;
    b = 90;

    return a == b;
}
```


Ako majú byť definované premenné `x` a `y` aby platil výstup nižšie?
```
Console.WriteLine($"x > y is {x > y}");
Console.WriteLine($"!(x <= y) is {!(x <= y)}");

Output:
x > y is False
!(x <= y) is True
```