string[] list = {"Кёнигсберг", "Белгород", "Уфа", "Вятка"};

ShowList(list);
NewList(list);

void ShowList(string[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write($"{list[i]} ");
    }

    Console.Write("-> ");
}

void NewList(string[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        if(list[i].Length <= 3)
            Console.Write($"{list[i]} ");
    }
}