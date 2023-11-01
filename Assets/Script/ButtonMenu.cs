using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class ButtonMenu : MonoBehaviour
{
    public GameObject _setting;
    public GameObject _return;
    public GameObject _board;
    public GameObject _play;
    public GameObject board;
    int count;
    public TextMeshProUGUI textMeshPro;
    private void Awake()
    {
        Time.timeScale = 1.0f;
    }
    public void click()
    {
        _setting.SetActive(false);
        _return.SetActive(true);
        _board.SetActive(true);
        _play.SetActive(false);
    }
    public void Return()
    {
        _setting.SetActive(true);
        _return.SetActive(false);
        _board.SetActive(false);
        _play.SetActive(true);
        board.SetActive(false);
    }
    public void _playGame()
    {
        SceneManager.LoadScene(1);
    }
    public void deleteScore()
    {
        if(count == 1) { count = 0; }else { count = 1; }
        if (count == 0)
        {
            board.SetActive(false);

            SaveData.score.best = 0;
            SaveData.Save(SaveData.score, "/score.json");
        }
        else textMeshPro.text = "ARE YOU SURE";
    }
    
    public void resetScore()
    {
        count = 0;
        board.SetActive(true);
        textMeshPro.text = "Do you want to reset your best score?";
    }
    public void exit()
    {
        board.SetActive(false);
    }
}
