// GOOGLE въпрос
// По даден масив да се провери кой е елементът който се среща първи повече от един път
// [2,5,1,2,3,6,1,2,4] => Return 2
// [2,1,1,2,3,5,1,2,4] => return 1
// [2,3,4,5] => return undefined

int[] exampleArr = [2, 5, 1, 2, 3, 6, 1, 2, 4];
int[] exampleArrSecond = [2, 1, 1, 2, 3, 5, 1, 2, 4];
int[] exampleArrThird = [2, 3, 4, 5];
int[] exampleArrFourth = [1, 2, 3, 2, 1];



Console.WriteLine(FindSequence(exampleArr)); // return 2
Console.WriteLine(FindSequence(exampleArrSecond)); // return 1
Console.WriteLine(FindSequence(exampleArrThird)); // return undefined
Console.WriteLine(FindSequence(exampleArrFourth)); // return 3


static int FindSequence(int[] array)
{
    Dictionary<int, int> counts = new Dictionary<int, int>();

    for (int i = 0; i < array.Length; i++)
    {
        if (!counts.ContainsKey(array[i]))
        {
            counts.Add(array[i], 1);
        }
        else
        {
            counts[array[i]]++;

            if (counts[array[i]] > 1)
            {
                return array[i];
            }
        }
        
    }

    return 0;
}

