using PA_Library;
using PA;
using BFS;
namespace SM
{
    internal interface IStateInitialise
    {
        PANumber IStateInitialisePACount(PANumber number);

        // PANumber Initialise(PANumber number);
        // void Initialise(PANumber number);
        PAData IStateInitialisePAData(PAResource count);
        PAElement IStateInitialisePAElement(PAData Data, PAStatus Status);

        PAInput IStateInitialisePAInput(PACount N, PACount M, PAList ADJ, PAElement Source);
        PALink IStateInitialisePALink(PAPair Pair);

        PAList IStateInitialisePAList(PACount N, PASeries[] series);
        PANormalTree IStateInitialisePANormalTree(PATree Tree);

        PANumber IStateInitialisePANumber(int value);
        // void Initialise(PANumber number);
        PAOutput IStateInitialisePAOutput(BFSRecord Record);
        // void Initialise(PAResource resource);
        PAPair IStateInitialisePAPair(PAElement Node, PAElement Neigh);
        PAResource IStateInitialisePAResource(PANumber Value);

        PASeries IStateInitialisePASeries(PACount M, PAElement[] ADJ);

        PAStatus IStateInitialisePAStatus(PAResource Resource);

        PATransposeTree IStateInitialisePATransposeTree(PATree tree);

        PATree IStateInitialisePATree(PACount N, PACount M, PASeries Series, PAElement Element);
        // void     (PANode node);
    }
}