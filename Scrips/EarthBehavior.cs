using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthBehavior : MonoBehaviour
{
    public float selfRotateTime;//自转时间
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angleDelta = 360f / selfRotateTime;
        transform.Rotate(Vector3.up, angleDelta * Time.deltaTime);
    }
}
