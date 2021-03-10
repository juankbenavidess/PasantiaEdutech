using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversational : MonoBehaviour
{
    public Conversation conversation;

    public void TriggerConversation()
    {
        Conversationmanager.Instance.StartConversation(conversation);
    }
}
