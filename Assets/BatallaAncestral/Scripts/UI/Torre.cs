using System;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using UnityEngine;
using TMPro;
public class Torre : AIAction
    {
        [SerializeField]
        private TMP_Text contadorMonedasText;

        private int contadorMonedas;

        // Este método se llama cuando la acción debe ejecutarse
        public override void PerformAction()
        {
            // Supongamos que ganas 10 monedas por cada enemigo muerto
            int monedasGanadas = 10;

            // Aumenta el contador de monedas
            contadorMonedas += monedasGanadas;

            // Actualiza el texto del contador en el UI (si lo tienes)
            if (contadorMonedasText != null)
            {
                contadorMonedasText.text = "Monedas: " + contadorMonedas;
            }
        }
    }

