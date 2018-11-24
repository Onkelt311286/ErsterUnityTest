using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionController : MonoBehaviour{

    private void OnMouseUpAsButton()
    {
        Debug.Log("Selected: " + gameObject.name);
    }
}
