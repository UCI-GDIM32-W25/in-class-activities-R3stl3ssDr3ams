using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance { get; private set; }
    public W4Pigeon Pidgeon { get; private set; }
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        GameObject pidgeon = GameObject.FindWithTag("Pidgeon");
        Pidgeon = pidgeon.GetComponent<W4Pigeon>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
