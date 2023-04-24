using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{ //
    public GameObject gameOverPannel;
    
   
    // Update is called once per frame
    void Update()
    {
        if ( GameObject.FindGameObjectWithTag("Player")== null)
        {
            gameOverPannel.SetActive(true);
           
        }
       
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
