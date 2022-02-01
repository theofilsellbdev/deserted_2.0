using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public enum InteractionType
    {
        Click,
        Hold,
        Minigame,
        
    }

    public InteractionType interactiontype;
    public abstract string GetDescription();
    public abstract void Interact();
    
}
