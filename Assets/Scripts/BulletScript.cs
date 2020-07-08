using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(0, 0, 0.2f);
    }
}
