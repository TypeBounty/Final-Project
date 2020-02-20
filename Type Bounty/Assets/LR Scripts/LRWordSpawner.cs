using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LRWordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    public Transform wordCanvas;

   public LRWordDisplay SpawnWord()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-2.5f, 2.5f), 7f);

        GameObject wordObj = Instantiate(wordPrefab,randomPosition, Quaternion.identity, wordCanvas);
        LRWordDisplay wordDisplay = wordObj.GetComponent<LRWordDisplay>();

        return wordDisplay;
    }
}
