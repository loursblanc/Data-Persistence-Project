using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreManager : MonoBehaviour
{
    public static BestScoreManager Instance;
    public string PlayerName;
    public int PlayerBestScore = 0; 

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


}





