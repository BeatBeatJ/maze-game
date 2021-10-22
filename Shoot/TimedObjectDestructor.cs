using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedObjectDestructor : MonoBehaviour
{
    Rigidbody bullet;
    public float lifeSpan = 2.0f;

    private int gNum = 0;
    private char gMode = 'a';
    private string temp = "";

    void Update()
    {
        if (lifeSpan > 0 && gameObject.tag == "Bullet")
        {
            lifeSpan = lifeSpan - Time.deltaTime;
        }
        else if (gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject); //Remove this if following is uncommented.

        /*if (collision.gameObject.tag == "Floor" | collision.gameObject.tag == "Wall" | collision.gameObject.tag == "Bullet")
        {
            Freeze(gameObject.GetComponent<Rigidbody>());
            Inflate(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        void Freeze(Rigidbody item)
        {
            item.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotation;
        }

        void Inflate(GameObject item)
        {
            item.transform.localScale = new Vector3(2f, 2f, 2f);
        }*/
    }
}