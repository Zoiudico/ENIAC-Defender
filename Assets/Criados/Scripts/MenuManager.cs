using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    
    public void StartGame()
    {
        var randomNumber = Random.Range(0f, 10f);
        if (randomNumber >= 4f)
        {
            SceneManager.LoadScene("Fase 1");
        } else if (randomNumber >= 7)
        {
            SceneManager.LoadScene("Fase 2");
        } else 
        {
            SceneManager.LoadScene("Fase 3");
        }
    }


    public void Opções()
    {
        
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu Inicial");
    }
}
