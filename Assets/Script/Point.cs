
using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class Point : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] _text;
    /// <summary>
    /// text[0] score
    ///     [1] finalscore
    ///     [2] medalname
    ///     [3] best
    ///     [4] announce
    /// </summary>

    public static int best;

    [SerializeField] private GameObject _new;
    public static bool score;
    [SerializeField] private List<TextMeshProUGUI> texts = new List<TextMeshProUGUI>();
    private void Start()
    {
        loadBest();
        load();
    }
    public void Update()
    {
        _text[0].text = Bird._point.ToString();

        if (score == true) //when die
        {
            eachScore();
            saveBest();
            _text[1].text = _text[0].text;
            texts[5].text = best.ToString();
            medalAndAnn();
            score = false;
        }
        if (Bird._isplay == true)
        {
            _text[0].gameObject.SetActive(true);
        }
    }
    void eachScore()
    {
        SaveData.tableScore._score.Insert(0, Bird._point);
        SaveData.tableScore.check();
        SaveData.Save(SaveData.tableScore, "/table.json");
        load();
    }
    void load()
    {
        SaveData.Load(ref SaveData.tableScore, "/table.json");
        texts[5].text = best.ToString();
        for(int i = 0; i < 5; i++)
        {
            texts[i].text = SaveData.tableScore._score[i].ToString();
        }
        
    }
    void saveBest()
    {
        if (Bird._point > best)
        {
            _new.SetActive(true);
            SaveData.score.best = Bird._point;
            SaveData.Save(SaveData.score, "/score.json");
            loadBest();
        }
        _text[3].text = best.ToString();

    }
    void loadBest()
    {
        SaveData.Load(ref SaveData.score, "/score.json");
        best = SaveData.score.best;
    }
    void medalAndAnn()
    {

        if (Bird._point >= 10 && Bird._point < 20)
        {
            _text[2].text = "bronze"; /////

            if (Bird._point >= 18)
            {
                _text[4].text = "reach 20 to get silver coin";
            }
            else _text[4].text = "good job";
        }
        else if (Bird._point >= 20 && Bird._point < 30) ////
        {
            _text[2].text = "silver";////

            if (Bird._point >= 28)
            {
                _text[4].text = "reach 30 to get gold coin";
            }
            else _text[4].text = "go go go";

        }
        else if (Bird._point >= 30)
        {
            _text[2].text = "gold !!";

            _text[4].text = "you get the best!!!";
        }
        /////
        //////
        if (Bird._point < 8)
        {
            _text[4].text = "you noob :))";
        }
        else if (Bird._point < 10 && Bird._point >= 8)
        {
            _text[4].text = "closest to a coin";
        }
    }

}
