using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones : MonoBehaviour
{
    
    private Animator anim;
    
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent <Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        Caminar ();
        CaminarAtras();
        Izquierda();
        Derecha ();
        

    }

    private void Caminar (){
        if (Input.GetKeyDown ("w")){
            anim.SetBool ("Walk", true);
        }
        if (Input.GetKeyUp ("w")){
            anim.SetBool ("Walk", false);
        }
    }
    private void CaminarAtras(){
        if (Input.GetKeyDown ("s")){
            anim.SetBool ("WalkBack", true);
        }
        if (Input.GetKeyUp ("s")){
            anim.SetBool ("WalkBack", false);
        }
    }

    private void Izquierda(){
        if (Input.GetKeyDown ("a")){
            anim.SetBool ("Izquierda", true);
        }
        if (Input.GetKeyUp ("a")){
            anim.SetBool ("Izquierda", false);
        }
    }

     private void Derecha(){
        if (Input.GetKeyDown ("d")){
            anim.SetBool ("Derecha", true);
        }
        if (Input.GetKeyUp ("d")){
            anim.SetBool ("Derecha", false);
        }
    }
}
