using System.Collections;
using System.Runtime.InteropServices;
using  UnityEngine;
using  TMPro;
    public class ToggleAudio :MonoBehaviour
    {
        [SerializeField] private bool _ToggleMusic, _ToggleEffect;
        [SerializeField] private TextMeshProUGUI Text;


        public void Toggle()
        {
            if(_ToggleEffect) SoundManeger.Instance.ToggleEffect();
            if(_ToggleMusic) 
            {
                Text.text = "ON";
                SoundManeger.Instance.ToggleAudio();
            }
            
        }
    }
