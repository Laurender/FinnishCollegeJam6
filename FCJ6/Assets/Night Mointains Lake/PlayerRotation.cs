using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    Vector3 myScale;
    Vector3 pushScale;
    bool canPush = true;
    public float speed = 50f;
    void Start()
    {
        myScale = transform.localScale;
        pushScale = myScale * 1.3f;
    }

    void Update()
    {
        /*Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = direction.normalized;*/

        transform.Rotate(0f, 0f, -Input.GetAxis("Horizontal")*speed);

        if (Input.GetMouseButtonDown(0) && canPush)
        {
            StartCoroutine(PushHands());
        }
    }

    IEnumerator PushHands (){
        canPush = false;
        transform.localScale = pushScale;
        yield return new WaitForSeconds(Time.deltaTime * 2);
        transform.localScale = myScale;
        canPush = true;
    }
}
