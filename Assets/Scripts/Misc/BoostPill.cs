using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPill : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("The amount of health that this pill restores")]
    private int m_HealthGain;
    public int HealthGain {
        get {
            return m_HealthGain;
        }
    }

    [SerializeField]
    [Tooltip("The amount of health that this pill restores")]
    private int m_SpeedGain;
    public int SpeedGain {
        get {
            return m_SpeedGain;
        }
    }
    #endregion
}
