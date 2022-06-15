using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    new Rigidbody2D rigidbody2D;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        //rigidbody2D.velocity = new Vector3(5, 0, 0);
    }

    void Update()
    {
        //Debug.Log(PlayerControl.vel);
        //Debug.Log(rigidbody2D.velocity);
        rigidbody2D.drag = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 direction = (collision.transform.position - transform.position).normalized;
        rigidbody2D.AddForce(-direction * 0.5f, (ForceMode2D)ForceMode.Impulse);
    }
}
