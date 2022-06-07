using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoV : MonoBehaviour
{
       private float anguloY;
    private void Update(){
        this.anguloY += Input.GetAxis("Mouse Y");
        this.anguloY = Mathf.Clamp(this.anguloY, -90, 90);
        this.transform.eulerAngles = new Vector3(-this.anguloY, this.transform.eulerAngles.y, this.transform.eulerAngles.z);        
    }
}
