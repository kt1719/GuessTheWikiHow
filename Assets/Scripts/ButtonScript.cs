using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI {
    public class ButtonScript : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] Timer timerscript;
        [SerializeField] ImageScript imgscript;
        
        public void ButtonPress()
        {
            ResetTimer();
            GenerateNewImage();
        }

        private void ResetTimer()
        {
            timerscript.timervalue = 30f;
        }

        private void GenerateNewImage()
        {
            imgscript.GenerateImage();
        }
    }
}