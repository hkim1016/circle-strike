using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    public static Vector3 vel;

    // Update is called once per frame
    void Update()
    {
        if(this.tag == "Red Player")
        {
            if(Input.GetKey("a"))
            {
                //this.transform.position = this.transform.position + new Vector3(-moveSpeed, 0, 0);
                this.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("w"))
            {
                this.transform.Translate(0, moveSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey("d"))
            {
                this.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("s"))
            {
                this.transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
            }
        }

        if(this.tag == "Blue Player")
        {
            if (Input.GetKey("left"))
            {
                //this.transform.position = this.transform.position + new Vector3(-moveSpeed, 0, 0);
                this.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("up"))
            {
                this.transform.Translate(0, moveSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey("right"))
            {
                this.transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("down"))
            {
                this.transform.Translate(0, -moveSpeed * Time.deltaTime, 0);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log(collision.rigidbody.velocity);
        //Debug.Log(collision.collider.bounds);
        //collision.rigidbody.velocity = Vector3.Reflect(transform.position, collision.contacts[0].normal);
        //vel = collision.relativeVelocity;

    }
}
