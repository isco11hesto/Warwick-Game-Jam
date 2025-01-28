using UnityEngine;

public class PlacementManager : MonoBehaviour
{
    public GameObject towerPrefab; // Reference to the Tower prefab
    private GameObject currentTower; // Currently dragged tower

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // On left-click, start placing a tower
        {
            if (currentTower == null) // If no tower is currently being dragged
            {
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = 0; // Ensure Z position is zero for 2D
                currentTower = Instantiate(towerPrefab, mousePosition, Quaternion.identity);
            }
        }

        if (Input.GetMouseButton(0) && currentTower != null) // While holding left-click
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0; // Ensure Z position is zero for 2D
            currentTower.transform.position = mousePosition; // Drag the tower
        }

        if (Input.GetMouseButtonUp(0) && currentTower != null) // On releasing left-click
        {
            currentTower.GetComponent<SpriteRenderer>().color = Color.white; // Reset color
            currentTower = null; // Placement complete
        }
    }
}
