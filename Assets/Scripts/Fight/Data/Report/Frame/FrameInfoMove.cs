using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameInfoMove : FrameInfoBase
{
    public FrameInfoMove(int startFrame, int duration) : base(startFrame, duration)
    {
    }
   
    public override string ActionToString 
    {
        get 
        {
            string moveType = this.MoveType == MoveType.JumpTo ? "����" : "�ص�";
            return $"��ɫ��{this.RoleUid}�� ��λ�á�{StartNodePos.ToString()}��{moveType}��{EndNodePos.ToString()}��   �ڡ�{EndFrame}��֡������";
        }
    } 

    public override FrameType FrameType => FrameType.Move;

    public int RoleUid { get; private set; }
    public Vector2 StartNodePos { get; private set; }
    public Vector2 EndNodePos { get; private set; }

    public MoveType MoveType { get; private set; }

    public void SetInfo(int roleUid,Vector2 startNodePos,Vector2 endNodePos,MoveType moveType) 
    {
        this.RoleUid        = roleUid;
        this.StartNodePos   = startNodePos;
        this.EndNodePos     = endNodePos;
        this.MoveType       = moveType;
    }
}
