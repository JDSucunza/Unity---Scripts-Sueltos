using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RAngoVision : MonoBehaviour
{
    private Agente agent;

    public LayerMask layers;

    public int distanciaMaximaVision;
    public float maxAngulo = 0.5f;

    public int rango;
    void Awake (){
        this.agent = GetComponent <Agente>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vectorAPj = this.agent.player.transform.position - transform.position;
        vectorAPj.Normalize();
        float dot = Vector3.Dot (transform.forward, vectorAPj);
        if (EstaEnAnguloDeVision () ){
            Debug.Log ("Encontre al Player");
        }
        EstaADistanciaDeVision();
    }

    private bool EstaEnAnguloDeVision (){
       Vector3 vectorAPj = this.agent.player.transform.position - transform.position;
        vectorAPj.Normalize();
        float dot = Vector3.Dot (transform.forward, vectorAPj);
        return (dot > maxAngulo);
    }

    private void EstaADistanciaDeVision(){
        Collider[] colliders = Physics.OverlapSphere (transform.position, rango, layers);
        if (colliders.Length > 0){
            Debug.Log (colliders[0]);
            //colliders [0].transform.position;
        }
    }
        void OnDrawGizmos()
    {
       Gizmos.DrawWireSphere (transform.position, rango);
    }
    
}
