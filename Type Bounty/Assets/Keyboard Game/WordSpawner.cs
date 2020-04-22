using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;

    public WordDisplay SpawnWord()
    {
<<<<<<< Updated upstream
        Vector3 randomPosition = new Vector3(Random.Range(200f, 2200f), 250f);
=======
        Vector3 randomPosition = new Vector3(Random.Range(0f, 2.5f), 7f);
>>>>>>> Stashed changes

        GameObject wordObj = Instantiate(wordPrefab,randomPosition, Quaternion.identity, wordCanvas);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
