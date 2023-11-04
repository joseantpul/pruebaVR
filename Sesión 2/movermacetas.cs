using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movermacetas : MonoBehaviour
{
    float max_X_distance = 3.0f;
    float max_Z_distance = 8.0f;
    cercapizarra notificador;
    GameObject[] macetas;
    void Start()
    {
        macetas = GameObject.FindGameObjectsWithTag("maceta");
        notificador = GameObject.Find("Zombie").GetComponent<cercapizarra>();
        notificador.Onproximopizarra += teleport;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void teleport() {
        foreach (GameObject maceta in macetas) {
            float x_dis = Random.Range(-max_X_distance, max_X_distance);
            float z_dis = Random.Range(0, max_Z_distance);
            maceta.transform.position = new Vector3(maceta.transform.position.x + x_dis, maceta.transform.position.y, maceta.transform.position.z + z_dis);
        }
    }
}
