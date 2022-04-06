using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsOrbit : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private PlanetBehavior planetBehavior;

    Vector3[] points;
    int cur;
    int count;
    void Start()
    {

        lineRenderer = GetComponent<LineRenderer>();
        planetBehavior = GetComponent<PlanetBehavior>();

        count = 150000;
        cur = 150000;
        points = new Vector3[count];

        for (int i = 0; i < count; i++) points[i] = transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        if (cur == count) cur = 0;
        lineRenderer.positionCount = cur+1;
        lineRenderer.SetPosition(cur++,transform.position);
    }
}
