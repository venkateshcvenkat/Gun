using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Speeddometer : MonoBehaviour
{
    public float maxspeed = 280;
    public float Speed = 0;
    public float maxarowangle;
    public float minarowangle;

    public Rigidbody rb;
    public Text text;
    public RectTransform value;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Speed = rb.velocity.magnitude * 3.6f;
        text.text = Speed.ToString("0") + " /km";

        value.localEulerAngles = new Vector3(0, 0, Mathf.Lerp(minarowangle, maxarowangle, Speed / maxspeed));
    }
}
