using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.01f;

    //private void Start()
    //{
    //    if (this.tag == "Red Player")
    //    {
    //        Debug.Log("hello");
    //    }
    //    if(this.tag == "Blue Player")
    //    {
    //        Debug.Log("blue");
    //    }
    //}

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
}
