using UnityEngine;

public class CellPartSelectable : MonoBehaviour
{
    [Header("Información del Orgánulo")]
    [Tooltip("El nombre exacto de esta parte de la célula")]
    public string nombreOrganulo;

    [Tooltip("La explicación científica que verá el usuario")]
    [TextArea(3, 5)]
    public string descripcion;

    // Este método se ejecutará cuando el raycast de la pantalla táctil golpee el colisionador
    public void SeleccionarOrganulo()
    {
        UIManager.Instancia.MostrarInfo(nombreOrganulo, descripcion);
    }
}