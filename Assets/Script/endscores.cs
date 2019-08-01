using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endscores : MonoBehaviour
{
    public Text score;
    public Text highscore;

    // Start is called before the first frame update
    void Start()
    {
        score.text = PlayerPrefs.GetInt("score").ToString();
        highscore.text = PlayerPrefs.GetInt("highscore").ToString();
    }
}
