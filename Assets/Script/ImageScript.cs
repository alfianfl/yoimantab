using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
      [SerializeField] private RawImage customImage;

    public void OnTriggerEnter(Collider other) {
        customImage.enabled = true;
           Cursor.lockState = CursorLockMode.Locked;
           Cursor.visible = false;
    }
}
