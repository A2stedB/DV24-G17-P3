using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class EndGame : MonoBehaviour
{
    [SerializeField]
    VideoPlayer player;

    public void PlayVideo()
    {
        player.Play();
        player.loopPointReached += OnVideoEnded;
    }

    public void OnVideoEnded(VideoPlayer vp)
    {
        SceneManager.LoadScene(0);
    }
}
