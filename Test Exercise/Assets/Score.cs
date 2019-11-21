using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Word num;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = num.score.ToString();
        Debug.Log(scoreText);
    }
}
