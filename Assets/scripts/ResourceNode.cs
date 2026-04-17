using UnityEngine;

public class ResourceNode : MonoBehaviour
{
    public enum ResourceType
    {
        Wood,
        Stone
    }

    public ResourceType resourceType;
    public int amount = 5;

    public void Harvest(PlayerInventory inventory)
    {
        if (resourceType == ResourceType.Wood)
        {
            inventory.AddWood(amount);
            Debug.Log("Odun topladin: " + amount);
        }
        else if (resourceType == ResourceType.Stone)
        {
            inventory.AddStone(amount);
            Debug.Log("Tas topladin: " + amount);
        }

        Destroy(gameObject);
    }
}