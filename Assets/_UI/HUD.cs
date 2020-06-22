﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD HUDManager;
    [SerializeField] public Text Txt_Score;
    [SerializeField] public Image Image_Lives;
    [SerializeField] public Text Txt_Message;
 
    void Start()
    {
        HUDManager = this;
    }

    private void Update()
    {
        Txt_Score.text = "SCORE : " + GameManager.gameManager.Score;
        Image_Lives.rectTransform.sizeDelta = new Vector2(GameManager.gameManager.Lives * 50, 30);
    }
    public void UpdateScore()
    {
        Txt_Score.text = "SCORE : " + GameManager.gameManager.Lives;
    }

    //updates the number of hearts for lives
    public void UpdateLives()
    {
        Image_Lives.rectTransform.sizeDelta = new Vector2(GameManager.gameManager.Lives * 50, 30);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameManager.CurrentState = GameManager.GameState.GameOver;
        Txt_Message.color = Color.red;
        Txt_Message.text = "GAME OVER! \n PRESS ENTER TO RESTART GAME.";
    }

    public void DismissMessage()
    {
        Txt_Message.text = "";
    }
}
