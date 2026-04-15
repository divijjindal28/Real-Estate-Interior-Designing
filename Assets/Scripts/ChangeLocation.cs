using UnityEngine;

public class ChangeLocation : MonoBehaviour
{
    public Transform player; // Player or XR Rig

    public void ChangeLocationFUNC(Transform targetLocation)
    {
        if (player == null || targetLocation == null)
        {
            Debug.LogWarning("Player or Target Location is missing");
            return;
        }

        player.position = new Vector3(targetLocation.position.x, player.position.y, targetLocation.position.z);
        player.rotation = targetLocation.rotation;
    }
}
