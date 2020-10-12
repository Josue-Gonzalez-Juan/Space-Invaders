using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Reflection;

public class Raycast : MonoBehaviour
{
    public Text Score;
    public Text HighScore;

    private int score = 0;
    private int highScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //4, d
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Debug.DrawRay(ray.origin, ray.direction, Color.red);
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * 1000f, Color.red);
            RaycastHit2D hit2D = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit2D.collider != null)
            {
                if (hit2D.collider.name == "RedEnemy")
                {
                    score += 10;
                    if (score > highScore)
                    {
                        highScore = score;
                    }
                }else if (hit2D.collider.name == "YellowEnemy")
                {
                    score += 20;
                    if (score > highScore)
                    {
                        highScore = score;
                    }
                }
                else if (hit2D.collider.name == "OrangeEnemy")
                {
                    score += 30;
                    if (score > highScore)
                    {
                        highScore = score;
                    }
                }
                else if (hit2D.collider.name == "PurpleEnemy")
                {
                    score += 100;
                    if (score > highScore)
                    {
                        highScore = score;
                    }
                }
                Score.text = score.ToString("D4");
                HighScore.text = highScore.ToString("D4");
                Debug.Log("I hit: " + hit2D.collider.name);
                Destroy(hit2D.collider.gameObject);
            }
            else
            {
                Debug.Log("hit nothing");
            }
        }
    }
}
