using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public TextMeshProUGUI woodText;
    public TextMeshProUGUI stoneText;

    void Update()
    {
        woodText.text = "Odun: " + playerInventory.wood;
        stoneText.text = "Taş: " + playerInventory.stone;
    }
}