using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControler : MonoBehaviour
{
    float rotSpeed = 0;
    bool flg_stop = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 1;
        }
        else if (Input.GetMouseButton(0))
        {
            if (this.rotSpeed<30)
                this.rotSpeed += 5;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            flg_stop = true;
        }
        transform.Rotate(0, 0, this.rotSpeed);

        // 減衰係数0.96
        if (flg_stop)
            this.rotSpeed *= 0.96f;
        
    }
}
