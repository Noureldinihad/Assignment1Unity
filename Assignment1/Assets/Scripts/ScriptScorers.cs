using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;
using UnityEngine.UI;
using System;

public class ScriptScorers : MonoBehaviour
{
    public Text scoreText;
    public static string playerName;
  //  public static int playerScore;

    User user = new User();

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Hello:" + playerName;
    }
    public void OnSubmit()
    {
        playerName = "Nour";
        PostToDatabase();
    }

    private void PostToDatabase()
    {
        User user = new User();
        RestClient.Put("https://assignment1-8ddaf-default-rtdb.firebaseio.com/" + playerName + ".json", user);
          
    }
    public void OnGetScore()
    {
        RetrieveFromDatabase();

    }
    private void UpdateScore()
    {
        scoreText.text = "Hello : " + user.userName;
    }
    private void RetrieveFromDatabase()
    {
        RestClient.Get<User>("https://assignment1-8ddaf-default-rtdb.firebaseio.com/" + playerName + ".json").Then(response =>
            {
                user = response;
                UpdateScore();
            });
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
