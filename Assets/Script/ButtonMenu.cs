using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonMenu : MonoBehaviour
{
    public Button _setting;
    public Button _return;
    public GameObject _board;
    public GameObject _play;
    private void Awake()
    {
        Time.timeScale = 1.0f;
    }
    public void click()
    {
        _setting.gameObject.SetActive(false);
        _return.gameObject.SetActive(true);
        _board.SetActive(true);
        _play.SetActive(false);
    }
    public void Return()
    {
        _setting.gameObject.SetActive(true);
        _return.gameObject.SetActive(false);
        _board.SetActive(false);
        _play.SetActive(true);
    }
    public void _playGame()
    {
        SceneManager.LoadScene(1);
    }

}
