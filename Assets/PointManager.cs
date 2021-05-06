using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PointManager : MonoBehaviour
{

    public int Point = 0;

    public GameObject TargetToDestroy;

    public int PointToEnableTarget;

    public void AddPoint(int amount)
    {
        Point = Point + amount;
        if(Point >= PointToEnableTarget)
        {
            Destroy(TargetToDestroy);
        }
        
    }

}
