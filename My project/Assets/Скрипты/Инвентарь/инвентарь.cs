using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class инвентарь : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject Рюкзак;
    private bool РюкзакOn;

    private void Start()
    {
        РюкзакOn = false;
    }
    public void Chest()
    {
        if(РюкзакOn == false)
        {
            РюкзакOn = true;
            Рюкзак.SetActive(true);
        }
        else if (РюкзакOn == true)
        {
            РюкзакOn = false;
            Рюкзак.SetActive(false);
        }
    }
}
