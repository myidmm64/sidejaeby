using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector2 MaxPosition { get; private set; }
    public Vector2 MinPosition { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        MaxPosition = new Vector2(3.6f, 1.7f);
        MinPosition = new Vector2(-3.6f, -1.7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
