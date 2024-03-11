using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float maxSpeed;

    private Rigidbody rig;

    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (rig.velocity.magnitude > maxSpeed)
        {
            rig.velocity = rig.velocity.normalized * maxSpeed;
        }
    }
}
