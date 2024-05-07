using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameInfoDamage : FrameInfoBase
{
    public FrameInfoDamage(int startFrame) : base(startFrame)
    {
    }

    public override string ActionToString 
    {
        get 
        {
            if (this.IsCrit)
                return $"��ɫ��{this.RoleUid}�����������˺�����Ϊ��{this.DamageType.ToString()}��    �˺�ֵΪ��{this.DamageValue}��";
            else if (this.IsMiss)
                return $"��ɫ��{this.RoleUid}��Miss���˺����˺�����Ϊ��{this.DamageType.ToString()}��";
            else
                return $"��ɫ��{this.RoleUid}���ܵ����˺����˺�����Ϊ��{this.DamageType.ToString()}��    �˺�ֵΪ��{this.DamageValue}��";

        }
    } 

    public override FrameType FrameType => FrameType.Damage;

    public int RoleUid { get; private set; }
    public int DamageValue { get; private set; }
    public bool IsCrit { get; private set; }
    public bool IsMiss { get; private set; }
    public DamageType DamageType { get; private set; }
    public void SetInfo(int roleUid,int damageValue,bool isCrit,bool isMiss,DamageType damageType) 
    {
        this.RoleUid        = roleUid;
        this.DamageValue    = damageValue;
        this.IsCrit         = isCrit;
        this.IsMiss         = isMiss;
        this.DamageType     = damageType;
    }
}
