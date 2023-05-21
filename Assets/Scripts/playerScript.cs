using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{

    public Rigidbody2D playerBody;
    private BoxCollider2D BoxColl;
    [SerializeField] private LayerMask canJump;
    public float playerSpeed =5;
    public float jumpSpeed = 20f;
    public static playerScript player;
    public float playerTeta = 0;
    public float playerR = 0;
    public string axiss = "xy";
    private Vector3 startPosition;


    // Start is called before the first frame update
    void Start()
    {
        BoxColl = GetComponent<BoxCollider2D>();
        startPosition = playerBody.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

         KeyDitect();
    }


    void KeyDitect()
    {
        if (Input.GetButtonDown("Jump") && isOnGround())
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, jumpSpeed);
        }
        float dirx = Input.GetAxis("Horizontal");
        if (axiss == "xy")
        {
            
            playerBody.velocity = new Vector2(dirx * playerSpeed, playerBody.velocity.y);
        }
        else
        {
            if (axiss == "tetaY")
            {
                playerTeta = playerTeta + (10 * dirx);
            }
            if (axiss == "RY")
            {
                playerR += dirx * 1;
                
            }
            float radianTeta = Mathf.PI * playerTeta / 180f;
            float deltaX = playerR * Mathf.Cos(radianTeta);
            playerBody.transform.position = startPosition + new Vector3(deltaX, 0f, 0f);

        }


    }
    
    bool isOnGround()
    {
        return Physics2D.BoxCast(BoxColl.bounds.center, BoxColl.bounds.size,0f,Vector2.down,0.1f,canJump);
    } 
}
