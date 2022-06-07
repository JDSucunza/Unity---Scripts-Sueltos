using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
     private void Start(){
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

}
