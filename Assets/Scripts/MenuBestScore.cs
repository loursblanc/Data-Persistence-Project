using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif




[DefaultExecutionOrder(1000)]

public class MenuBestScore : MonoBehaviour
{
    public InputField playerNameInputField;
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
            Application.Quit(); // original code to quit Unity player
#endif
    }


    public void setPlayerName() => BestScoreManager.Instance.PlayerName = playerNameInputField.text;

}

