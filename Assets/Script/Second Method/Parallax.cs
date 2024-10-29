using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    Material material;
    float distance;

    [Range(0f, 0.5f)]
    public float Speed;

    void Start()
    {
        //We could do this to a Sprite renderer too, but now we are using 3D
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        distance += Time.deltaTime * Speed;
        material.SetTextureOffset("_MainTex", Vector2.right * distance);
    }
}
