/* Write an algorithm that takes an array 
and moves all of the zeros to the end, 
preserving the order of the other elements.*/

int[] MoveZeroes(int[] arr)
{
    int[] res = new int[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            System.Array.Resize(ref res, res.Length + 1);
            res[res.Length - 1] = arr[i];
        }
    }
    System.Array.Resize(ref res, arr.Length);
    return res;
}

int[] sortArray = MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1});
Console.WriteLine(string.Join(',',sortArray));