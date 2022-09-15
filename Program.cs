//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3м символам. 
//Первоначальный массив вводится с клавиатуры, либо задается на старте выполнения алгоритма. 

Console.Clear(); 
Console.WriteLine("Сколько слов или чисел хотите ввести?");
int n=Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[n]; 
int i=0;

while (i<n)
{
    Console.WriteLine($"Введите {i+1}-е число или слово"); // заполняем массив с участием пользователя
    array1[i]= Console.ReadLine();
    i++;
}
string[] array2 = new string[array1.Length]; 
void FindElements(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++) 
    {
    if(array1[i].Length <= 3) 
        {
        array2[index] = array1[i]; 
        index++; 
        }
    }
}
void PrintArray(string[] array) //метод печати массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        
    }
    
    Console.WriteLine();
}
FindElements(array1, array2); //обращаемся к первому методу
Console.Write("Введенный массив имеет вид:  ");
PrintArray(array1); // выводим результат ввода с клавиатуры
Console.WriteLine();
Console.Write("итоговый массив:  ");
PrintArray(array2); // выводим результат отсортированного метода 
