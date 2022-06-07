using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ManagerEnemy : MonoBehaviour
{ 
    
    //-------------Tools--------------------
    [HideInInspector]
    public NavMeshAgent nma;
    [HideInInspector]
    public Animator anim;

    //--------------StateList---------------
    [HideInInspector]
    public StateIdle idleState;
    [HideInInspector]
    public StateWatch watchState;
    [HideInInspector]
    public StateAlert alertState;
    [HideInInspector]
    public StateFollow followState;
    [HideInInspector]
    public StateIdleAlert idleAlertState;
    
    //---------------ExternalInfo----------------
    
    public GameObject player;
    
    void Awake()
    {
        //---------Setup: Tools------------------
        this.nma = GetComponent <NavMeshAgent> ();
        this.anim = GetComponent <Animator>(); 
        
        //-------------Setup: States-------------
        this.idleState = GetComponent <StateIdle>();    
        this.watchState = GetComponent <StateWatch>();
        this.followState = GetComponent <StateFollow> ();
        this.idleAlertState = GetComponent <StateIdleAlert> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
