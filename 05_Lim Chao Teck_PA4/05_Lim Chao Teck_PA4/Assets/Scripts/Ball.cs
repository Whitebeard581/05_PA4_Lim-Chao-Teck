using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float timeCounter = 0;

    float speed;
    float width;
    float height;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2f;
        width = 0.3f;
        height = 0.3f;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * width;
        float y = 0.7f;
        float z = Mathf.Sin(timeCounter) *height;

        transform.position = new Vector3(x, y, z);
    }
}
