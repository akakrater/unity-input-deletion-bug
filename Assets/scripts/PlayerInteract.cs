using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public float interactDistance = 6f;
    public Camera cam;

    private PlayerInventory inventory;

    void Start()
    {
        inventory = GetComponent<PlayerInventory>();

        if (cam == null)
            cam = GetComponentInChildren<Camera>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (cam == null || inventory == null)
                return;

            Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

            if (Physics.Raycast(ray, out RaycastHit hit, interactDistance))
            {
                ResourceNode node = hit.collider.GetComponent<ResourceNode>();

                if (node != null)
                {
                    node.Harvest(inventory);
                }
            }
        }
    }
}