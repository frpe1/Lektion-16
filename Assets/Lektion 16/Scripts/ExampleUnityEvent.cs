using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExampleUnityEvent : MonoBehaviour
{
    // Definiera händelsen här, här är också de som vi subscribar till som ska ta emot händelsen
    [SerializeField] 
    private UnityEvent onItemCollected;

    // Denna publika metod är den som triggar händelsen. 
    public void GrabObject()
    {
        // Triggar händelsen, skickar ut signal till de som lyssnar
        // Denna del startar igång och skickar en impuls till alla andra objekt som är subscribed till 
        // variabeln onItemCollected;
        onItemCollected.Invoke();
    }

}
