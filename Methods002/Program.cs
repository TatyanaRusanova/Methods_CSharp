﻿//Вид 4 //что-то возвращают и что-то принимают

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;

// }


string Method4(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
    result = result + text;
    }
return result;
}
string res = Method4(10, "R ");
Console.WriteLine(res);
// string res = Method4(10, "R");
// Console.WriteLine(res);