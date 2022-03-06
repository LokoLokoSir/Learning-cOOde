using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerControl : MonoBehaviour
{
    private bool isFlickering = false;
    private float timeDelay;

    void Update()
    {
        if(isFlickering == false) {
            StartCoroutine(FlickeringLight());
        }
    }

    IEnumerator FlickeringLight() {
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        timeDelay = Random.Range(0.1f, 0.2f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        timeDelay = Random.Range(5f, 6f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }
}