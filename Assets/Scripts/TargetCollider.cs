using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollider : MonoBehaviour {

    public int points = 2;

    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<ScoreKeeper>().IncrementScore(points);
    }
}
