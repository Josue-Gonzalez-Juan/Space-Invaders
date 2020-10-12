using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D enemyRB;

    public GameObject bullet;
    public float fireRate;

    public int pointValue;

    public float speed;

    public float dropDown;

    public Transform shootingOffset;

    // Update is called once per frame
    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (UnityEngine.Random.Range(0.0f, 1.0f) > fireRate)
        {
            GameObject shot = Instantiate(bullet, shootingOffset.position, Quaternion.identity);
            Destroy(shot, 5f);
        }
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(1, 0) * speed;
        enemyRB.MovePosition(enemyRB.position + movement * Time.fixedDeltaTime);
    }

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        speed = speed * -1; //makes the enemy bounce from wall to wall

        enemyRB.position += Vector2.down * dropDown;
        Debug.Log("Ouch!" + enemyRB.position);
    }
}
