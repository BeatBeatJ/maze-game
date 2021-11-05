using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
   public GameObject target = null;

    void OnTriggerEnter (Collider user)
    {
        
        if(user.gameObject.tag == "Player" || user.gameObject.tag == "Fist")
        {
            Debug.Log("Button pressed");
            target.SendMessage("TurnOn");
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }
    } 
}
