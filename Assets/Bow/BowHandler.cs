using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BowHandler : MonoBehaviour{
    // Start is called before the first frame update

    [SerializeField]
    private Camera camera;

    [SerializeField]
    private Rigidbody2D arrowRB;

    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        if (Input.touchCount>0) {
            Vector3 touchPosition = Input.GetTouch(0).position;
            touchPosition=camera.ScreenToWorldPoint(touchPosition);
            arrowRB.position = touchPosition;
            arrowRB.isKinematic = true;
        }else {
            arrowRB.isKinematic = false;
        }
        
    }
}
