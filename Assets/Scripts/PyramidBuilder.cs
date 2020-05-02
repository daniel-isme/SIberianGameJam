using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidBuilder : MonoBehaviour
{
    private List<GameObject> blocks = new List<GameObject>();

    void Start()
    {
        int length = 10;
        for (int x = -length; x <= length; x++)
        {
            for (int z = -length; z <= length; z++)
            {
                if (Mathf.Abs(x) == length || Mathf.Abs(z) == length)
                {
                    MakeCube(new Vector3(x, 0, z));
                }
            }
        }
    }

    public void MakeCube(Vector3 position)
    {
        blocks.Add(Instantiate(gameObject, position, Quaternion.identity));
    }
}
