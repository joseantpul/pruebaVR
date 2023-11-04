using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    float max_X_distance = 3.0f;
    float max_Z_distance = 1.0f;
    public float speed = 2.0f;
    public float rotationSpeed = 30.0f; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = transform.forward;
        dir.Normalize();
        transform.Translate(dir * speed * Time.deltaTime, Space.World);
        float giro = Input.GetAxis("Horizontal");
        transform.Rotate(0.0f, giro, 0.0f, Space.Self);   
        if (Input.GetKeyDown("t")) {
          float x_dis = Random.Range(-max_X_distance, max_X_distance);
          float z_dis = Random.Range(-max_Z_distance, max_Z_distance);
          transform.position = new Vector3(transform.position.x + x_dis, transform.position.y, transform.position.z + z_dis);
        }
    }
}
