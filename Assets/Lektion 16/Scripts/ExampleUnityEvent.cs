using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExampleUnityEvent : MonoBehaviour
{
    // Definiera h�ndelsen h�r, h�r �r ocks� de som vi subscribar till som ska ta emot h�ndelsen
    [SerializeField] 
    private UnityEvent onItemCollected;

    // Denna publika metod �r den som triggar h�ndelsen. 
    public void GrabObject()
    {
        // Triggar h�ndelsen, skickar ut signal till de som lyssnar
        // Denna del startar ig�ng och skickar en impuls till alla andra objekt som �r subscribed till 
        // variabeln onItemCollected;
        onItemCollected.Invoke();
    }

}
