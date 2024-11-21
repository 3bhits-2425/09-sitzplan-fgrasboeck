using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioMenue : MonoBehaviour
{

    private GameObject PlayPauseButton;
    private TMP_Text PlayPauseButtonText;
    private AudioSource myAudioSource;
    // Start is called before the first frame update
    void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();
        // finde das PlayPauseButton
        PlayPauseButton = GameObject.Find("PlayPauseButton");
        // finde den Text des PlayPauseButton
        PlayPauseButtonText = PlayPauseButton.GetComponentInChildren<TMP_Text>();
        PlayPauseButtonText.text = "Play";
    }

    // Update is called once per frame

    public void PlayAudio()
    {
        // Starte die Audiowiedergabe
       // myAudioSource.Play();
       FindAnyObjectByType<AudioManager>().Play("09-mySound-fgrasboeck");
        /*
         * langform des obigen Aufrufs
         * AudioManager myAudioManager = FindAnyObjectByType<AudioManager>();
         * myAudioManager.Play("09-mySound-fgrasboeck");
         * 
         *
         */
    }

    public void StopAudio()
    {
        // Stoppe die Audiowiedergabe
        myAudioSource.Stop();
    }
    public void PauseAudio()
    {
        // Pausiere die Audiowiedergabe
        //myAudioSource.Pause();
        FindAnyObjectByType<AudioManager>().Pause("09-mySound-fgrasboeck");
    }
    public void PlayPauseAudio()
    {
        // Pausiere die Audiowiedergabe
        if (myAudioSource.isPlaying)
        {
            myAudioSource.Pause();

        }
        else
        {
            myAudioSource.Play();

        }
    }
        
    public void Update()
        {
            // Ändere den Button Text
            // abhängig von Zustand der Audiosource
            if (myAudioSource.isPlaying)
            {
                PlayPauseButtonText.SetText("Pause");
            }
            else
            {
                PlayPauseButtonText.SetText("Play");
            }
        }
    

    }
