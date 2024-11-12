using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGuy : MonoBehaviour
{
    public Transform molecule;
    public Transform label;

    private LineRenderer fella;

    // Start is called before the first frame update
    void Start()
    {
        fella = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        fella.SetPosition(0, molecule.position);
        fella.SetPosition(1, label.position);
    }
}
