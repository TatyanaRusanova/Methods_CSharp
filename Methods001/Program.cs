//Вид 1
void Method1()
{
    Console.WriteLine("Автор...."); // ничего не возвращает, ничего не принимает. Будет показывать на экран
}


//Method1(); //как вызывается этот метод

//Вид 2

void Method2(string msg)  //ничего не возвращают, но могут принимать аргументы
{
    Console.WriteLine(msg);

}
//Method2(msg: "Текст собщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; //инкремент
    }
}
// Method21(msg: "Текст", count: 4);
// Method21( count: 4, msg: "Текст");

// Вид3

int Method3()   //что-то возвращают, но ничего не принимают//сначала нужно указать тип данных значение которых мы ожидаем
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Console.WriteLine(year);


//Вид 4 //что-то возвращают и что-то принимают

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;

}
// string res = Method4(10, "asdf");
// Console.WriteLine(res);