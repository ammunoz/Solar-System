using UnityEngine;
using System.Collections;

public class SwitchView : MonoBehaviour {

    int viewMode;
	// Use this for initialization
	void Start () {
        viewMode = 0;
	}

    public void switchView(){
        viewMode ^= 1;
        if (viewMode == 1)
        {
            this.gameObject.transform.Rotate(new Vector3(90, 0, 0));
            this.gameObject.transform.position = new Vector3(0, 3, 0);
        }
        else {
            this.gameObject.transform.rotation = new Quaternion(0, 0, 0, 1);
            this.gameObject.transform.position = new Vector3(0, 0, -3);
        }
    }
}
