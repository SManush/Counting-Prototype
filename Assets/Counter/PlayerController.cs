using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 5.0f;
    public float zRange = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(-11, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(-11, transform.position.y, zRange);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    }
}
