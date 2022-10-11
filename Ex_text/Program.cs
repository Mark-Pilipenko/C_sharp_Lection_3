// Дан текст.
// Заменить все пробелы черточками,
// маленькие "к" большими "К",
// а большие "С" - маленькими "с".

string text = "Сегодня мы углубимся в тему и выделим 4 основных группы методов, "
                + "а также будем использовать их на практике. И познакомимся с "
                + "новыми языковыми конструкциями, в частности, циклом.";

string Replace(string text, char OldValue, char NewValue)
{
    string result = String.Empty;
    int count = text.Length;
    for (int i = 0; i < count; i++)
    {
        if (text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string NewText = Replace(text, ' ', '|');
NewText = Replace(NewText, 'к', 'К');
NewText = Replace(NewText, 'С', 'с');
Console.WriteLine(NewText);