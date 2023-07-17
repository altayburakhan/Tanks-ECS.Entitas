using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private void Start()
    {
        var contexts = new Contexts();
        var entity = contexts.game.CreateEntity();
        
        entity.AddHealth(100);
    }
}
