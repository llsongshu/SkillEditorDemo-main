
public class FightStateRenderJumpIn : FightStateBase
{
    public override void Enter()
    {
        //����render���ɫ���붯����ִ����ɺ��л�ui
        this.ChangeState(FightState.ShowUi);
    }
}
