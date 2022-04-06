using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBehavior : MonoBehaviour
{

    public Transform Center;
    public float Radius;//公转半径
    public float revolutionTime;//公转时间
    public float selfRotateTime;//自转时间

    private float currentAngle;
    private Vector3 startDir;



    void Start()
    {
        Radius = Vector3.Distance(transform.position, Center.position);
        startDir = (transform.position - Center.position).normalized;
    }

    
    void Update()
    {
        float angleSpeed = 360f / revolutionTime;
        currentAngle = currentAngle + angleSpeed * Time.deltaTime;
        if (currentAngle > 360) currentAngle -= 360;
        Vector3 dir = Quaternion.AngleAxis(currentAngle, Vector3.up) * startDir;
        transform.position = Center.position + dir * Radius;

        float angleDelta = 360f / selfRotateTime;
        transform.Rotate(Vector3.up, angleDelta * Time.deltaTime);
    }
}
