using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTracker : MonoBehaviour
{

    public Text scoreText;
    //SceneManager sm;

    int score;
    // Start is called before the first frame update
    void Start()
    {
        //Animation triggering on grab
        //sm = new SceneManager;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        if (score >= 100)
        {
            //Load another scene, maybe a win screen?

        }
    }

    public void IncreaseScore(int x)
    {
        score += x;
    }
}
