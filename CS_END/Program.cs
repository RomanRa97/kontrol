string[] first_array = new string[5] {"1", "Kazan", "win", "computer", "create"};
string[] second_array = new string[first_array.Length];

void Make_result_array(string[] first_array, string[] second_array)
{
    int counter = 0;
    for (int i = 0; i < first_array.Length; i++)
    {
    if(first_array[i].Length <= 3)
        {
        second_array[counter] = first_array[i];
        counter++;
        }
    }
}

Make_result_array(first_array, second_array);

for (int i = 0; i < second_array.Length; i++)
{
        Console.Write(second_array[i] + " ");
}