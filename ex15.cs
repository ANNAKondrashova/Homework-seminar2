// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
static void DayOffWeek(int dayWeek)
{
    switch (dayWeek)
    {
        case 1:
            Console.WriteLine("Понедельник- НЕТ");
            break;
        case 2:
            Console.WriteLine("Вторник- НЕТ");
            break;
        case 3:
            Console.WriteLine("Среда- НЕТ");
            break;
        case 4:
            Console.WriteLine("Четверг- НЕТ");
            break;
        case 5:
            Console.WriteLine("Пятница- ДА");
            break;
        case 6:
            Console.WriteLine("Суббота- НЕТ");
            break;
        case 7:
            Console.WriteLine("Воскресенье- НЕТ");
            break;
        default:
            Console.WriteLine("Некорректный номер дня недели");
            break;
    }
}