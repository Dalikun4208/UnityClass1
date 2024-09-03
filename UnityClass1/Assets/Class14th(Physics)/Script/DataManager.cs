using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] int score;
    // Start is called before the first frame update
    void Awake()
    {
        Load();
    }

    public void Save()
    {
        PlayerPrefs.Save();
    }

    public void Load()
    {
        score = PlayerPrefs.GetInt("Score", score);
    }

    public void Increase()
    {
        score += 10;
        PlayerPrefs.SetInt("Score", score);
    }

    public void OnServerInitialized()
    {
        PlayerPrefs.DeleteAll();
        Load();
    }

}
