using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetBehavior : MonoBehaviour
{

    public Transform Center;
    public float Radius;//��ת�뾶
    public float revolutionTime;//��תʱ��
    public float selfRotateTime;//��תʱ��

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
