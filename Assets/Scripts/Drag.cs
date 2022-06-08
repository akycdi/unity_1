using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour

{
    private Vector3 screenPoint;
    private Vector3 offset;
    private Rigidbody rB;
    
    private void Start() {
        
    }
    void OnMouseDown()
    {
        
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }
    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = Vector3.Lerp(transform.position, curPosition,.5f);
    }

    private void OnCollisionEnter(Collision other) {
        rB = GetComponent<Rigidbody>();
        Debug.Log("Collision detected" + rB.velocity);
        other.gameObject.GetComponent<Rigidbody>().AddForce(rB.velocity*25f);
    }
   
}

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Drag : MonoBehaviour

// {
//     private Vector3 mOffset;
//     private float mZCoord;
//     void OnMouseDown()

//     {

//         mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

//         // Store offset = gameobject world pos - mouse world pos

//         mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

//     }
//     private Vector3 GetMouseAsWorldPoint()

//     {

//         // Pixel coordinates of mouse (x,y)

//         Vector3 mousePoint = Input.mousePosition;

//         // z coordinate of game object on screen

//         mousePoint.z = mZCoord;

//         // Convert it to world points

//         return Camera.main.ScreenToWorldPoint(mousePoint);

//     }
//     void OnMouseDrag()
//     {

//         transform.position = GetMouseAsWorldPoint() + mOffset;

//     }
// //     private void OnTriggerEnter(Collider other) {
// //          if(other.gameObject.CompareTag("Cube")){
// //             other.gameObject.SetActive(false);
// //          }

// // }
// }