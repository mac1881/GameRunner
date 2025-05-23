using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static bool isGameStarted;
    public GameObject startingText;

    public static int numberOfCoins;
    public Text coinsText;

    private void Awake()
    {
        numberOfCoins = PlayerPrefs.GetInt("NumberOfCoins",0);
    }
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        coinsText.text = "Diamond Coins:" + numberOfCoins;
        if (SwipeManager.tap)
        {
            isGameStarted = true;
            Destroy(startingText);
        }
    }
}
