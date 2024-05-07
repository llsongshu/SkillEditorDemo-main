using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightConst 
{
    public static FrameLogType FrameLogType = FrameLogType.Show;
    public static int RoundInterval = 10;
}

public enum FrameType 
{
    Move        = 1,
    Damage      = 2,
    Anim        = 3,
    Art         = 4,
    Sound       = 5,
    RoundEnd    = 6,
}

public enum RoleType 
{
    Hero    = 1,
    Pet     = 2
}

public enum CampType
{
    Atker       = 1,//������
    Defender    = 2//���ط�
}

public enum FightState
{
    PrepareData     = 1,//׼�����ݣ����Խ׶μ������ݣ���ʵ�׶���������
    PreloadRender   = 2,//���س�������ɫģ�ͣ�Ԥ������Ч
    RenderJumpIn    = 3,//render��ɫ����
    ShowUi          = 4,//չʾui
    InFight         = 5,//��ʵ��ս���߼���
    FightEnd        = 6,//ս������
}

public enum FightTick 
{
    Strategy    = 1,
    Play        = 2,
}
public enum Result 
{
    None        = 0,
    AtkerWin    = 1,
    DefenderWin = 2,
    Draw        = 3,
}

public enum ResultCheck 
{
    RoleDie = 0,
    TimeOut = 1,
}

public enum DamageType 
{
    Pure = 0,
    Cure = 1,
}

public enum MoveType 
{
    JumpTo = 1,
    Back   = 2,
}

public enum FrameLogType 
{
    None    = 0,
    Logic   = 1,
    Show  = 2,
}

public enum MoveTargetType 
{
    Front = 0,
    Back = 1,
}

public enum SkillActionType 
{
    Move = 1,
    Damage = 2,
    Anim = 3,
    Art = 4,
    Sound = 5,
}