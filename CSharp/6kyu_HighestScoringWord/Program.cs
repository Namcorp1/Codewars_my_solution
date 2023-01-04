/* Given a string of words, you need to find the highest scoring word.
Each letter of a word scores points according 
to its position in the alphabet: a = 1, b = 2, c = 3 etc.
You need to return the highest scoring word as a string.
If two words score the same, return the word that appears earliest in the original string.
All letters will be lowercase and all inputs will be valid. */

string High(string s)
{
    char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    string[] words = s.Split(' ');
    int[] points = new int[words.Length];
    for (int i = 0; i < words.Length; i++)
    {
        string word = words[i];
        int point = 0;
        for (int j = 0; j < word.Length; j++)
        {
            for (int k = 0; k < alphabet.Length; k++)
            {
                if (word[j] == alphabet[k])
                {
                    point += (k + 1);
                    break;
                }
            }
        }
        points[i] = point;
    }
    int maxPoint = points[0];
    for (int l = 1; l < points.Length; l++)
    {
        if (points[l] > maxPoint)
        {
            maxPoint = points[l];
        }
    }
    int maxPosition = 0;
    for (int m = 0; m < points.Length; m++)
    {
        if (points[m] == maxPoint)
        {
            maxPosition = m;
            break;
        }
    }
    string result = words[maxPosition];
    return result;
}

string test = High("give taxi tomorow");
Console.WriteLine(test);