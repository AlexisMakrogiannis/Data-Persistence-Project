using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public string playerName;
    public GameObject inputField;
    public GameObject textDisplay;

    private void Awake()//gia na metaferw ta data
    {

        if (Instance != null)//an yparxei hdh main manager (main -> menu dhmiourgei 2o main manager)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;//otan den yparxei(menu -> main px. thn prwth fora)
        DontDestroyOnLoad(gameObject);

        
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
}
