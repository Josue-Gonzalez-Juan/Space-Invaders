using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;

    private Rigidbody2D playerRb2d;

    public float speed;

    public Transform shottingOffset;
    // Update is called once per frame
    void Start()
    {
        playerRb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 0) * speed;
        playerRb2d.MovePosition(playerRb2d.position + movement * Time.fixedDeltaTime);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
            Debug.Log("Bang!");

            Destroy(shot, 5f); 

        }
    }
}
