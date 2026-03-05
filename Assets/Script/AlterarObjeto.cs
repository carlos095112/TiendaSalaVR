using UnityEngine;

public class AlterarObjeto : MonoBehaviour
{
    public GameObject objetoParaAlterar;
    public void AlterarVisibilidad()
        {
            bool estadoAtual = objetoParaAlterar.activeSelf;
            objetoParaAlterar.SetActive(!estadoAtual);
        }
}
