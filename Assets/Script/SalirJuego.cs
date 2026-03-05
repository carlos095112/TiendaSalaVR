using UnityEngine;

public class SalirJuego : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void CerrarAplicacion()
    {
       Debug.Log("Saliendo del juego...");
        Application.Quit();
    }
}
