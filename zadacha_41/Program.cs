//Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

int count = 0;
string allNum ="";
void GetNumbers(int count, string allNum)
{
    Console.Write("Введите число, если ввод чисел закончен нажмите f: ");
    string word = Console.ReadLine();
    if(word!="f")
    {
        allNum=allNum+","+word;
        int num = Convert.ToInt32(word);
        if(num>0) count++;
        GetNumbers(count,allNum);
    }
    else
    {
        Console.WriteLine($"{allNum} -> {count}");
    }
}

GetNumbers(count,allNum);

