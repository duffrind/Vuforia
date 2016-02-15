//using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using Vuforia;
 
public class VirtualButtonEvent : MonoBehaviour, IVirtualButtonEventHandler {
 
  private GameObject Cube;
  
  // register buttons for event handling
  void Start() {
    VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
    for (int i = 0; i < vbs.Length; ++i) { vbs[i].RegisterEventHandler(this); }
    Cube = transform.FindChild("Cube").gameObject;
  }
  
  // button is "pressed" so change color of Cube
  public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) {
    if (vb.VirtualButtonName=="Red")  { Cube.GetComponent<Renderer>().material.color = Color.red; }
    if (vb.VirtualButtonName=="Blue") { Cube.GetComponent<Renderer>().material.color = Color.blue; }
  }
  
  // change Cube back to white
  public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
    if (vb.VirtualButtonName=="Red")  { Cube.GetComponent<Renderer>().material.color = Color.black; }
    if (vb.VirtualButtonName=="Blue") { Cube.GetComponent<Renderer>().material.color = Color.black; }
  }
 
}