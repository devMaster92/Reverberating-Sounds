using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimGlow : MonoBehaviour
{
    // Interpolate light color between two colors back and forth
    public float duration = 1.0f;
    public Color color0 = Color.red;
    public Color color1 = Color.blue;

    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
    }

    void Update()
    {
        // set light color
        float t = Mathf.PingPong(Time.time, duration) / duration;
        lt.color = Color.Lerp(color0, color1, t);
    }
}
