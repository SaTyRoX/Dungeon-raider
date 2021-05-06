using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnDeath : MonoBehaviour
{

public int NextScene;
    void OnDestroy()
    {
        SceneManager.LoadScene(NextScene);
    }

}
