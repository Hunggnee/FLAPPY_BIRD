using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class SaveData 
{
    public static Data score = new Data();
    public static SaveVolume saveVolume = new SaveVolume();
    public static TableScore tableScore = new TableScore();
    public static Coin coin = new Coin();
    public static void Save<T>(T field, string name)
    {
        string filename = Application.persistentDataPath + name;
        string data = JsonUtility.ToJson(field);
        Debug.Log(data);
        File.WriteAllText(filename, data);
    }
    public static void Load<T>(ref T field, string name)
    {
        string filename = Application.persistentDataPath + name;
        string data = File.ReadAllText(filename);
        field = JsonUtility.FromJson<T>(data);
    }
}
[SerializeField]
public class Data
{
    public int best;
}
public class SaveVolume
{
    public float volume;
    public int check;
}
public class TableScore
{
    public List<int> _score = new List<int>(5);
    public void check()
    {
        if(_score.Count > 5)
        {
            _score.RemoveAt(5);
        }
    }
}
[SerializeField]
public class Coin
{
    public int b;
    public int s;
    public int g;
}