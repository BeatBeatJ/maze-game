using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetShot : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Bullet")
        {
            //Destroy(gameObject); //Or teleport/damage/any defeat condition.
            Debug.Log("Got shot!");
        }
    }
}
