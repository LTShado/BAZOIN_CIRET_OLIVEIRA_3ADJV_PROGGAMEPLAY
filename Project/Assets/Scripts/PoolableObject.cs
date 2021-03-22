using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolableObject : MonoBehaviour
{
    public bool Active()
    {
        return gameObject.activeSelf;
    }
    public void Pull()
    {
        gameObject.SetActive(true);
    }

    public void Release()
    {
        gameObject.SetActive(false);
    }
}
