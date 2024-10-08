using UnityEngine;
using UnityEngine.UI;

public class PointCollector : MonoBehaviour
{
    public int puntos = 0; // Contador de puntos
    [SerializeField] private Text contadorDePuntos; // Referencia al objeto de texto

    void Start()
    {
        ActualizarContadorDePuntos();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión detectada con: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Plano")) // Verifica la etiqueta del plano
        {
            SumarPuntos(1);
        }
    }

  public void SumarPuntos(int cantidad)
{
    puntos += cantidad; // Sumar la cantidad de puntos
    Debug.Log("Puntos sumados: " + cantidad + ". Total puntos: " + puntos); // Verificación en la consola
    ActualizarContadorDePuntos(); // Actualiza el contador visual
}


    private void ActualizarContadorDePuntos()
    {
        if (contadorDePuntos != null)
        {
            contadorDePuntos.text = "Puntos: " + puntos.ToString();
        }
        else
        {
            Debug.LogWarning("El objeto contadorDePuntos no está asignado.");
        }
    }
}
