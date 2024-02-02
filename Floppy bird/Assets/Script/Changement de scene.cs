using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changementdescene : MonoBehaviour
{
    public string Scenename;
    
    public void ChangeScene()
    {
        SceneManager.LoadScene(Scenename);
    }
}
