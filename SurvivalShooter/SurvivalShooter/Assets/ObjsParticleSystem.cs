using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjsParticleSystem : MonoBehaviour
{
    
    void Play(ParticleSystem part)
    {
        part = GetComponent<ParticleSystem>();
        part.Play();

    }
        
    
}
