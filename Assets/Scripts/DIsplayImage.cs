using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayImage : MonoBehaviour
{
    public int CurentWall
    {
        get { return currentWall; }
        set
        {
            if (value == 5)
                CurentWall = 1;
            else if (value == 0)
                currentWall = 4;
            else
                currentWall = value;
        }
    }

    private int currentWall;
    private int previousWall;

    void Start()
    {
        
    }
}
