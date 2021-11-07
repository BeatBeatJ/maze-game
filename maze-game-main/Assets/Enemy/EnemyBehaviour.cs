using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public float speed = 5.0f;
    public float minDist = 0f;
    public Transform target;

    void Start()
    {
        if (target == null)
        {

            if (GameObject.FindWithTag("Player") != null)
            {
                target = GameObject.FindWithTag("Player").GetComponent<Transform>();
            }
        }
    }

    void Update()
    {
        if (target == null)
            return;

        transform.LookAt(target);

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance > minDist)
            transform.position += transform.forward * speed * Time.deltaTime;
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}