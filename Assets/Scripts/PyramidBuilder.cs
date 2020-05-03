using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramidBuilder : MonoBehaviour
{
    public GameObject cube;
    public GameObject pyramid;

    void Start()
    {
        Vector3 size = cube.GetComponent<Collider>().bounds.size;
        
        int maxHeight = 30;

        for (int height = 0; height < maxHeight; height++)
        {
            int length = maxHeight - height;
            for (int x = -length; x <= length; x++)
            {
                for (int z = -length; z <= length; z++)
                {
                    if (Mathf.Abs(x) == length || Mathf.Abs(z) == length)
                    {
                        MakeCube(new Vector3(x, height, z));
                    }
                }
            }
        }
    }

    public void MakeCube(Vector3 position)
    {
        GameObject block = Instantiate(cube, position, Quaternion.identity) as GameObject;
        block.transform.parent = pyramid.transform;
    }
}
