using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    Vector2 firstTouch;
    Vector2 secoundTouch;
    Vector2 curr;
    public Rigidbody2D rb;
    bool right;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        right = true;
    }

    // Update is called once per frame
    void Update()
    {

      foreach(Touch touch in Input.touches)
        {
            if(touch.position.x < Screen.width / 2)
            {
                LeftMovement();
                //flip player
                transform.localScale = new Vector2(-1.12428f, 1.12428f);
            }
            if(touch.position.x >= Screen.width / 2)
            {
                RightMovement();
                transform.localScale = new Vector2(1.12428f, 1.12428f);
            }
            //  Jump();
        }
    }

    private void LeftMovement()
    {
        anim.SetFloat("speed", 1);
        rb.velocity = Vector2.left * 4;
    }

    private void RightMovement()
    {
       anim.SetFloat("speed", 1);
        rb.velocity = Vector2.right * 4;
    }

    /*
    public void Jump()
    {

        if(Input.touches.Length > 0)
        {
            Touch t = Input.GetTouch(0);
            if(t.phase == TouchPhase.Began)
            {
                firstTouch = new Vector2(t.position.x, t.position.y);
            }
            if(t.phase == TouchPhase.Ended)
            {
                secoundTouch = new Vector2(t.position.x, t.position.y);

                curr = new Vector3(secoundTouch.x - firstTouch.x +1, secoundTouch.y - firstTouch.y);
                curr.Normalize();

                if(curr.y > 1 && curr.x > -2f && curr.x < 2f){
                    rb.velocity = Vector2.up * 7;
                }
            }
        }
    }
    **/
}
