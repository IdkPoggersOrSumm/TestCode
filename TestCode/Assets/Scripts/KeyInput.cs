using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.Space);
        bool held = Input.GetKey(KeyCode.Space);
        bool up = Input.GetKeyUp(KeyCode.Space);

        if(down)
        {
            Debug.Log("Space is down: " + down);
        }
        else if(held)
        {
            Debug.Log("Space is held " + held);
        }
        else if(up)
        {
            Debug.Log("Space is up " + up);
        }

        Debug.Log("Space is Down:" + down);
        Debug.Log("Space is held:" + held);
        Debug.Log("Space is up:" + down);

    }
}
