using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScenes(int sceneChange)
    {
        SceneManager.LoadScene(sceneChange);
    }
}
