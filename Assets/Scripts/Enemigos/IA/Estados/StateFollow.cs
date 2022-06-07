using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateFollow : MonoBehaviour
{
    private ManagerEnemy manager;
    public float distanceObjective = 2f; 
    public float outOfRange = 10f;
    public float speedFollow = 5f;    
    void Awake (){
        this.manager = GetComponent <ManagerEnemy> ();
    }

    void OnEnable (){
        SetStateFollow();
    }
    
    void Update()
    {
        if (!CloseEnough() && !OutOfRange()){
            this.manager.nma.SetDestination (this.manager.player.transform.position);
            
        } else if (CloseEnough()){
            //this.manager.attackState.enabled = true;
            this.enabled = false;
        }   
    }

    private void SetStateFollow(){
        // ----------- Setup - Follow State: Settings ---------
        this.manager.nma.speed = speedFollow;
        this.manager.anim.SetBool ("Run", true);
         // --------Setup - Alert State: States --------
        this.manager.idleState. enabled = false;
        this.manager.watchState. enabled = false;
        // -------- Setup - Alert State: Animations   
        this.manager.anim.SetBool ("Run", true);

    }
    private bool CloseEnough (){
        return (Vector3.Distance (this.manager.player.transform.position, transform.position) < distanceObjective);
    }

    private bool OutOfRange (){
        return (Vector3.Distance (this.manager.player.transform.position, transform.position) > outOfRange);
    }

}
