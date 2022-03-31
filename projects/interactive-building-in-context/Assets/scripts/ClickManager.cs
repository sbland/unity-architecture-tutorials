using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public Camera mainCamera;
    private RaycastHit raycastHit;

    // Start is called before the first frame update
    void Start()
    {

    }

    ClickableBuilding getClickedOnBuilding()
    {
        // Have we clicked an object
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out raycastHit))
        {
            // Debug.Log("You clicked something");

            if (raycastHit.collider.gameObject.name == "Building")
            {
                Debug.Log("You clicked the building");
            }

            ClickableBuilding building = raycastHit.transform.gameObject.GetComponent(typeof(ClickableBuilding)) as ClickableBuilding;

            if (building != null)
            {
                Debug.Log($"You clicked a clickable building called {building.name} with age {building.age}");
                return building;
            }
        }
        return null;
    }

    void updatePopup(ClickableBuilding building) {
        Debug.Log("Updating Popup");
        PopupManager popup = FindObjectOfType<PopupManager>();
        popup.moveToLocation(building.transform);
        popup.setText(new string[] {
            $"Name: {building.name}",
            $"Age: {building.age}",
        });
    }

    // Update is called once per frame
    void Update()
    {
        // Check if mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            ClickableBuilding building = getClickedOnBuilding();

            if (building != null)
            {
                // Do something
                updatePopup(building);
            }
        }
    }
}
