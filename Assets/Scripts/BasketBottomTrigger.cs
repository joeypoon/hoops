using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBottomTrigger : MonoBehaviour {

    public int scoreValue = 2;
    private Collider basketball;
    private ScoreKeeper scoreKeeper;

    private void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ExpectCollider(Collider collider)
    {
        basketball = collider;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (basketball && basketball == collider)
        {
            scoreKeeper.IncrementScore(scoreValue);
        }
    }
}
