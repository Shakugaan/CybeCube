using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToSelect : MonoBehaviour {
    public void ChangeLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void AbortMision()
    {
        Application.Quit();
    }
}
