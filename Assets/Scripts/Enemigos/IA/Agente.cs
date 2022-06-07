using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agente : MonoBehaviour
{
    [HideInInspector]
    public NavMeshAgent nma;

   
    public Animator anim;
    // Lista de Estados:
    [HideInInspector]
    public Idle estadoIdle;
    [HideInInspector]
    public Recorrer estadoRecorrer;
  
    //--------------------------------------------------------------------------------------------
    public GameObject player;
    
    private void Awake (){
        estadoIdle = GetComponent <Idle>();
        estadoRecorrer = GetComponent <Recorrer>();
        nma = GetComponent <NavMeshAgent> ();
        anim = GetComponent <Animator> ();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
