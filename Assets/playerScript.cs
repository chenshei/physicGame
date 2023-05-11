using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    

    public Rigidbody2D playerBody;
    public float playerSpeed =5;
    bool canIJumpNow=false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

         KeyDitect();

    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        canIJumpNow = true;

    }



    void KeyDitect()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerBody.velocity = new Vector2(Vector2.right.x, playerBody.velocity.y)*playerSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerBody.velocity = new Vector2(Vector2.left.x, playerBody.velocity.y) * playerSpeed;
        }
        else
        {
            playerBody.velocity = new Vector2(0,playerBody.velocity.y);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow)&& canIJumpNow)
        {
            playerBody.velocity = playerBody.velocity+ Vector2.up * playerSpeed ;
        }
    }
}
