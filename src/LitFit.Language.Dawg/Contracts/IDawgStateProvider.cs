namespace LitFit.Language.Dawg
{
    public interface IDawgStateProvider
    {
        IDawgStateWriter CreateWriter(in int nodeCount, in int symbolCount);
        IDawgState CreateState();
    }
}