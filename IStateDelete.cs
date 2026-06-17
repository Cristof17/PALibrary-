// using System.Data;
using PA_Library;
namespace SM
{
    internal interface IStateDelete
    {
         void IStateDeletePACount(PANumber number);

        // PANumber Delete(PANumber number);
        // void Delete(PANumber number);
        void IStateDeletePAData(PAResource count);
        void IStateDeletePAElement(PAData Data, PAStatus Status);

        void IStateDeletePAInput(PACount N, PACount M, PAList ADJ, PAElement Source);
        void IStateDeletePALink(PAPair Pair);

        void IStateDeletePAList(PACount N, PASeries[] series);
        void IStateDeletePANormalTree(PATree Tree);

        void IStateDeletePANumber(int value);
        // void Delete(PANumber number);
        void IStateDeletePAOutput(BFSRecord Record);
        // void Delete(PAResource resource);
        void IStateDeletePAPair(PAElement Node, PAElement Neigh);
        void IStateDeletePAResource(PANumber Value);

        void IStateDeletePASeries(PACount M, PAElement[] ADJ);

        void IStateDeletePAStatus(PAResource Resource);

        void IStateDeletePATransposeTree(PATree tree);

        void IStatePATree(PACount N, PACount M, PASeries Series, PAElement Element);
        // void     (PANode node);
    }
}