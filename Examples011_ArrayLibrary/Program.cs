void FillArray(int[] collection) //пишем функцию заполнения нового массива. Название функции - FillArray, а аргумент функции назовем collection
{
    int length = collection.Length;  //получит длину массива, т.е.количество элементов в массиве
    int index = 0; //начальный индекс массива, с которого начнем работать - будет 0 
    while (index < length)   //пока нулевой индекс массива меньше последнего индекса массива
    {
        collection[index] = new Random().Next(1, 10); //заполняем массив collection рандомными числами от 1 до 9
        index++;
    }




}


void PrintArray(int[] col)  //функция, которая печатает массив
{
    int count = col.Length;  //количество элементов
    int position = 0;          //начальный индекс массива
    while (position < count)
    {
        Console.WriteLine(col[position]); //выводим на экран значение текущего элемента
        position++;
    }

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 для того, что, если в искомом массиве отсутствиет тот элемент, который мы ищем - то выдаст не 0, а -1, т.е.элемент не найден.

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; //чтобы найти только первое вхождение
        }
        index++;
    }
    return position;
}



int[] array = new int[10]; //Создаем новый массив, в котором будет 10 элементов, по умолчанию он будет заполнен нулями

FillArray(array); // заполнение массива
array[4] = 4; //добавили искуственно четверку на 4-ю позицию
array[6] = 4; //добавили искуственно четверку на 6-ю позицию
PrintArray(array); //распечатка массива
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);


