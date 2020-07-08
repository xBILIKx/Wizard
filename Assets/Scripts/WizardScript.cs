using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardScript : MonoBehaviour
{
    public int hp = 5;
    public GameObject parent;
    void Update()
    {
        if (hp == 0)
        {
            Destroy(gameObject);
            parent.SendMessage("ChildDestroy");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
            hp -= 1;
        }
    }
}
