using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

    
    public class EstadoPatrullar : MonoBehaviour{
    
    private Agente agent;
    public Transform [] destinos;
    private int destinoActual = 0;
    
    private void Awake (){
        this.agent= GetComponent <Agente>();
    
    }

    private void OnEnable (){
        
        this.destinoActual++;
        if (this.destinoActual == this.destinos.Length){
            this.destinoActual = 0;
        }
        this.agent.nma.SetDestination (this.destinos [this.destinoActual].position);
        this.agent.nma.isStopped = false;
        this.agent.nma.speed = 2f;
    }

    private void Update (){
        if (!this.agent.nma.pathPending && this.agent.nma.hasPath && this.agent.nma.remainingDistance < 0.5f){
            this.enabled = false;
            this.agent.nma.isStopped = true;
        }
    }

}

