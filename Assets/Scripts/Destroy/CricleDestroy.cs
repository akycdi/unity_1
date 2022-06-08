using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CricleDestroy : MonoBehaviour
{
    Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.transform.tag == "Circle")
        {

            if (rb.velocity.magnitude < other.rigidbody.velocity.magnitude)
            {

                Destroy(this.gameObject);
            }
            else
            {
                Destroy(other.gameObject);
            }
        }
    }
    private void Update()
    {
        Vector3 newV = new Vector3(transform.position.x, transform.position.y, 0);
        transform.position = newV;
    }
}
