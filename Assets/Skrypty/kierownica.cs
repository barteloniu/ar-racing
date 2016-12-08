using UnityEngine;
using System.Collections;

public class kierownica : MonoBehaviour
{

    public float kierunek;
    public float gaz;

    Vector3 kalibracjaPos = new Vector3(0, -100, 0);
    float kalibracjaRot = 0.0f;
    GameObject target;

	void Start ()
    {
        target = GameObject.Find("ImageTarget");
    }
	
	void Update ()
    {
        if (Input.GetKeyDown("space") || Input.GetKeyDown("escape"))
        {
            Kalibracja();
        }

        if (target.transform.rotation.eulerAngles.y > 180.0f)
        {
            kierunek = kalibracjaRot - target.transform.rotation.eulerAngles.x;
        }
        else
        {
            kierunek = kalibracjaRot - (180 - target.transform.rotation.eulerAngles.x);
        }
        gaz = kalibracjaPos.z - target.transform.position.z;
    }
    
    public void Kalibracja ()
    {
        kalibracjaPos = target.transform.position;
        kalibracjaRot = target.transform.rotation.eulerAngles.x;
    }
}
