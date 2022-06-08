using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCreation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject square;

    [SerializeField]
    private GameObject Cube;

    [SerializeField]
    private GameObject capsule;
     [SerializeField]
    private GameObject toggle1, toggle2, toggle3;

    // public GameObject StaticCube;
    public void callsquare()
    {
        float x;
        float y;
        float z;
        Vector3 pos;
        x = Random.Range(15 , 735);
        y = Random.Range(19, 300);
        z = 0;
        pos = new Vector3(x, y, z);
        Instantiate(square
, pos, Quaternion.identity);
    toggle1.SetActive(true);
    }
    public void callCube()
    {
        float x;
        float y;
        float z;
        Vector3 pos;
        x = Random.Range(15 , 735);
        y = Random.Range(19, 300);
        z = 0;
        pos = new Vector3(x, y, z);
        Instantiate(Cube, pos, Quaternion.identity);
        // StaticCube.SetActive(true);
    toggle2.SetActive(true);


    }
    public void callCapsule()
    {
        float x;
        float y;
        float z;
        Vector3 pos;
        x = Random.Range(15 , 735);
        y = Random.Range(19, 300);
        z = 0;
        pos = new Vector3(x, y, z);
        Instantiate(capsule, pos, Quaternion.identity);
        toggle3.SetActive(true);

    }
}