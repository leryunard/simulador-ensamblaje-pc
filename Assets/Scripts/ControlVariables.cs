using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlVariables : MonoBehaviour
{
    public Slider sliderPresion;
    public TextMeshProUGUI textoResultadoPresion;

    public void EvaluarPresion()
    {
        float valor = sliderPresion.value;

        if (valor < 3)
        {
            textoResultadoPresion.text = "Presión insuficiente";
            textoResultadoPresion.color = Color.red;
        }
        else if (valor > 7)
        {
            textoResultadoPresion.text = "Presión excesiva";
            textoResultadoPresion.color = Color.red;
        }
        else
        {
            textoResultadoPresion.text = "Presión óptima";
            textoResultadoPresion.color = Color.green;
        }
    }
}