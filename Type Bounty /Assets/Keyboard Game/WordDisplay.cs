using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
<<<<<<< Updated upstream
    public float fallSpeed = 3f;
=======
    public float fallSpeed = 1f;
    public static float wordPosx;
    public static float wordPosy;
    public static bool moveShip = false;
>>>>>>> Stashed changes

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.green;
    }

    public void removeWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
<<<<<<< Updated upstream
        transform.Translate(0f, -fallSpeed, 0f);
      /*  if(transform.position.y <= -100f)
=======
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        
       /* if(transform.position.y <= -100f)
>>>>>>> Stashed changes
        {
           // WordManager.getOut();
            removeWord();
        }*/
    }
}