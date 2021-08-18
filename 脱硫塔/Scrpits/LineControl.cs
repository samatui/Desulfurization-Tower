using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineControl : MonoBehaviour
{
    private LineRenderer lr;
    private Transform[] points;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < points.Lenth; i++)
        {
            lr.SetPosition(i, points[i].position);

        }
    }

    public void SetUpLine(Transform[] points){
        lr.positionCount = points.Lenth;
        this.poionts = points;

    }
}
