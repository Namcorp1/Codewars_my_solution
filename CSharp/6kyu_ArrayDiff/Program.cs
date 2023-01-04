/* Your goal in this kata is to implement a difference function, 
which subtracts one list from another and returns the result.
It should remove all values from list a, 
which are present in list b keeping their order. */

int[] ArrayDiff(int[] a, int[] b)
{
    bool check = true;
    int[] result = new int[1];
    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 0; j < b.Length; j++)
        {
            if (b[j] == a[i])
            {
                check = false;
                break;
            }
        }
        if (check)
        {
            result[result.Length - 1] = a[i];
            System.Array.Resize(ref result, result.Length + 1);
        }
        check = true;
    }
    System.Array.Resize(ref result, result.Length - 1);
    return result;
}

int[] res = ArrayDiff(new int[] {1, 2}, new int[] {1});
Console.WriteLine(string.Join(',',res));