using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Door : MonoBehaviour
{
    //public variables editable in uniy
    public string targetScene = "";

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }
     public void ChangeToScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}
