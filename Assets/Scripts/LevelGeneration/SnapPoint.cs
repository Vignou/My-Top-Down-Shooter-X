using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SnapPointType { Enter, Exit}
public class SnapPoint : MonoBehaviour
{
    public SnapPointType pointType;

    private void Start()
    {
        //GetComponent<BoxCollider>().enabled = false;  //Turn Off to avoid error of SnapPoint missing collider
        GetComponent<MeshRenderer>().enabled = false;
    }

    private void OnValidate()
    {
        gameObject.name = "SnapPoint - " + pointType.ToString();
    }
}
