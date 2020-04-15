using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToStart : MonoBehaviour
{
    public void ReturnToStartButton(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
    }
}
