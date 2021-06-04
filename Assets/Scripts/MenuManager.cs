using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MenuManager : MonoBehaviour
{
     
    public Text bestScoreText;
    public static string playerName;
    public static string bestPlayer;
    public GameObject inputField;
    public GameObject textDisplay;
    public static int bestScore = 0;


    public void Start()
    {
        ShowBestScore();
    }

    public void StoreName()
    {
        playerName = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Your name is: " + playerName;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowBestScore()
    {
        var path = Application.persistentDataPath + "/bestScore.json";
        if (File.Exists(path))
        {
           
                string json = File.ReadAllText(path);
                var data = JsonUtility.FromJson<Save>(json);
                bestPlayer = data.playerName;
                bestScore = data.score;
                bestScoreText.text = "Best Score: " + bestPlayer + " : " + bestScore;
            
        }
    }

          
}
