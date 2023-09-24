
using UnityEngine;
using TMPro;

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

    public GameObject _new;

    [SerializeField] private Bird _bird;

    string KEY = "score";

    private void Awake()
    {
        Load(KEY);
    }
    public void Update()
    {

        _text[0].text = _bird.Point.ToString();
        
        if (Bird._gameOver == true)
        {

                if(_bird.Point > best)
                {

                    _new.SetActive(true);
        ///<summary>
        /// save new best and load
        /// </summary>

                    Save(KEY, _bird.Point);
                    PlayerPrefs.Save();

                    Load(KEY);
                }
                _text[3].text = best.ToString();

                _text[1].text = _text[0].text;

            medalAndAnn();   /// void ///
        }


        if(Bird._isplay == true)
        {
            _text[0].gameObject.SetActive(true);
        }
    }
/// <summary>
/// announcement based on point
/// <param name="medalAndAnn" ></param>
/// </summary><
    void medalAndAnn() 
    {
        
        if (_bird.Point >= 20 && _bird.Point < 40)
        {
            _text[2].text = "bronze"; /////

            if (_bird.Point >= 35)
            {
                _text[4].text = "reach 40 to get silver coin";
            }
            else _text[4].text = "keep calm";
        }
        else if (_bird.Point >= 40 && _bird.Point < 75) ////
        {
            _text[2].text = "silver";////

            if (_bird.Point >= 70)
            {
                _text[4].text = "reach 75 to get gold coin";
            }
            else _text[4].text = "try your best";

        }
        else if (_bird.Point >= 75)
        {
            _text[2].text = "gold !!";

            _text[4].text = "are you hacking !";
        }
        /////
        //////
        if( _bird.Point < 17)
        {
            _text[4].text = "you noob :))";
        }else if(_bird.Point < 20 && _bird.Point >= 17)
        {
            _text[4].text = "closest to a coin";
        }
    }
    
    public void Save(string key, int best)
    {
        PlayerPrefs.SetInt(key, best);
    }
    /// <summary>
    /// load best score
    /// </summary>
    /// <param name="key"></param>
    ///
    public void Load(string key)
    {
        best = PlayerPrefs.GetInt(key);
    }
    public void Delete(string key)
    {
        PlayerPrefs.DeleteKey(key);
    }

}
