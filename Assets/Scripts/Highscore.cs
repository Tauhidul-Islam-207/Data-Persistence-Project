using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{   
    //Fields for display the player info
    public Text bestText;


    //Static variables for holding the best player data
    private static int bestScore;
    private static string bestPlayer;


    private void Awake()
    {
        LoadGameRank();
    }
    


    private void SetBestPlayer()
    {
        if (bestPlayer == null && bestScore == 0)
        {
            bestText.text = "";
        }
        else
        {
            bestText.text = $"Best Score : {bestPlayer} : {bestScore}";
        }

    }

    public void LoadGameRank()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayer = data.theBestPlayer;
            bestScore = data.highiestScore;
            SetBestPlayer();
        }
    }

    [System.Serializable]
    class SaveData
    {
        public int highiestScore;
        public string theBestPlayer;
    }
}