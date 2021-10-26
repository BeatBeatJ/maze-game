using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    
    public Vector3 originalPosition;
    public float counter = 10f;
    public float speed = 1f;
  
    public void TurnOn()
    {
        transform.position = new Vector3(originalPosition.x, counter, originalPosition.z);
    }


    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        counter = counter * speed;
    }
}
