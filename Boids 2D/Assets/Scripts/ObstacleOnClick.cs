using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleOnClick : MonoBehaviour {

    public GameObject Prefab;
    public int RayDistance = 10;
    private Vector3 Point = new Vector3(-1, -1, -1);
    public LayerMask Whatever;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Point.z = 0;
            //Make Whatever a Raycast layer or if you don't want it just exclude it
            if (InRange(Point))
            {
                Debug.Log(Point.x.ToString());
                Instantiate(Prefab, Point, Quaternion.identity);
            }
        }
    }

    bool InRange(Vector3 p)
    {
        if (p.y >= -17.0f && p.y <= -16.0f)
        {
            if(p.x >= -33.0f && p.x <= -23.0f)
            {
                return false;
            }
            else if (p.x >= -14.0f && p.x <= -4.0f)
            {
                return false;
            }
            else if (p.x >= 4.0f && p.x <= 14.0f)
            {
                return false;
            }
            else if (p.x >= 23.0f && p.x <= 33.0f)
            {
                return false;
            }
        }
        return true;
    }
}
