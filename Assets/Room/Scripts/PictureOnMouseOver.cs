using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureOnMouseOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject vid;

    void Start()
    {
        var videoPlayer = gameObject.GetComponent<UnityEngine.Video.VideoPlayer>();
        var audioSource = gameObject.AddComponent<AudioSource>();

        videoPlayer.playOnAwake = false;
        videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.RenderTexture;
        videoPlayer.targetMaterialRenderer = GetComponent<Renderer>();
        videoPlayer.targetMaterialProperty = "_MainTex";
        videoPlayer.audioOutputMode = UnityEngine.Video.VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, audioSource);
    }

    // Update is called once per frame
    private void OnMouseOver() {
        var vp = vid.GetComponent<UnityEngine.Video.VideoPlayer>();
        Debug.Log("Mouse is over GameObject.");
        if (!vp.isPlaying){
            vp.Play();
        }
    }

    private void OnMouseExit() {
        var vp = vid.GetComponent<UnityEngine.Video.VideoPlayer>();
        Debug.Log("Mouse is over GameObject.");
        if (vp.isPlaying){
            vp.Pause();
        }
    }
}
