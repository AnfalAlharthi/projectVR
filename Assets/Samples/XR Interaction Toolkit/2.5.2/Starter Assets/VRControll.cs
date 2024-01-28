using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class VRControll : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource ab;
    private XRController XRController;


    void Start()
    {

        XRController = GetComponent<XRController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (XRController.inputDevice.TryGetFeatureValue(CommonUsages.triggerButton, out bool selectButtonVlaue) && selectButtonVlaue)
        {
            Debug.Log("Select Button Pressed");
            ab.Play();
        }
    }
}
