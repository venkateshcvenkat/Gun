using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    public GameObject camera4;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetButtonDown("1"))
        {
            Cameraone();
        }
        if (Input.GetButtonDown("2"))
        {
            CameraTwo();
        }
        if (Input.GetButtonDown("3"))
        {
            CameraThree();
        }
        if (Input.GetButtonDown("4"))
        {
            CameraFour();
        }
    }
   void Cameraone()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(false);
    }
    void CameraTwo()
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
        camera3.SetActive(false);
        camera4.SetActive(false);
    }
    void CameraThree()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(true);
        camera4.SetActive(false);
    }
    void CameraFour()
    {
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(false);
        camera4.SetActive(true);
    }
}
