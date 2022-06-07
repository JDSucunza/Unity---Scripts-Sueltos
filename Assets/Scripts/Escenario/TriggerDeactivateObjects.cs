using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeactivateObjects : MonoBehaviour
{
    
    public GameObject objectToActivate;


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider c){
        if (c.CompareTag ("Player")){
            objectToActivate.SetActive (true);
        }
    }

}
