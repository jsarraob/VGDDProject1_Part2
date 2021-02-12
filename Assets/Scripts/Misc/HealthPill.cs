using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPill : MonoBehaviour
{
   #region Editor Variables
   [SerializeField]
   [Tooltip("the amount of health a pill restores")]
   private int m_HealthGain;
   public int HealthGain
   {
       get
       {
           return m_HealthGain;
       }
   }
   #endregion
}
