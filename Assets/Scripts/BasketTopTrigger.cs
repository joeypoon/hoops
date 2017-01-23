using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketTopTrigger : MonoBehaviour {

    private BasketBottomTrigger bottomTrigger;

    private void Start()
    {
        bottomTrigger = GetComponentInChildren<BasketBottomTrigger>(); 
    }

    void OnTriggerEnter(Collider collider)
    {
        bottomTrigger.ExpectCollider(collider);
    }
}
