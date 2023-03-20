using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScheneChange : MonoBehaviour
{

    public void ChangeToScene(string TargetSceneName)
    {
        SceneManager.LoadScene(TargetSceneName);
    }
}

