using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float timer = 5;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () { 
        if (Input.GetKeyUp(KeyCode.Space))
        {
            LoadScene(2);
        }

        timer -= Time.deltaTime;
        if (timer <= 0 && SceneManager.GetActiveScene().buildIndex == 1)
        {
            LoadScene(2);
        }
	}

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
