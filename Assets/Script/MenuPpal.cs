using UnityEngine;

public class MenuPpal : MonoBehaviour
{
   public GameObject optionsMenu;
    public GameObject mainMenu;
    public void OpenOptionsPanel()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void OpenMainMenuPanel()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
    public void ExitGame()
    {
        Debug.Log("Salir del juego....");
        Application.Quit();
    }
    public void StartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}

