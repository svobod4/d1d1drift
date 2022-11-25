using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public float verticalInput;
    public float xRange = 50;
    public float zRange = 50;
    public float dxRange = 50;
        public float dzRange = 50;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);

        if (transform.position.x > xRange)
        { 
                    transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z< -zRange)
            {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
                   }

      

    }
}