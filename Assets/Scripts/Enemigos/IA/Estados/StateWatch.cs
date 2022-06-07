using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateWatch : MonoBehaviour
{
    private ManagerEnemy manager;
    public Transform [] checkPoints;
    private int currentPoint = 0;
    public float speedWatch = 2f;
    
    void Awake(){
        this.manager = GetComponent < ManagerEnemy> ();
    }

    private void OnEnable (){
        Debug.Log ("StateWatch");
        this.SetStateWatch ();    
    }
   
    private void SetStateWatch (){
        //-----------Setup: Settings-------------
        this.manager.nma.SetDestination (this.checkPoints [this.currentPoint].position);
        this.manager.nma.isStopped = false;
        this.manager.nma.speed = speedWatch;
        this.currentPoint ++;
        if (this.currentPoint == this.checkPoints.Length){
            this.currentPoint = 0;
        }
        //-----------Setup: Animations------------
        this.manager.anim.SetBool ("Walk", true);
    }
    
    
    void Update(){
        Debug.Log ("Watch");
        if (this.ArrivedCheckPoint()){
            
            this.enabled = false;
            this.manager.nma.isStopped = true;
            this.manager.idleState.enabled = true;
            this.manager.anim.SetBool ("Walk", false);
        }
        
    }

    private bool ArrivedCheckPoint (){
        return (!this.manager.nma.pathPending && this.manager.nma.hasPath && this.manager.nma.remainingDistance < 0.5f);
    }
}
