using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{
    public AudioSource thing_to_play;

    void event_audio_1 ()
        {
          thing_to_play.Play();
        }
}
