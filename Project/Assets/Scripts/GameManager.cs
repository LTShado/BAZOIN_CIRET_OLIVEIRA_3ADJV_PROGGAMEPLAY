using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _singleton;

    private static GameManager Instance()
    {
        return _singleton;
    }

    private List<IUpdater> UpdateList = new List<IUpdater>();

    private void Awake()
    {
        _singleton = this;
        new TAccessor<MovementModule>();
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateList.Add(new MovementSystem());
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var up in UpdateList)
        {
            up.SystemUpdate();
        }
    }
}
