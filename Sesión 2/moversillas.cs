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
        notificador.Onproximopizarra += move;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*
    Modifico la manera en la que se mueven las sillas
    */
    void move() {
      Vector3 zombiepos = GameObject.Find("Zombie").GetComponent<Transform>().position;
      foreach (GameObject silla in sillas) {
            Vector3 directionToZombie = (zombiepos - silla.transform.position).normalized;
            silla.transform.position += directionToZombie * movdist;
      }
    }
}
