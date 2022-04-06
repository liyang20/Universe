using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehavior : MonoBehaviour
{
    public float SpeedFactor = 1f;
    public float ASpeedFactor = 1f;

    public float scollSpeed = 0.01f;
    public float moveSpeed = 0.1f;
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        transform.position += (h * transform.right * moveSpeed + v * transform.up * moveSpeed);
        if (Input.GetKey(KeyCode.Q)) transform.position += Vector3.forward * scollSpeed;
        if (Input.GetKey(KeyCode.E)) transform.position += Vector3.back * scollSpeed;

        transform.LookAt(Target);
    }
}
