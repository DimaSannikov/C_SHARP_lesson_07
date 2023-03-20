﻿int n = 1;
void FindWords(string alphabet, char[] word, int len = 0)
{
    if (len == word.Length)
    {
        Console.WriteLine ($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[len] = alphabet[i];
        FindWords(alphabet, word, len + 1);
    }
}

FindWords("аисв", new char[4]);