using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Score : MonoBehaviour
{
    public int sec;
    public Text timer;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("addSec");
        score = PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = "SCORE " + sec;
        PlayerPrefs.SetInt("score", sec);
        if (sec >= PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", sec);
        }
      
    }

    IEnumerator addSec() {
        while (true)
        {
            yield return new WaitForSeconds(.1f);
            sec++;
        }
    }

}
