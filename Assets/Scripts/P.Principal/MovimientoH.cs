using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoH : MonoBehaviour
{
    private float anguloH;

    private void Update(){
        this.anguloH += Input.GetAxis("Mouse X");
        this.transform.eulerAngles = new Vector3(0, this.anguloH, 0);
    }
}
