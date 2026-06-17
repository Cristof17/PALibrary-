// using System.Data;
using PA_Library;
namespace SM
{
    internal interface IStateDelete
    {
        PACount IStateDeletePACount(PANumber number);

        // PANumber Delete(PANumber number);
        // void Delete(PANumber number);
        PAData IStateDeletePAData(PAResource count);
        PAElement IStateDeletePAElement(PAData Data, PAStatus Status);

        PAInput IStateDeletePAInput(PACount N, PACount M, PAList ADJ, PAElement Source);
        PALink IStateDeletePALink(PAPair Pair);

        PAList IStateDeletePAList(PACount N, PASeries[] series);
        PANormalTree IStateDeletePANormalTree(PATree Tree);

        PANumber IStateDeletePANumber(int value);
        // void Delete(PANumber number);
        PAOutput IStateDeletePAOutput(BFSRecord Record);
        // void Delete(PAResource resource);
        PAPair IStateDeletePAPair(PAElement Node, PAElement Neigh);
        PAResource IStateDeletePAResource(PANumber Value);

        PASeries IStateDeletePASeries(PACount M, PAElement[] ADJ);

        PAStatus IStateDeletePAStatus(PAResource Resource);

        PATransposeTree IStateDeletePATransposeTree(PATree tree);

        PATree IStatePATree(PACount N, PACount M, PASeries Series, PAElement Element);
        // void     (PANode node);
    }
}