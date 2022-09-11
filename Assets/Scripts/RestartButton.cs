using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void ResetScene()
    {
        SceneManager.LoadScene("Scene1");
        //SceneManager.LoadScene("Ganaste");
    }

}