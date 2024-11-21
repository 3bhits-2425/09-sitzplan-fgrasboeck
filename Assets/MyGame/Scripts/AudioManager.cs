using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Instanzvariablen 
    [SerializeField]

    private Sound[] sounds;

    // speichern einer Referenz zum Singleton
    private AudioManager singleton;

    // stelle sicher, dass nur ein Element vom Typ AudioManager 
    // erzeugt werden kann
   
   
void Awake()
    { 
        if(singleton == null)
        {
            // noch kein AudioManager vorhanden
            // -> erzeuge einen
            singleton = this;
            //speicher die aktuelle Inzanz im Singleton
        }
        else
        {
            // es existiert bereits ein AudioManager
            // -> erzeuge keinen neuen
            // -> zerstoere aktuelles Objekt
            Destroy(gameObject);
            return;
        }

        // Singleton soll nicht zerstoert werden
        DontDestroyOnLoad(gameObject);

        foreach (Sound oneSound in sounds)
        {
           
            oneSound.audioSource = gameObject.AddComponent<AudioSource>();
            oneSound.audioSource.clip = oneSound.clip;
            oneSound.audioSource.volume = oneSound.volume;
            oneSound.audioSource.pitch = oneSound.pitch;

          
            /*
             * for (int i = 0; i < sounds.Length; i++){
             * Sound s = sounds[i];
             *......
             *identisch wie in forech
            */
        }

    }

    // Spielt soud ab   
    public void Play(string soundName)
    {
        FindSound(soundName).audioSource.Play();

    }

    public void Pause(string soundName)
    {
        /*
        FindSound(soundName).audioSource.Pause();
        kurz-Schreibweise fehlerhaft
     */
          
        Sound mySound = FindSound(soundName);
        if(mySound == null)
        {
            Debug.Log("Sound " + soundName+ "nicht gefunden");
            return;

        }
        
    }

    private Sound FindSound(string soundName)
    {
        foreach(Sound oneSound in sounds) {
            if (oneSound.name == soundName)
            {
                return oneSound;
            }
        }
        Debug.Log("Sound wurde nicht gefunden");
        return null;
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
