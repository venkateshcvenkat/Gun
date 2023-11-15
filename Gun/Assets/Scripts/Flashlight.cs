using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    Light testlight;
    public float minwaittime;
    public float maxwaittime;

    private void Start()
    {
        testlight = GetComponent<Light>();
        StartCoroutine(Flashing());
    }

    IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minwaittime,maxwaittime));
            testlight.enabled = !testlight.enabled;
        }
    }

}
