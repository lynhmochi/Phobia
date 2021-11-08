using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnTV : MonoBehaviour
{
    public MeshRenderer planeTV;
    public AudioSource audioSource;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
    }
    void OnMouseEnter() {
        planeTV.enabled = true;
        audioSource.Play();
    }

    void OnMouseExit() {
        planeTV.enabled = false;    
        audioSource.Stop();
    }
}
