using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballForce;

    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(new Vector2(ballForce,ballForce));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
