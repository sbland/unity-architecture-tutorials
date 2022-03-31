using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingOptionManager : MonoBehaviour
{
    public ClickableBuilding[] buildingOptions;
    public int currentSelection = 0;
    public Camera mainCamera;
    private RaycastHit raycastHit;
    // // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < buildingOptions.Length; i++)
        {
            ClickableBuilding buildOpt = buildingOptions[i];
            // Renderer r = buildOpt.gameObject.GetComponent(typeof(Renderer)) as Renderer;
            if (i == currentSelection)
            {
                // r.enabled = true;
                buildOpt.gameObject.SetActive(true);
            }
            else
            {
                // r.enabled = false;
                buildOpt.gameObject.SetActive(false);
            }
        }
    }

    // // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Have we clicked an object
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out raycastHit))
            {
                // Debug.Log("You clicked something");

                if (raycastHit.collider.gameObject.name == "Button")
                {
                    Debug.Log("You clicked the button");
                    if (currentSelection < buildingOptions.Length - 1)
                    {
                        currentSelection += 1;

                    } else {
                        currentSelection = 0;
                    }
                }

            }
        }

        for (int i = 0; i < buildingOptions.Length; i++)
        {
            ClickableBuilding buildOpt = buildingOptions[i];
            // Renderer r = buildOpt.gameObject.GetComponent(typeof(Renderer)) as Renderer;
            if (i == currentSelection)
            {
                // r.enabled = true;
                buildOpt.gameObject.SetActive(true);
            }
            else
            {
                // r.enabled = false;
                buildOpt.gameObject.SetActive(false);
            }
        }
        // Check if mouse button is clicked

    }
}
