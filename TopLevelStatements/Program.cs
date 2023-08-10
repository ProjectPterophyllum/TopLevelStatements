using System;
using System.Net;
using TopLevelStatements;
#region Task 1
void drawing(int side, char symbol)
{
    for (int i = 0; i < side; i++)
    {
        for (int j = 0; j < side; j++)
        {
            Console.Write(symbol + " ");
        }
        Console.WriteLine();
    }
}
//Rectangle Square = new Rectangle() { Height = 10, Width = 10, Symbol = '#' };
//Square.draw();
//Console.WriteLine();
//drawing(5, '#');
#endregion
#region Task 2
//bool isPalindrom(int number)
//{
//    char[] tmp = number.ToString().ToCharArray();
//    Array.Reverse(tmp);
//    string tmpstring = new string(tmp);
//    //Console.WriteLine(tmpstring);
//    if (number.ToString() == tmpstring)
//        return true;
//    return false;
//}
//if (isPalindrom(7854))
//{
//    Console.WriteLine("Число - палиндром.");
//}
//else Console.WriteLine("Число - не палиндром.");
#endregion
#region Task 3
T[] Filtr<T>(T[] arr, T[] dataArray)
{
    List<T> list = arr.ToList();
    foreach (var item in arr)
    {
        if (dataArray.Contains(item))
        {
            list.Remove(item);
        }
    }
    return list.ToArray();
}
int[] array = new int[5] { 1, 2, 3, 4, 5 };
int[] datArray = new int[3] { 1, 2, 3 };
array = Filtr(array, datArray);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"{array[i]}");
}
#endregion
#region Task 4
Web_site website = new Web_site()
{
    site_name = "Defsite",
    site_description = "default site",
    site_ip = new IPAddress(new byte[4] {192, 168, 100, 1}),
    scheme = "https",
    path = "www.defaultsite.com"
};
Console.WriteLine(website.ToString());
#endregion
