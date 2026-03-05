using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour  
{
    public void CambiarAScene(string Cosmic_Retro)
    {
        SceneManager.LoadScene(Cosmic_Retro);
    }
}

