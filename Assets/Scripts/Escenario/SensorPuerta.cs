using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorPuerta : MonoBehaviour
{
    
    public GameObject panelIzq;
    
    public GameObject panelDer;
    private Animation animIzq;
    private Animation animDer;
    void Awake (){
        animIzq = panelIzq.GetComponent <Animation> ();
        animDer = panelDer.GetComponent <Animation> ();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider c){
        
        if (c.CompareTag ("Player")){
            Debug.Log ("Pase por el sensor");
            animDer.Play ("PanelDerecho");
            animIzq.Play ("PanelIzquierdo");
        }
    }
}
