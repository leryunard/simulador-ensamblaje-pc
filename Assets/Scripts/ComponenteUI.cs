using UnityEngine;
using TMPro;

public class ComponenteUI : MonoBehaviour
{
    [Header("Instancia del componente")]
    public GameObject prefabAInstanciar;
    public Transform mesaDeTrabajo;

    [Header("UI de orientación")]
    public TextMeshProUGUI feedbackOrientacion;

    [Header("Contador de componentes")]
    public ControlComponentes controladorComponentes;

    [Header("UI de presión aplicada")]
    public ControlVariables controladorPresion;

    public void AgregarComponente()
    {
        // Verificar que todo esté asignado
        if (prefabAInstanciar == null)
        {
            Debug.LogError("Falta asignar el prefabAInstanciar en el Inspector.");
            return;
        }

        if (mesaDeTrabajo == null)
        {
            Debug.LogError("Falta asignar el objeto mesaDeTrabajo en el Inspector.");
            return;
        }

        // Instanciar el componente en la mesa
        GameObject instancia = Instantiate(prefabAInstanciar, mesaDeTrabajo);
        instancia.transform.localPosition = Vector3.zero + Random.insideUnitSphere * 0.2f;

        // Evaluar orientación
        if (feedbackOrientacion != null)
        {
            float rotacionY = instancia.transform.rotation.eulerAngles.y;

            if (rotacionY > 10f && rotacionY < 350f)
            {
                feedbackOrientacion.text = "Orientación incorrecta";
                feedbackOrientacion.color = Color.red;
            }
            else
            {
                feedbackOrientacion.text = "Orientación correcta";
                feedbackOrientacion.color = Color.green;
            }
        }
        else
        {
            Debug.LogWarning("No hay texto de orientación asignado.");
        }

        // Notificar al controlador de contador
        if (controladorComponentes != null)
        {
            controladorComponentes.ComponenteAgregado();
        }

        // Evaluar presión actual
        if (controladorPresion != null)
        {
            controladorPresion.EvaluarPresion();
        }
    }
}
