using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour
{
    public void Start() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex = 1);
    }
}
