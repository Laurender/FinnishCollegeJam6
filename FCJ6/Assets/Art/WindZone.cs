using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindZoen : MonoBehaviour
{
    [SerializeField]
    float _ windForce = 0f:
        private void OnTriggerStay(Collider other)
    {
        var hitObj = other.gameObject;
        if(hitObj != null )
        {
            var rb hitObj.GetComponent<Rigidbody>();
            var dir = transform.up;
            rb.Addforce(dir * _windforce);
        }
    }
}
