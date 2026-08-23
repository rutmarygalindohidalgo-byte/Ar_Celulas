using UnityEngine;

public class MirarCamara : MonoBehaviour
{
    private Camera camaraPrincipal;

    void Start()
    {
        // Busca automáticamente la cámara del celular al iniciar
        camaraPrincipal = Camera.main;
    }

    void Update()
    {
        // Hace que la célula siempre mire hacia la cámara
        if (camaraPrincipal != null)
        {
            transform.LookAt(transform.position + camaraPrincipal.transform.rotation * Vector3.forward,
                             camaraPrincipal.transform.rotation * Vector3.up);
        }
    }
}