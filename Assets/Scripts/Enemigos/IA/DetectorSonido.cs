using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorSonido : MonoBehaviour
{
    private Agente agent;
    public int alcance;

    private Collider[] colliders;

    public LayerMask layers;
    
    void Awake (){
        agent = GetComponent <Agente>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        colliders = Physics.OverlapSphere (transform.position, 10, layers);
    }

  
}
