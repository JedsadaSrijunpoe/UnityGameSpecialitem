using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

public class Item : NetworkBehaviour
{
    public UnityEvent OnItemPickUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(collision.gameObject.name);
            Destroy(gameObject);
            if (IsServer)
            {
                OnItemPickUp?.Invoke();
            }
        }
    }
}
