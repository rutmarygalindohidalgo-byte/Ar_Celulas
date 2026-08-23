using System.Collections; // ¡Línea nueva obligatoria para usar temporizadores!
using UnityEngine;
using TMPro; // Librería necesaria para controlar los textos modernos

public class UIManager : MonoBehaviour
{
    // Creamos una instancia global (Singleton) para acceder fácilmente desde cualquier script
    public static UIManager Instancia;

    [Header("Conexiones de la Interfaz")]
    public TextMeshProUGUI textoTitulo;
    public TextMeshProUGUI textoDescripcion;
    public GameObject panelFondo;

    void Awake()
    {
        Instancia = this;
        // Ocultamos el panel al iniciar la aplicación para que la pantalla esté limpia
        panelFondo.SetActive(false);
    }

    // Este método recibirá los datos del orgánulo tocado y los inyectará en la UI
    public void MostrarInfo(string nombre, string descripcion)
    {
        textoTitulo.text = nombre;
        textoDescripcion.text = descripcion;
        panelFondo.SetActive(true); // Hace visible el panel

        // ¡NUEVO! Detenemos cualquier reloj anterior por si el usuario toca dos cosas muy rápido
        StopAllCoroutines();

        // ¡NUEVO! Iniciamos la cuenta regresiva de 7 segundos
        StartCoroutine(OcultarTextos(7f));
    }

    // ¡NUEVO! El temporizador invisible
    IEnumerator OcultarTextos(float segundos)
    {
        // Espera en silencio la cantidad de segundos que le indicamos
        yield return new WaitForSeconds(segundos);

        // Pasado el tiempo, apaga el panel de nuevo
        panelFondo.SetActive(false);
    }
}