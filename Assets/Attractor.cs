using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    [SerializeField] Rigidbody rb; 
    float G = 6.674f;

    void Attract(Attractor other)
    {
        Rigidbody rb2 = other.rb;
        
        //F = G(m1*m2)/r^2
        Vector3 direction = rb.position - rb2.position;

        float distance = direction.magnitude;

        float forceMagnitude = G * (rb.mass * rb2.mass) / Mathf.Pow(distance,2);

        Vector3 finalForce = forceMagnitude * direction.normalized;
        
        rb2.AddForce(finalForce);
    }
    
}
