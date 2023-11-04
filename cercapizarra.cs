using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cercapizarra : MonoBehaviour
{
    bool already_close = false;
    public delegate void proximopizarra();
    public event proximopizarra Onproximopizarra;
    public event proximopizarra Onpp;
    Transform pizarra_t;
    public float detectionRadius = 3.0f;
    void Start()
    {
        pizarra_t = GameObject.Find("Tableau").GetComponent<Transform>();
        if(pizarra_t == null) Debug.Log("Pizarra no encontrada");
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, pizarra_t.position);
        if (distance < detectionRadius && !already_close)
        {
           Onproximopizarra();
           Onpp();
           already_close = true;
        } else if (distance > detectionRadius) already_close = false;
    }
    
    void OnCollisionEnter(Collision other) {
      Debug.Log(other.gameObject.tag);
    }
}
