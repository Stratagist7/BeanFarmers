using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Made by Kenneth Tang
public class MenuManager : MonoBehaviour
{
    // To Menu Screen
    public void ToMenu()
    {
        GameStateManager.QuitToTitle();
    }

    // Start new game
    public void OnClickNewGame1P()
    {
        GameStateManager.NewGame1P();
    }

    public void OnClickNewGame2P()
    {
        GameStateManager.NewGame2P();
    }

    // Quit Game
    public void OnClickQuitGame()
    {
        Application.Quit();
    }
}
