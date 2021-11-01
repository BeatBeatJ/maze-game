using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTowardsMomentum : MonoBehaviour
{
    public Vector3 LastMomentum;

   private void Update()
   {
       if (CharacterMotor.Instance.MoveVector.x != 0 || CharacterMotor.Instance.MoveVector.z != 0) LastMomentum = new Vector3(CharacterMotor.Instance.MoveVector.x,0,CharacterMotor.Instance.MoveVector.z);
       transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(LastMomentum), 0.15F);
   }
}
