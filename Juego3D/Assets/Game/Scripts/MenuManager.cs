using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void NuevaPartida()
    {
        SceneManager.LoadScene("Playa"); 
    }

    public void CargarPartida()
    {
        // Por ahora solo un mensaje, lo implementas después con JSON
        Debug.Log("Cargar partida - pendiente de implementar");
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego"); 
    }
}