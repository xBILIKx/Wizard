using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRotation : MonoBehaviour
{
    public float speed;
    Material mat;
    Color color;
    private void Start()
    {
        mat = GetComponent<Renderer>().material;
        color = mat.color;
    }
    void Update()
    {
       transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    void ChildDestroy()
    {
        color.a -= 0.25f;
        mat.color = color;
    }
}
