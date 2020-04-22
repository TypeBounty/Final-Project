using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopWordTimer : MonoBehaviour
{
    public TopWordManager wordManager;

    public float wordDelay = 1.9f;
    private float nextWordTime = 2f;

    private void Update()
    {
        if (Time.time >= nextWordTime)
        {
            nextWordTime = Time.time + wordDelay;
            //  wordDelay *= .99f;
        }
    }
}
