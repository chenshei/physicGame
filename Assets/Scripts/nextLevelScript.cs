using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelScript : MonoBehaviour
{
    public GameObject nextButton;
    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

  void Update()
    {
        if(nextButton.activeInHierarchy && Input.GetButtonUp("acceptButton")){
            nextLevel();
        }
    }
}
