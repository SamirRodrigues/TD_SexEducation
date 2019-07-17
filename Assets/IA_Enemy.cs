using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Enemy : MonoBehaviour
{
    public Vector3 StartPosition;
    public Vector3 EndPosition;

    public int Point = 0;

    public GameObject[] PointPosition;

    public float distacePerFrame = 0f;

    void Start()
    {
        StartPosition = PointPosition[3].transform.position;
        EndPosition = PointPosition[4].transform.position;
    }

    void Update()
    {
        distacePerFrame += 0.005f;
        transform.position = Vector3.Lerp(StartPosition, EndPosition, distacePerFrame);

        if (transform.position == EndPosition)
        {
            for (int i = Point; i < 4; i++)
            {
                StartPosition = PointPosition[i].transform.position;
                
                EndPosition = PointPosition[i+1].transform.position;
                
                distacePerFrame = 0;                

                Point += 1;


                if (i == 3)
                {
                    Point = 0;
                }


                break;
            }
        }

        


    }
}
