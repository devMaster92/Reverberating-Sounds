using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{
    public GameObject BackgroundLight;
    public GameObject pointLight1;
    public GameObject pointLight2;
    public GameObject pointLight3;
    public GameObject pointLight4;
    public GameObject pointLight5;
    public GameObject pointLight6;
    private bool on = false;
    public GameObject button;

    
    private void OnTriggerStay(Collider other)
    {
        var buttonRenderer = button.GetComponent<Renderer>();
        if (other.tag == "Player" && Input.GetButtonDown("Use"))
        {
            on = !on;
            if (buttonRenderer.material.GetColor("_Color") == Color.green)
            {
                buttonRenderer.material.SetColor("_Color", Color.red);
            }
            else {
                buttonRenderer.material.SetColor("_Color", Color.green);
            }
            
            BackgroundLight.SetActive(on);
            pointLight1.SetActive(on);
            pointLight2.SetActive(on);
            pointLight3.SetActive(on);
            pointLight4.SetActive(on);
            pointLight5.SetActive(on);
            pointLight6.SetActive(on);

        }
    }
}
