using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class nextbutton : MonoBehaviour
{
    public static string resetAura = "n";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        //11-12
        //transition to score
        //11/19 update if statement to prevent it from transfering 
        if (textcontrol.totalQuestions!=4 && textcontrol.trigger=="y")
        {
            textcontrol.randQuestion = -1;
            resetAura = "y";
            textcontrol.trigger = "n";
        }
        if (textcontrol.totalQuestions == 4 && textcontrol.trigger == "y")
        {
            SceneManager.LoadScene("ScoreScreen");
        }
    }

}
 