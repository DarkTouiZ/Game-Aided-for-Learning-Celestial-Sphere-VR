using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMotion : MonoBehaviour
{
    const float PI = 3.14159265359f;
    public GameObject MainSphere;
    public GameObject star;
    public float speed = 1f;
    public float dec = 0f;
    public float radius = 1.5f;
    public float offset = 0f;
    float t = 0f;

    void Start()    
    {
        offset = MainSphere.transform.position.y;
    }

    void Update()
    {
        float rdec = dec * PI / 180;
        t += Time.deltaTime * speed;
        float x = Mathf.Cos(t) * radius;
        float y = Mathf.Sin(t) * radius * Mathf.Cos(rdec);
        float z = Mathf.Sin(t) * radius * Mathf.Sin(rdec);

        star.GetComponent<Transform>().position = new Vector3(x, y + offset, z);
    }
}
