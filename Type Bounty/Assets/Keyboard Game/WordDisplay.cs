using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;
<<<<<<< HEAD

    public float fallSpeed = 1f;
    public static float wordPosx;
    public static float wordPosy;
    public static bool moveShip = false;

=======
    public float fallSpeed = 3f;
>>>>>>> parent of 11d67de... Moved ship

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

        wordPosx = transform.position.x;// - 50.0f;
        wordPosy = transform.position.y;// + 800.0f;
        moveShip = true;
        Destroy(gameObject);
        
    }
    
    private void Update()
    {
        transform.Translate(0f, -fallSpeed, 0f);
        
       /* if(transform.position.y <= -100f)

      /*  if(transform.position.y <= -100f)
<<<<<<< HEAD

        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
        
       /* if(transform.position.y <= -100f)


=======
>>>>>>> parent of 11d67de... Moved ship
        {
           // WordManager.getOut();
            removeWord();
        }*/
    }
}