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
    private Animator animate;

    // Start is called before the first frame update
    void Start()
    {
        BoxColl = GetComponent<BoxCollider2D>();
        animate = gameObject.GetComponent<Animator>();
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
            animate.SetFloat("jump", jumpSpeed);
        }

        float dirx = Input.GetAxisRaw("Horizontal");
        playerBody.velocity = new Vector2(dirx * playerSpeed, playerBody.velocity.y);
    }
    
    bool isOnGround()
    {
        return Physics2D.BoxCast(BoxColl.bounds.center, BoxColl.bounds.size,0f,Vector2.down,0.1f,canJump);
    } 
}
