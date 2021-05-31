﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBricks : MonoBehaviour
{
    public float width = 10;
    public float height = 10;

    public GameObject brick;

    private GameObject parent;

    void Start()
    {
        Generate();
    }

    void Generate() 
    {
        parent = new GameObject();
        parent.transform.position = Vector3.zero;
        parent.transform.name = "Bricks Parent";

        float cont = 0f;

        for(int y = 0; y < height; y++)
        {
            for(int x = 0; x < width; x++)
            {
                GameObject go = brick;
                go.transform.position = new Vector3(x + 0.5f, y - cont, 0);

                Instantiate(go, parent.transform);

            }
            cont += 0.5f;
        }
    }
}
