﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class faceenemy : MonoBehaviour
{
    // Start is called before the first frame update
    public AIPath aiPath;

    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f)
        {
            transform.localScale = new Vector3(-3f, 3f, 3f);
  
        }
        else if (aiPath.desiredVelocity.x <= -0.01f)
        {
            transform.localScale = new Vector3(3f, 3f, 3f);

        }
    }
}
