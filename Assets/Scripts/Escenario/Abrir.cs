using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrir : MonoBehaviour
{
    
    public bool estaAbierto = false;             //Verificar si esta abierto o no.
    public float doorOpenAngle = 95f;           // Angulo ded la puerta estando abierta.
    public float doorCloseAngle = 0.0f;         // Angulo de la puerta estando cerrada.
    public float smooth = 3.0f;                 // Velocidad con que rotara la puerta.

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (estaAbierto){
            CerrarPuerta();
        }   else{
                AbrirPuerta();
            }
    }

    public void CerrarPuerta (){
        Quaternion targetRotation = Quaternion.Euler (0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation, smooth * Time.deltaTime);
    }
    public void AbrirPuerta (){
        Quaternion targetRotation2 = Quaternion.Euler (0, doorCloseAngle, 0);
                transform.localRotation = Quaternion.Slerp (transform.localRotation, targetRotation2, smooth * Time.deltaTime);
    }

}
