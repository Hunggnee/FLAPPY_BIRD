using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField] private GameObject _pauseBut;
    [SerializeField] private GameObject _pausepanel;
    [SerializeField] private GameObject _diePanel;
    [SerializeField] private GameObject _board;
    [SerializeField] private GameObject _return;
    [SerializeField] private GameObject _top;
    public void Pausegame()
    {
        _pausepanel.SetActive(true);
        Time.timeScale = 0;
        Bird._isplay = false;
    }
    private void Update()
    {
        if (Bird._isplay == true)
        {
            _pauseBut.SetActive(true);
        }
        else
        {
            _pauseBut.SetActive(false);
        }
    }
    public void top()
    {
        _top.SetActive(false);
        _board.SetActive(true);
        _return.SetActive(true);
    }
    public void returnGame()
    {
        _top.SetActive(true);
        _board.SetActive(false);
        _return.SetActive(false);
    }

    public void resume()
    {
        Bird._isplay = true;
        Time.timeScale = 1;
        _pausepanel.SetActive(false);
        
    }
    private void FixedUpdate()
    {
        if (Bird._gameOver == true)
        {
            _diePanel.SetActive(true);
            Bird._isplay = false;
            Time.timeScale = 0;
        }
    }
    public void Tomenu()
    {
        SceneManager.LoadScene(0);
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);       
    }
}
