using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensch : MonoBehaviour

{
   
    // Instanzvariablen
    public string personName;
    public string rolleInKlasse;
    public Color augenfarbe;

    [SerializeField] 
    private AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start()
    {
      
        Debug.Log("Hallo, ich bin " + personName + " und ich bin " + rolleInKlasse + " in der Klasse.");
       
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {       // Sobald die Leertaste gedrückt wird
        if (Input.GetKeyDown(KeyCode.Space))
        {    
            Debug.Log("Leertaste gedrueckt!");
            // Starte die Audiowiedergabe
            myAudioSource.Play();
        }else if (Input.GetKeyUp(KeyCode.Space))
        {
            // Stoppe die Audiowiedergabe
            myAudioSource.Stop();
            
        }
    }
}
