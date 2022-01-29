using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


namespace VHS
{    
    public class sheffsInteractable : InteractableBase
    {
        bool OpenSheff = true;
        public PlayableDirector In;
        public PlayableDirector Out;

        public override void OnInteract()
        {
            base.OnInteract();

            if(OpenSheff == true)
            {
                Out.Play();
                OpenSheff = false;
            }
            else
            {
                In.Play();
                OpenSheff = true;
            }
        }
    }
}
