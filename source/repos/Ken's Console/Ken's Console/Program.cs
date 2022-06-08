public static void Main(string[] args)
{
    string url = args[0];
    int index = url.IndexOf("?");
    foreach (string parm in parms)
        Console.WriteLine(parm);
}