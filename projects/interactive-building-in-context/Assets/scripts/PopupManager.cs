using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public float heightAboveGround;
    public TextMesh[] textObjects;

    public void moveToLocation(Transform target) {
        Debug.Log($"Moving popup to {target.position}");
        transform.position = new Vector3(target.position.x, heightAboveGround, target.position.z);
    }

    public void setText(string[] textLines) {
        for (int i = 0; i< textObjects.Length; i++) {
            if (i < textLines.Length) {
                TextMesh textObject = textObjects[i];
                textObject.text = textLines[i];
            }
        }
    }
}
