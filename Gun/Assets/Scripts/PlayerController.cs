using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController c;
    public Animator anim;
    public float speed = 5f;
    public float turnspeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        c = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 forward = new Vector3(0, 0, z) * speed * Time.deltaTime;
        forward = transform.TransformDirection(forward);
        c.Move(forward);

        transform.Rotate(Vector3.up * x * turnspeed * Time.deltaTime);


        if (z > 0)
        {
            anim.SetBool("Walk", true);
        }
        else
        {

            anim.SetBool("Walk", false);
        }


        if (Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
    }
}
