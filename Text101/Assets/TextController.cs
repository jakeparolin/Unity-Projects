using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
    //Creates variable text with type Text
    public Text text;

    //enum = set of named integral constants that may be assigned to a variable.
    private enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom };
    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
        print("state: " + myState);
        if (myState == States.cell) {
            state_cell();
        } else if (myState == States.sheets_0) {
            state_sheets_0();
        }
	}

    void state_cell() {
        text.text = "You are in a prison cell, and you want to escape. There " +
                    "are some dirty sheets on the bed, a mirror on the wall, " +
                    "and the door is locked from the outside.\n\n" +
                    "Press: \n S to view Sheets \n M to view Mirror \n L to view Lock";
        if (Input.GetKeyDown(KeyCode.S)) {
            myState = States.sheets_0;
        }
    }

    void state_sheets_0() {
        text.text = "You can't believe you sleep in these things. Surely it's " +
                    "time somebody changed them. The pleasures of prison life " +
                    "I guess! \n\n" +
                    "Press: \n R to return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R)) {
            myState = States.cell;
        }
    }
}

