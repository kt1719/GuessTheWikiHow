using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class Timer : MonoBehaviour
    {
        Text text;

        public float timervalue = 30f;
        // Start is called before the first frame update
        void Start()
        {
            text = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            timervalue = (timervalue > 0) ? timervalue - Time.deltaTime : 0;
            text.text = timervalue.ToString("F2");
        }
    }
}