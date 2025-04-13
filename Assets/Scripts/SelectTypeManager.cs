using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectTypeManager : MonoBehaviour
{
    public void SelectLaptop()
    {
        Debug.Log("Se eligió Laptop");
        // Aquí cargarás la escena del ensamblaje de laptop
        SceneManager.LoadScene("AssemblyLaptop");
    }

    public void SelectDesktop()
    {
        Debug.Log("Se eligió Desktop");
        // Aquí cargarás la escena del ensamblaje de desktop
        SceneManager.LoadScene("AssemblyDesktop");
    }
}