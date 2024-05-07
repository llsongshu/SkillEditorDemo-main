
public class FrameInfoRoundEnd : FrameInfoBase
{
    public FrameInfoRoundEnd(int startFrame) : base(startFrame)
    {
    }

    public override string ActionToString => $"��ɫ��{RoleUid}���ļ��ܡ�{SkillId}��С�غϽ�����";

    public override FrameType FrameType => FrameType.RoundEnd;

    public int SkillId { get; private set; }
    public int RoleUid { get; private set; }
    public void SetInfo(int skillId, int roleUid) 
    {
        this.SkillId = skillId;
        this.RoleUid = roleUid;
    }
}
