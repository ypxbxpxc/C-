string Method4(int count, string c)
{
    
    string result = String.Empty;
    for (int i = 1; i < count; i++)

    {
        result = result + c;
    }
    return result;
}
string res = Method4(10, "jopa");
Console.WriteLine(res);