using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLight : MonoBehaviour
{
    
     void TurnOn()
    {
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
    }
    

}
