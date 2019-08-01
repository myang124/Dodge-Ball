using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTopdown : MonoBehaviour
{

    public Rigidbody2D rb;
    float y = 5f;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            rb.transform.position = new Vector2(.03f, rb.transform.position.y - .10f);
            y = y - .10f;
            Debug.Log("awdjanbwdkba");
        }
    }
}
