﻿using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //technique for making sure there isn't a null reference during runtime if you are going to use get component
public class Bullet : MonoBehaviour
{
  private Rigidbody2D myRigidbody2D;

    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
      myRigidbody2D = GetComponent<Rigidbody2D>();
      Fire();
    }

    //when bullet collides with something
    private void OnCollisionEnter2D(Collision2D other)
    {

        Destroy(other.gameObject);
        Destroy(myRigidbody2D.gameObject);
        //Debug.Log("I hit: " + other.collider.name);
    }

    // Update is called once per frame
    private void Fire()
    {
      myRigidbody2D.velocity = Vector2.up * speed; 
      Debug.Log("Wwweeeeee");
    }
}
