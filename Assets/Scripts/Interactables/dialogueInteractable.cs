using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace VHS
{    
    public class dialogueInteractable : InteractableBase
    {
        bool OpenSheff = true;
        public string A1;
        public string B1;
        public string B2;
        public string C1;
        public string C2;
        public string C3;
        public string C4;
        public string D1;
        public string D2;
        public string D3;
        public string D4;
        public Text AItextBox = null;
        public Text Option1 = null;
        public Text Option2 = null;
        public Text Option3 = null;
        public GameObject diaglogueUI = null;

        void Start()
        {
            diaglogueUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            
        }

        public override void OnInteract()
        {
            base.OnInteract();
            diaglogueUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;


        }

        public void LeavetheTalk()
        {
            diaglogueUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
