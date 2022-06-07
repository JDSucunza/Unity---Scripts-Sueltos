using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateAlert : MonoBehaviour
{
    private ManagerEnemy manager;
    public float  speedAlert = 5f ;
    
    void Awake(){
        this.manager = GetComponent <ManagerEnemy> ();
    }

    void OnEnable(){
        Debug.Log ("Alert");
        SetAlertState ();
    }

    public void SetAlertState (){
     // --------Setup - Alert State: Settings ------
        this.manager.nma.speed = speedAlert;
        this.manager.nma.SetDestination (this.manager.player.transform.position);
        //this.manager.soundDetect.radius = radiusAlert;

     // --------Setup - Alert State: States --------
        this.enabled = true;
        this.manager.idleState. enabled = false;
        this.manager.watchState. enabled = false;
        this.manager.followState. enabled = false;
    
     // -------- Setup - Alert State: Animations   
        this.manager.anim.SetBool ("WalkAlert", true);
        
        
    }
    void Update (){
        if (ArrivedDestination()){
            this.enabled = false;
            this.manager.idleAlertState.enabled = true;
        }
    }

    private bool ArrivedDestination (){
        return (this.manager.player.transform.position == this.transform.position);
    }
}
