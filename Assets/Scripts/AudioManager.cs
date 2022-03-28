using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManger : MonoBehaviour
{

    public static AudioManger instance;

    [SerializeField] AudioSource[] sounds;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More then once AudioManager");
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        sounds = GetComponentsInChildren<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound(string _name)
    {

        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].name == _name)
            {
                sounds[i].Play();
                return;
            }
        }

        Debug.LogWarning("AudioManager: Sound not found in list, " + _name);

    }

}

