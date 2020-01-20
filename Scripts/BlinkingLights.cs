using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkingLights : MonoBehaviour
{
    public float brightnessFactor = 1f;
    public GameObject anyObject;
    public Color hdrColor = Color.red;
    private bool emission;
    public GameObject ObjectWithSound;
    private AudioSource audioSource;
    public ParticleSystem effect;
    // Update is called once per frame

    void Start()
    {
        audioSource = ObjectWithSound.GetComponent<AudioSource>();
    }
    void Update()
    {
        var anyObjectRenderer = anyObject.GetComponent<Renderer>();
        if (audioSource.isPlaying)
        {

            effect.Play();
            emission = !emission;

            //anyObject.GetComponentInChildren<ParticleSystem>().Play();

            var timeDelay = Random.Range(0.0f, 1.0f);
            if (emission && timeDelay <= 0.2f)
            {
                hdrColor = hdrColor * brightnessFactor;
                anyObjectRenderer.material.EnableKeyword("_EMISSION");
                anyObjectRenderer.material.SetColor("_EmissionColor", hdrColor);

            }
            else
            {
                anyObjectRenderer.material.DisableKeyword("_EMISSION");
            }
        }
        else
        {
            anyObjectRenderer.material.DisableKeyword("_EMISSION");
        }


    }

}
