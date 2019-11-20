using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{

   private static string[] wordList = { "for", "teach", "stew", "trim", "switch", "pass", "get", "break", "if", "help", "the", "leg", "run", "won", "one",
                                        "mad", "eat", "quote", "yarn", "uno", "cat", "keep", "hair", "spike", "ein", "swordfish", "lion", "cake", "urn",
                                        "mutation", "train", "basement", "dream", "hold", "no", "maze", "foil" };

   public static string GetRandomWord()
	{
		int randomIndex = Random.Range(0, wordList.Length);
		string randomWord = wordList[randomIndex];

		return randomWord;
	}
}
