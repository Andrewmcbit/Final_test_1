/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам.*/

void FindStrings(string[] inputString){
    int count = 0;
    for (int i = 0; i < inputString.Length; i++){
        if (inputString[i].Length <= 3) {
            count += 1;
        } 
    }
    if (count != 0){
        string[] outputString = new string[count];
        count = 0;
        for (int i = 0; i < inputString.Length; i++){
            if (inputString[i].Length <= 3) {
                outputString[count] = inputString[i];
                count += 1;
            } 
        }
        Console.Write("Новый массив => ");
        Console.WriteLine(string.Join(", ", outputString));
    } else {
        Console.Write("Новый массив => ");
    }
}

string[] str1 = {"Hello", "2", "world", ":-)"};
Console.Write("Изначальный массив => ");
Console.WriteLine(string.Join(", ", str1));
FindStrings(str1);

