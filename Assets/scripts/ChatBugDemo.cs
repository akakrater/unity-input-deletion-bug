using UnityEngine;
using TMPro;

public class ChatBugDemo : MonoBehaviour
{
    public TMP_InputField chatInput;
    public TMP_Text messageOutput;

    public void SendMessage()
    {
        if (string.IsNullOrWhiteSpace(chatInput.text))
            return;

        messageOutput.text = "Sent: " + chatInput.text;

        // BUG: temizlemiyoruz (bilerek)
    }
}