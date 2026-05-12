using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Menu : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void StartGame()
    {
       SceneManager.LoadScene("Main");
    }
    public void ExitGame()
    {
        Application.Quit();
    }

}
