using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HollyGrailScript : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public GameObject winText;
    public float hollyGrailTeta;
    private playerScript player;



    // Start is called before the first frame update
    void Start()
    {
        player = playerScript.player;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("victory") && tetaCheck())
        {
            Win();
        }
    }

    private void Win()
    {
        winText.SetActive(true);
        /*playerRB.bodyType = RigidbodyType2D.Static;*/
    }

    private bool tetaCheck()
    {
        float tetaDelta = player.playerTeta - hollyGrailTeta;
        if (tetaDelta <= 2f &&-2<= tetaDelta)
        {
            return true;
        }
        return false;
    }
}
