using UnityEngine;
using UnityEngine.SceneManagement;

public class AssemblyDesktopManager : MonoBehaviour
{
    // Este objeto contendrá los componentes colocados en la mesa
    public Transform componentesColocadosParent;

    // Función para volver a la escena anterior (SelectType)
    public void Volver()
    {
        SceneManager.LoadScene("SelectType");
    }

    // Función para limpiar la mesa de trabajo (elimina componentes hijos)
    public void LimpiarMesa()
    {
        Debug.Log("Limpiando mesa de trabajo...");

        foreach (Transform hijo in componentesColocadosParent)
        {
            Destroy(hijo.gameObject);
        }
    }
}