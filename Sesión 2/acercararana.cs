using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acercararana : MonoBehaviour
{
    cercasilla notificador;
    GameObject[] aranas;
    bool moveTowardsZombie = false;
    Vector3 zombiepos;
    public float speed = 10f;
    void Start()
    {
        aranas = GameObject.FindGameObjectsWithTag("arana");
        notificador = GameObject.Find("Zombie").GetComponent<cercasilla>();
        notificador.Onproximosilla += moveToZombie;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveTowardsZombie)
        {
            foreach (GameObject arana in aranas)
            {
                arana.transform.position = Vector3.MoveTowards(arana.transform.position, zombiepos, Time.deltaTime * speed); // speed is a public float that determines how fast the spiders move
            }
        }
    }

    void moveToZombie()
    {
        zombiepos = GameObject.Find("Zombie").transform.position;
        moveTowardsZombie = true;
    }
}
