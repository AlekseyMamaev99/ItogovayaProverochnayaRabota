Console.Clear();

Console.WriteLine("Введите количество элементов массивва : ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите элемент массива №" + (i + 1));
    array[i] = Convert.ToString(Console.ReadLine());    
}
Console.Write("Изначальный массив:");
Console.Write($"[ " + String.Join("; ", array) + " ]");


