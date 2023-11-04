using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectMoveToPlayer : MonoBehaviour
{
    public Transform target;
    public float deltaZ;
    private void Start()
    {
        deltaZ = transform.position.z - target.position.z;
    }
    private void LateUpdate()
    {
        Vector3 newPos= new Vector3();
        newPos = target.position;
        newPos.z += deltaZ;

        transform.position = newPos;
    }
}
