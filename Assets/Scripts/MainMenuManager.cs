using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartSimulation()
    {
        SceneManager.LoadScene("SelectType");
    }

    public void QuitApp()
    {
        Debug.Log("Saliendo...");
        Application.Quit();
    }
}