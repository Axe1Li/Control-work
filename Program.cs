Console.Clear();

Console.Write("Сколько элементов Вы хотите ввести: "); // Узнаем размер массива
int size = Convert.ToInt32(Console.ReadLine());  

string[] arrString = new string[size];  // Объявляем массив строк
for (int i = 0; i < size; i++) // Цикл для заполнения массива с клавиатуры
{
    Console.Write("Введите строку №{0}:\r\n    ", i + 1);  
    arrString[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine("Вы ввели следующие строки: "); // Вывод получившегося массива для удобства
for (int i = 0; i < size; i++)
{
    Console.WriteLine(arrString[i]);
}
var result = new string[arrString.Length];
var count = 0;
foreach (var value in arrString) // Цикл для нахождения элементов короче 3 символов
{
    if (value.Length <= 3)
    {
        result[count] = value;
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("Строки массива, длина которых меньше либо ровна 3 символам: "); // Для понятного вывода
Console.WriteLine(string.Join(Environment.NewLine, result, 0, count)); 