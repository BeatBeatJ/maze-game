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

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {
        counter = counter + Time.deltaTime * speed * direction;
        transform.position = new Vector3(originalPosition.x, counter, originalPosition.z);

        if (counter > maxheight) {
        direction = -1;
        }
        if (counter < minheight) {
            direction = 1f;
            }
    }
}
