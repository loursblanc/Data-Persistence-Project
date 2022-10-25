using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreManager : MonoBehaviour
{
    public static BestScoreManager Instance;
    public string PlayerName;
    public int PlayerBestScore = 0;
    public string BestScorePlayerName;
    public int BestScore;

    public void Awake()
    {
        if(Instance != null)
        {
            Destroy(Instance);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    public class SaveData
    {
       public int Score;
       public string PlayerName;
    }

    public void SaveBestScore()
    {
        SaveData data = new SaveData();
        data.Score = PlayerBestScore;
        data.PlayerName = PlayerName;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            BestScore = data.Score;
            BestScorePlayerName = data.PlayerName;
        }
        else
        {
            BestScore = 0;
            BestScorePlayerName = " ";
        }
    }

}





