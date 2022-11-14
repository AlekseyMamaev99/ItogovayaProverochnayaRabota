Console.Clear();

Console.WriteLine("Введите количество элементов массивва : ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n]; // начальный массив (введеный пользователем)
string[] massiv = new string[n];// создание "конечного" массива

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите элемент массива №" + (i + 1));
    array[i] = Console.ReadLine(); // Заполнение массива (начального)
    if (array[i].Length < 4)       // Проверкаа условия 
        massiv[i] = array[i];      // заполнение конечного массива при выполнении условия

}
// Далее оформление вывода 
Console.Write("Начальный массив:");
Console.Write($"[ " + String.Join("; ", array) + " ]");
Console.WriteLine();
Console.Write("Отобранный массив:");
Console.Write("[");
for (int i = 0; i < n; i++)
{
    if (massiv[i] != null)
    {
        Console.Write(massiv[i] + ';');
    }
    
}
Console.Write("]");


