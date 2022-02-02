using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

namespace VHS
{    
    public class NotesInteractable : InteractableBase
    {
        public Text textBox = null;
        public Text textOnNote = null;
        public string notetext;
        public GameObject Interact = null;
        public GameObject NoteColor = null;

        public PostProcessVolume volume;

        private DepthOfField _DepthOfField;
        float DepthOfFieldInts = 12f;

        void Start()
        {
            volume.profile.TryGetSettings(out _DepthOfField);

            _DepthOfField.aperture.value = DepthOfFieldInts;

            textOnNote.text = "" + notetext;
            Interact.SetActive(false);
            NoteColor.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

        }
        public override void OnInteract()
        {
            base.OnInteract();
            DepthOfFieldInts = 0.1f;

            volume.profile.TryGetSettings(out _DepthOfField);

            _DepthOfField.aperture.value = DepthOfFieldInts;

            textBox.text = "" + notetext;
            Interact.SetActive(true);
            NoteColor?.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }

        public void HideNote()
        {
            DepthOfFieldInts = 12f;

            volume.profile.TryGetSettings(out _DepthOfField);

            _DepthOfField.aperture.value = DepthOfFieldInts;

            Interact.SetActive(false);
            NoteColor.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;


        }
    }
}
