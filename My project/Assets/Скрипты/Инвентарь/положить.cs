using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class положить : MonoBehaviour
{
    private инвентарь инвентарь;
    public GameObject slotButton;

    private void Start()
    {
        инвентарь = GameObject.FindGameObjectWithTag("Player").GetComponent<инвентарь>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < инвентарь.slots.Length; i++)
            {
                if (инвентарь.isFull[i] ==  false)
                {
                    инвентарь.isFull[i] = true;
                    Instantiate(slotButton, инвентарь.slots[i].transform);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
