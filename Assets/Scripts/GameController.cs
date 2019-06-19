using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController instance;

    public GameObject gameOverText;

    public Text scoreText;

    public bool gameOver = false;

    public float scrollSpeed = -1.5f;
    public int score = 0;

    // Start is called before the first frame update

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void BridScored() {
        if (gameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void BridDied() {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
