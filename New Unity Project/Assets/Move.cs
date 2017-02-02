using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float HorizontalSpeed = .2f;
    public float verticalSpeed = .2f;


        // Update is called once per frame
        void Update () {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.Translate(-HorizontalSpeed, 0, 0);
            }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Translate(HorizontalSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Translate(0, verticalSpeed, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Translate(0, -verticalSpeed, 0);
        }
    }
    }



