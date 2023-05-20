using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HollyGrailScript : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public GameObject winText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("victory"))
        {
            Win();
        }
    }

    private void Win()
    {
        winText.SetActive(true);
        /*playerRB.bodyType = RigidbodyType2D.Static;*/
    }
}
