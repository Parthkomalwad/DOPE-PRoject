using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    public void LoadNextPage()
    {
        SceneManager.LoadScene(1);
       
    }
    public void Quit()
    {
        Quit();
       
    }

}
