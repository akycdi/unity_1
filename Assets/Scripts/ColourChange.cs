using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColourChange : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    private GameObject _cube; 
    [SerializeField] 
    private GameObject _sphere; 
    [SerializeField] 
    private GameObject _cylinder; 
 
 
    private Renderer cubeRenderer; 
    private Renderer sphereRenderer; 
    private Renderer cylinderRenderer; 
 
     [SerializeField] 
    private Toggle myobject1  , myobject2 , myobject3; 
        
 
    // Start is called before the first frame update 
    void Start() 
    { 
        cubeRenderer = _cube.GetComponent<Renderer>(); 
        sphereRenderer = _sphere.GetComponent<Renderer>(); 
        cylinderRenderer = _cylinder.GetComponent<Renderer>(); 
    }

   public void SetCubeColor() 
    { 
        if (myobject1.isOn) 
        { 
            cubeRenderer.sharedMaterial.SetColor("_Color", Color.black); 
        } 
        else 
        { 
            cubeRenderer.sharedMaterial.SetColor("_Color", Color.blue); 
        } 
    } 
 
    public void SetCylinderColor() 
    { 
        if (myobject2.isOn) 
        { 
            cylinderRenderer.sharedMaterial.SetColor("_Color", Color.black); 
        } 
        else 
        { 
            cylinderRenderer.sharedMaterial.SetColor("_Color", Color.red); 
        } 
    } 
 
    public void SetSphereColor() 
    { 
        if (myobject3.isOn) 
        { 
            sphereRenderer.sharedMaterial.SetColor("_Color", Color.black); 
        } 
        else 
        { 
            sphereRenderer.sharedMaterial.SetColor("_Color", Color.green); 
        } 
        
 
    }
}
