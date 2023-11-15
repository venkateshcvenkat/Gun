using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterExit : MonoBehaviour
{
    public Transform player;
    public Transform car;
    public carcontroller controller;
    public GameObject cam;
    public Animator anim;

    bool playerin = false;
    bool isDriving = false;

    // Start is called before the first frame update
    void Start()
    {
        controller.enabled = false;
        cam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerin)
        {
            player.transform.SetParent(car);
            player.gameObject.SetActive(false);
            controller.enabled = true;
            isDriving = true;
            cam.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Q) && isDriving)
        {
            player.transform.SetParent(null);
            player.gameObject.SetActive(true);
            controller.enabled = false;
            isDriving = false;
            cam.SetActive(false); ;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            anim.Play("right");
            anim.Play("L");
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            anim.Play("right_close");
            anim.Play("R");
        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag== "Player")
        {
            playerin = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            playerin = false;
        }
    }
}
