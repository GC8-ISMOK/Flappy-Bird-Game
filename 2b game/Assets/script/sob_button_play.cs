using UnityEngine;
using UnityEngine.SceneManagement;

public class sob_button_play : MonoBehaviour
{
    public void select_play()
    {       
        SceneManager.LoadScene(1);  
    }

    public void select_exit()
    {
        Application.Quit();
    }

}
