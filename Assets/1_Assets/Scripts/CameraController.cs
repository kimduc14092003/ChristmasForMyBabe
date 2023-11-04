using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Player object

    public float smoothSpeed = 0.125f; // Điều chỉnh tốc độ camera theo dõi

    public Vector3 offset; // Để điều chỉnh vị trí theo dõi

    private void Start()
    {
        offset = transform.position - target.position;
    }
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

       // transform.LookAt(target); // Camera nhìn vào player
    }
}
