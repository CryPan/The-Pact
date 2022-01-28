using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace VHS
{    
    public class NotesInteractable : InteractableBase
    {
        public Text textBox = null;
        public Text textOnNote = null;
        public string notetext;
        public GameObject Interact = null;
        public GameObject NoteColor = null;

        void Start()
        {
            textOnNote.text = "" + notetext;
            Interact.SetActive(true);
            NoteColor.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }
        public override void OnInteract()
        {
            base.OnInteract();
            textBox.text = "" + notetext;
            Interact.SetActive(false);
            NoteColor?.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }

        public void HideNote()
        {
            Interact.SetActive(true);
            NoteColor.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;


        }
    }
}
