

public class FrameInfoArt : FrameInfoBase
{
    //��������������Ч,durationFrame��Ϊ-1��ʱ�����Զ����٣��ڼ��ܻغϽ���ʱ��Destroy��Ϊ-1��ʱ����߼���������
    public FrameInfoArt(int startFrame, int duration) : base(startFrame, duration)
    {
    }

    public override string ActionToString 
    {
        get 
        {
            string addDes = this.IsRemove ? "�Ƴ�" : "���";
            if (!this.IsRemove)
                return $"��ɫ��{this.RoleUid}��{addDes}����Ч��{this.ArtName}�� ����ʱ��Ϊ��{this.EndFrame}��";
            else
                return $"��ɫ��{this.RoleUid}��{addDes}����Ч��{this.ArtName}�� ";
        }
    }

    public override FrameType FrameType => FrameType.Art;

    public int RoleUid { get; private set; }
    public bool IsRemove { get; private set; }
    public string ArtName { get; private set; }
    public void SetInfo(int roleUid, bool isRemove,string artName) 
    {
        this.RoleUid = roleUid;
        this.IsRemove = isRemove;
        this.ArtName = artName;
    }

}
