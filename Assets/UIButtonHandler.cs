using UnityEngine;

public class UIButtonHandler : MonoBehaviour
{
    public PlacementManager placementManager;

    public void OnPlaceTower()
    {
        placementManager.enabled = true; // Enable placement mode
    }
}
