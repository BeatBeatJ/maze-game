using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
   public GameObject target = null;
   private bool TurnedOn = false;
  
    void Update()
    {
      

    }

    void OnTriggerEnter (Collider user)
    {
        
        if(user.gameObject.tag == "Fist" && TurnedOn == false)
        {
            TurnedOn = true;
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            Debug.Log("Button pressed ON");
            target.SendMessage("TurnOn");
        }

        //if(user.gameObject.tag == "Fist" && TurnedOn == true)
        //{
            //TurnedOn = false;
            //gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            //Debug.Log("Button pressed OFF");
            //target.SendMessage("TurnOff");
        //}
        
    } 
}
