using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // this function will take the player directly to the game
    //when the play button is clicked
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    //this will take the player directly to the leaderboard panel
    public void DisplayLeaderBoard()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //this will take the user to the shop scene
    public void DisplayShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
