using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class carSelector : MonoBehaviour
{
    public int currentCharacterIndex;
    public GameObject[] characters;

    void Start()
    {
        currentCharacterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
        foreach (GameObject character in characters)

            character.SetActive(false);

        characters[currentCharacterIndex].SetActive(true);
        
    }
    


    public void StartGameButton()
    {
        
        SceneManager.LoadScene("Level");
    }
}



