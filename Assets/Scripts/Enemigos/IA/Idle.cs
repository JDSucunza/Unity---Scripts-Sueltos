using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour
{
    private Agente agent;
    private float tempo;
    public float tiempoLimite;
    
    // Start is called before the first frame update
    
    void Awake (){
        agent = GetComponent <Agente> ();
            }
    void OnEnable (){
        tempo = 0;
        this.agent.anim.SetBool ("Idle", true);
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        tempo = tempo + 1 * Time.deltaTime;
        if (tempo >= tiempoLimite){
            this.agent.anim.SetBool ("Idle", false);
            this.enabled = false;
            this.agent.estadoRecorrer.enabled = true;
        }        
    
    }
}
