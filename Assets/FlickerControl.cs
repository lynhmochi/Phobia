using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerControl : MonoBehaviour
{
    public bool isFlickering = false;
    public float timeDelay; 
    public Material material;

    void Update()
    {
        if(isFlickering == false){
            StartCoroutine(FlickeringLight());
        }
    }
    IEnumerator FlickeringLight(){
        isFlickering = true;
        this.gameObject.GetComponent<Light>().enabled = false;
        material.DisableKeyword ("_EMISSION");
        timeDelay = Random.Range(0.01f, 0.7f);
        yield return new WaitForSeconds(timeDelay);
        this.gameObject.GetComponent<Light>().enabled = true;
        material.EnableKeyword ("_EMISSION");
        timeDelay = Random.Range(0.01f, 0.7f);
        yield return new WaitForSeconds(timeDelay);
        isFlickering = false;
    }
}
