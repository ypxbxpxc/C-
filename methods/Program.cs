// method 1
Console.WriteLine();
void Method1()
{
    Console.WriteLine("jopajopajopa");
}
Method1();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// -> method 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Типа текст");

Console.WriteLine();

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(msg: "text",count: 4);
Console.WriteLine();
Method21(count: 3, msg: "new text");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

// method 3 ->

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


// -> method 4 ->

string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}
string res = Method4(10, "jopa");
Console.WriteLine(res);