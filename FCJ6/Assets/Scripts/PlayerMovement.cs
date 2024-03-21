using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float timer = 0f;
    bool jumpReady = true;
    bool isGrounded = true;
    public float force = 5f;
    public float bigForce = 10f;

    // Update is called once per frame
    void Update()
    {
        if(timer > 0f && !jumpReady)
        {
            timer -= Time.deltaTime;
        } else if (!jumpReady)
        {
            jumpReady = true;
        }

        bool lmb = Input.GetMouseButtonDown(0);
        bool rmb = Input.GetMouseButtonDown(1);
        if (lmb && isGrounded && jumpReady)
        {
            Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);

            Vector3 dir = objPos - this.transform.position;

            this.GetComponentInParent<Rigidbody2D>().AddForce(dir.normalized * force, ForceMode2D.Impulse);

            Debug.Log("AddForce");

            jumpReady = false;
            timer = 0.5f;
        } else if (rmb && isGrounded && jumpReady)
        {
            Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            Vector3 objPos = Camera.main.ScreenToWorldPoint(mousePos);

            Vector3 dir = objPos - this.transform.position;

            this.GetComponentInParent<Rigidbody2D>().AddForce(dir.normalized * bigForce, ForceMode2D.Impulse);

            Debug.Log("AddForce");

            jumpReady = false;
            timer = 0.5f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }
}
