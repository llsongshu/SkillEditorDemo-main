
public class FightStatePreloadRender : FightStateBase
{
    public override void Enter()
    {
        //���ü���ս������ɫ��Ԥ����ս����Ч���������֮���˳���״̬
        ChangeState(FightState.RenderJumpIn);
    }
    
}
