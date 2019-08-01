using UnityEngine.SceneManagement;
using UnityEngine;

public class endgameTrigger : MonoBehaviour { 

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            SceneManager.LoadScene(2);
        }
    }

}
