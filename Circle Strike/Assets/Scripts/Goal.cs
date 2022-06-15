using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    [SerializeField] GameObject redPlayer;
    [SerializeField] GameObject bluePlayer;
    [SerializeField] GameObject ball;
    [SerializeField] TextMeshProUGUI redScore;
    [SerializeField] TextMeshProUGUI blueScore;

    private int rScore = 0;
    private int bScore = 0;

    void Start()
    {
        //redScore = GetComponent<TextMeshProUGUI>();
        //blueScore = GetComponent<TextMeshProUGUI>();

        redScore.text = "Red Player: " + rScore;
        blueScore.text = "Blue Player: " + bScore;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Ball")
        {
            if(tag == "Red Goal")
            {
                blueScore.text = "Blue Player: " + (++bScore);
                Debug.Log("Blue Player Scored");
            }

            if(tag == "Blue Goal")
            {
                redScore.text = "Red Player: " + (++rScore);
                Debug.Log("Red Player Scored");
            }

            Reset();
        }

    }

    void Reset()
    {
        redPlayer.transform.position = new Vector3(-6, 0, 0);
        bluePlayer.transform.position = new Vector3(6, 0, 0);
        ball.transform.position = new Vector3(0, 0, 0);
        ball.GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
    }
}
