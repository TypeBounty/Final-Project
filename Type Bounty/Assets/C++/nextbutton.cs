using System.Collections;
using System.Collections.Generic;
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
        textcontrol.randQuestion = -1;
        resetAura = "y";
    }
}
