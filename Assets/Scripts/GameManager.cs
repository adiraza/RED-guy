using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //public Player thePlayer;
    private Vector2 playerStart;

    public GameObject victoryScreen;
    public GameObject gameOverScreen;
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //playerStart = thePlayer.transform.position;
    }

    public void Victory()
    {
        victoryScreen.SetActive(true);
        //thePlayer.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        //thePlayer.gameObject.SetActive(false);
    }
    public void reloadscene()
    {
        SceneManager.LoadScene(1);
    }
    public void Reset()
    {
        victoryScreen.SetActive(false);
        gameOverScreen.SetActive(true);
    }
}
