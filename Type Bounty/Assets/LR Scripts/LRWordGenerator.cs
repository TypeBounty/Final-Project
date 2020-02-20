using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRWordGenerator : MonoBehaviour
{
    /*private static string wordList = "#include<iostream> \n using namespace std; \n \n int main() {\n " +
            "int i = 0;\n \n cout << i << endl;\n\n i = i + 1;\n\n cout << i << endl;\n\n return(0);\n }\n";
*/
    private static string[] wordList = { "get", "out", "of", "my", "treehouse" };

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];
        return randomWord;
    }

   /* public static string GetWordList()
    {
        return wordList;
    }*/
}
