using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class собирание : MonoBehaviour
{
    private инвентарь инвентарь;
    public int i;

    private void Start()
    {
        инвентарь = GameObject.FindGameObjectWithTag("Player").GetComponent<инвентарь>();
    }
    private void Update()
    {
        if (transform.childCount <= 0)
        {
            инвентарь.isFull[i] = false;
        }
    }
    public void DropItem()
    {
        foreach(Transform child in transform)
        {
            child.GetComponent<убрать>().SpawnDropperItem();
            GameObject.Destroy(child.gameObject);
        }
    }
}
