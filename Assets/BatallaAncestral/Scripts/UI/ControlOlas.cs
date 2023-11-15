    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using MoreMountains.Tools;
    using TMPro;
    public class ControlOlas : MonoBehaviour, MMEventListener<MMGameEvent>
    {
        [SerializeField]
        private TMP_Text texto;
        void OnEnable()
        {
            this.MMEventStartListening<MMGameEvent>();
        }
        void OnDisable()
        {
            this.MMEventStopListening<MMGameEvent>();
        }

        public virtual void OnMMEvent(MMGameEvent e)
        {
        // here we start a coroutine that will display our achievement
            if(e.EventName == "Actualizar")
            {
                Oleadas temp = Oleadas.Instance;
                texto.text = "Ola"+temp.OlaActual+"/"+temp.CantidadOlas();

            }
        }
    }
