using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float rotateSpeed;
    public GameObject bullet;
    float dTime;
    float time;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = !Cursor.visible;
            Cursor.lockState = Cursor.lockState == CursorLockMode.Locked ? CursorLockMode.None : CursorLockMode.Locked;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            time = Time.time;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            dTime = Time.time - time;
            dTime = Mathf.Floor(dTime);
            if (dTime > 5)
                dTime = 5;
            StartCoroutine(spawnBullet());
        }
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed * Time.deltaTime;
        transform.Translate(movement);
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotateSpeed, 0);
    }

    IEnumerator spawnBullet()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        yield return new WaitForSeconds(0.5f);
        if(dTime > 1)
        {
            dTime--;
            StartCoroutine(spawnBullet());
        }
    }
}
