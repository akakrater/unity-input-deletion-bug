using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int wood = 0;
    public int stone = 0;

    public void AddWood(int amount)
    {
        wood += amount;
        Debug.Log("Odun topladin: " + wood);
    }

    public void AddStone(int amount)
    {
        stone += amount;
        Debug.Log("Tas topladin: " + stone);
    }
}