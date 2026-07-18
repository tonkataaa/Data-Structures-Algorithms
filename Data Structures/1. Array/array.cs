using System;
using System.Threading.Tasks;

public class MyList
{
    private int count = 0;
    private Task[] arr;

    public int Count => count;
    public int Capacity => arr.Length;

    public MyList() => arr = new Task[2]; 

    public Task Get(int index)
    {
        if (index < 0 || index >= count)
            throw new IndexOutOfRangeException("Индексът е извън границите на списъка.");

        return arr[index];
    }

    public void Add(Task item) 
    {
        EnsureCapacity();
        arr[count++] = item;
    }

    public void Delete(int index)
    {
        if (index < 0 || index >= count)
            throw new IndexOutOfRangeException("Индексът е извън границите.");

        ShiftItems(index);
        count--;
        arr[count] = null; 
    }

    private void ShiftItems(int index)
    {
        for (int i = index; i < count - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
    }

    private void EnsureCapacity()
    {
        if (count == arr.Length)
        {
            Task[] newArr = new Task[arr.Length * 2];
            Array.Copy(arr, newArr, arr.Length);
            arr = newArr;
        }
    }
}