string pangram = "The quick brown fox jumps over the lazy dog";

string[] pangramArray = pangram.Split(" ");
for (int i = 0; i < pangramArray.Length; i++)
{
    char[] wordArray = pangramArray[i].ToCharArray();
    Array.Reverse(wordArray);
    pangramArray[i] = new string(wordArray);
}
pangram = String.Join(" ", pangramArray);
Console.WriteLine(pangram);