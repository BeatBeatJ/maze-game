using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk_Frog : MonoBehaviour
{

    public bool Activated;
    public float speed;
    public Vector3 originalPosition;
    private float direction = 1;
    private float counter = 0f;
    public float direction = 1;


    void walk()
    {
        counter = counter + Time.deltaTime * speed * direction;
        transform.position = new Vector3(originalPosition.x, originalPosition.y, originalPosition.z);

    }


    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
     if(collision.gameObject.tag == "Environment")

    }

   


}
