using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectTypeManager : MonoBehaviour
{
    public void SelectLaptop()
    {
        SceneManager.LoadScene("AssemblyLaptop");
    }

    public void SelectDesktop()
    {
        SceneManager.LoadScene("AssemblyDesktop");
    }
}