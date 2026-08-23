using UnityEngine;

public class ARTouchController : MonoBehaviour
{
    void Update()
    {
        // 1. Detectar si hay un toque activo en la pantalla del celular
        if (Input.touchCount > 0)
        {
            Touch toque = Input.GetTouch(0);

            // 2. Ejecutar la acción solo en el instante en que el dedo toca la pantalla
            if (toque.phase == TouchPhase.Began)
            {
                // 3. Lanzar un rayo virtual desde la cámara hacia el punto tocado
                Ray rayo = Camera.main.ScreenPointToRay(toque.position);

                // 4. Detectar colisiones específicamente en 2D
                RaycastHit2D impacto = Physics2D.GetRayIntersection(rayo);

                if (impacto.collider != null)
                {
                    // 5. Extraer el componente de datos del objeto tocado
                    CellPartSelectable organulo = impacto.collider.GetComponent<CellPartSelectable>();

                    if (organulo != null)
                    {
                        // Ejecutar el método que escribimos antes
                        organulo.SeleccionarOrganulo();
                    }
                }
            }
        }
    }
}