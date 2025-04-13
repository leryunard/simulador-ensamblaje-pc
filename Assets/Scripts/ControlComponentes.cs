using UnityEngine;
using TMPro;

public class ControlComponentes : MonoBehaviour
{
    public int contador = 0;
    public TextMeshProUGUI textoContador;

    public void ComponenteAgregado()
    {
        contador++;
        ActualizarTexto();
    }

    public void ReiniciarContador()
    {
        contador = 0;
        ActualizarTexto();
    }

    void ActualizarTexto()
    {
        if (textoContador != null)
        {
            textoContador.text = $"Componentes colocados: {contador}";

            if (contador > 4)
                textoContador.color = Color.red;
            else
                textoContador.color = Color.green;
        }
    }
}