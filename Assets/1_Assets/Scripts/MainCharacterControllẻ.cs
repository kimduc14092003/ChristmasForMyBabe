using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoBehaviour
{
    private Rigidbody rb;
    public bool testBool1;
    public float walkVelocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (testBool1)
        {
            rb.velocity = new Vector3(0, 0, 1) * walkVelocity;
        }
    }
}
