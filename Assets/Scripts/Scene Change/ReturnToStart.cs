using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToStart : MonoBehaviour
{
    public void ReturnToStartButtonFromFinalScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
    public void ReturnToStartButtonFromFinalScene2(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
    }
}
