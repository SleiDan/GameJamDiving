using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieMenu : MonoBehaviour
{
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    
    public void RestartLevel()
    {
        // Получаем индекс текущей загруженной сцены
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        // Перезагружаем текущую сцену
        SceneManager.LoadScene(currentSceneIndex);
        Time.timeScale = 1f;
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
