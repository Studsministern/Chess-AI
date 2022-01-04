using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessPiece : MonoBehaviour
{
    // Handle values [0, ..., 7] for each
    public int PosX { get; private set; }
    public int PosY { get; private set; }
    // Correct this so it is safe
    public bool IsMoveable
    {
        // Assign get and set in a correct way
        get
        {
            return false;
        }

        set
        {
            _IsMoveable = IsMoveable;
        }
    }
    private bool _IsMoveable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
