using System.Collections;
using System.Collections.Generic;
using Valve.VR.InteractionSystem;
using UnityEngine;

public class VrLightSwitch : MonoBehaviour
{
    public HoverButton hoverButton;
    public Light lightObject;


    private void OnButtonDown(Hand hand) {
        lightObject.gameObject.SetActive(!lightObject.gameObject.activeSelf);
    }
}
