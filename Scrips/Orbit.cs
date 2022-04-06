using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private PlanetBehavior planetBehavior;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        planetBehavior = GetComponent<PlanetBehavior>();

        int count = 361;
        lineRenderer.positionCount = count;
        Vector3[] points = new Vector3[count];
        Vector3 startDir = Vector3.right;
        for(int i = 0; i < count; i++)
        {
            float currentAngle = i;
            Vector3 dir = Quaternion.AngleAxis(currentAngle, Vector3.up) * startDir;
            Vector3 point = planetBehavior.Center.position + dir * planetBehavior.Radius;
            points[i] = point;
        }
        lineRenderer.SetPositions(points);
    }

    void Update()
    {
        
    }
}
