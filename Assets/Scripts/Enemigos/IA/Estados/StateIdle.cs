using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateIdle : MonoBehaviour
{
    private ManagerEnemy manager;
    private float time;
    public float LimitTime;


    void Awake(){
        this.manager = GetComponent <ManagerEnemy> ();
    }

        void OnEnable (){
        Debug.Log ("StateIdle");
        time = 0;
        this.manager.anim.SetBool ("Idle", true);
        
    }

    void Update(){
        time = time + 1 * Time.deltaTime;
        if (time >= LimitTime){
            this.manager.anim.SetBool ("Idle", false);
            this.enabled = false;
            this.manager.watchState.enabled = true;
        }
    }


}
