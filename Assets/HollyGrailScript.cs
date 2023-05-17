using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HollyGrailScript : MonoBehaviour
{
    public Rigidbody2D playerRB;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("victory"))
        {
            Win();
        }
    }

    private void Win()
    {
        playerRB.bodyType = RigidbodyType2D.Static;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
