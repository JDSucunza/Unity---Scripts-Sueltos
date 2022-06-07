using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public float distanciaTiro = 100f;

    //public float daño = 5f;

    public Transform InicioRayoDisparo;

    public GameObject efectoDisparo;

    private Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent <Animation> ();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            
            this.Disparar();
            
            if (Physics.Raycast (InicioRayoDisparo.position, Camera.main.transform.forward, out hit, distanciaTiro)){
                Debug.Log (hit.collider.name);
                
                
                
            }
    
        }

               
    }
    private void OnDrawGizmos (){
        Gizmos.color = Color.red;
        Gizmos.DrawRay (InicioRayoDisparo.position, InicioRayoDisparo.transform.forward * distanciaTiro);
    }

    private void Disparar (){
        this.anim.Play ("PistolaSilenciada");
    }
}

