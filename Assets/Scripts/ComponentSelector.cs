using UnityEngine;

public class ComponentSelector : MonoBehaviour
{
    public GameObject panelCPU;
    public GameObject panelRAM;
    public GameObject panelAlmacenamiento;
    public GameObject panelGPU;

    public void MostrarCPU()
    {
        ActivarSolo(panelCPU);
    }

    public void MostrarRAM()
    {
        ActivarSolo(panelRAM);
    }

    public void MostrarAlmacenamiento()
    {
        ActivarSolo(panelAlmacenamiento);
    }

    public void MostrarGPU()
    {
        ActivarSolo(panelGPU);
    }

    public void CerrarCPU()
    {
        panelCPU.SetActive(false);
    }

    public void CerrarRAM()
    {
        panelRAM.SetActive(false);
    }

    public void CerrarAlmacenamiento()
    {
        panelAlmacenamiento.SetActive(false);
    }

    public void CerrarGPU()
    {
        panelGPU.SetActive(false);
    }

    private void ActivarSolo(GameObject activo)
    {
        panelCPU.SetActive(false);
        panelRAM.SetActive(false);
        panelAlmacenamiento.SetActive(false);
        panelGPU.SetActive(false);

        if (activo != null)
            activo.SetActive(true);
    }
}