﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    public float speed = 20;
    public GameObject fireSpot;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        transform.LookAt(player.transform);
        GetComponent<Rigidbody>().velocity = transform.forward.normalized * speed;
        Invoke("Destroy", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
