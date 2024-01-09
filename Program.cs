//Задача 1

int [] array = {1, 2, 3, 4, 5};
int sum = 0;
for(int i = 0; i < array.Length; i++)
sum+= array[i];
int avg = sum/array.Length;

//Задача 2
//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 


static void Main(string[] args)
{
    // Имеющий массив строк
    string[] array = {"cat", "dog", "elephant", "fox", "bird", "lion", "tiger"};
        
    // Формируем новый массив из строк, длина которых меньше либо равна 3 символам
    string[] newArray = array.Where(s => s.Length <= 3).ToArray();
        
    // Выводим новый массив на экран
    Console.WriteLine("Новый массив:");
    foreach (string s in newArray)
    {
        Console.WriteLine(s);
    }
}
