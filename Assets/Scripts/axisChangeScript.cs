using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class axisChangeScript : MonoBehaviour
{

    public GameObject staticAxisCam;
    public GameObject PlayerAxisCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("AxisChange") && staticAxisCam.activeInHierarchy) 
        {
            staticAxisCam.SetActive(false);
            PlayerAxisCam.SetActive(true); 
        }
        else if (Input.GetButtonDown("AxisChange"))
        {
            staticAxisCam.SetActive(true);  
            PlayerAxisCam.SetActive(false);
        }

    }
}
