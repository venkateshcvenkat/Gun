using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public  Animator animator;
    public bool isopened = false;

    public void Dooranimation()
    {
        isopened = !isopened;
        if (isopened)
        {
            animator.Play("fe");
        }
        else
        {
            animator.Play("R");
        }
    } 
    
   
   
}
