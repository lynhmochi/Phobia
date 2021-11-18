using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDisappear : MonoBehaviour
{
    public GameObject SpiderToSpawn;
    void Update() {  
        if (Input.GetMouseButtonDown (0)) {    
             var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hit;
 
             if (Physics.Raycast(ray, out hit, 100)) {
                 if(hit.collider.tag == "cardboardBox") {                         
                     Debug.Log("---> Hit: ");
                     Instantiate(SpiderToSpawn,hit.transform);  
                     Destroy(hit.transform.gameObject);
                 }
             }    
         }
    }
}
