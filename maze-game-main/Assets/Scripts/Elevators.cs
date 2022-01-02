using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevators : MonoBehaviour
{
    public Vector3 originalPosition;
    public float counter = 0f;
    public float direction = 1;
    public float speed = 1f;
    public float maxheight = 3f;
    public float minheight = -3f;
    public bool ButtonPressed = false;
    Renderer rend;

    public void TurnOn()
    {
        ButtonPressed = true;
        Debug.Log("Elevator Activated");
    }
    

    public void ElevatorMove()
    {
        transform.position = new Vector3(originalPosition.x, counter, originalPosition.z);
        
        counter = counter + Time.deltaTime * speed * direction;
        if (counter > maxheight) {
            direction = -1;
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        }
        if (counter < minheight) {
            direction = 1f;
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            }
    }

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;

        rend = GetComponent<Renderer> ();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ButtonPressed == true) { 
            ElevatorMove();
        }
    }
}
