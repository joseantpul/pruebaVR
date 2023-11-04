using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moversillas : MonoBehaviour
{
    float movdist = 2.0f;
    cercapizarra notificador;
    GameObject[] sillas;
    void Start()
    {
        sillas = GameObject.FindGameObjectsWithTag("silla");
        notificador = GameObject.Find("Zombie").GetComponent<cercapizarra>();
        notificador.Onpp += move;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void move() {
      Vector3 zombiepos = GameObject.Find("Zombie").GetComponent<Transform>().position;
      foreach (GameObject silla in sillas) {
        silla.transform.position = new Vector3(zombiepos.x - movdist, silla.transform.position.y, zombiepos.z - movdist);
      }
    }
}
