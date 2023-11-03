using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cercasilla : MonoBehaviour
{
    public delegate void proximosilla();
    public event proximosilla Onproximosilla;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "silla") {
            Debug.Log("silla");
            Onproximosilla();
        }
    }
}
