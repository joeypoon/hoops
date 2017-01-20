using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float timer = 60;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
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
