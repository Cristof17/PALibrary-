using System.Reflection;
using PA_Library;
namespace SM
{
    interface IStateConstruct
    {
        PACount ConstructPACount(PANumber number);

        // PANumber Construct(PANumber number);
        // void Construct(PANumber number);
        void IStateConstructPAData(PAResource count);
        void IStateConstructPAElement(PAData Data, PAStatus Status);

        void IStateConstructPAInput(PACount N, PACount M, PAList ADJ, PAElement Source);
        void IStateConstructPALink(PAPair Pair);

        void IStateConstructPAList(PACount N, PASeries[] series);
        void IStateConstructPANormalTree(PATree Tree);

        void IStateConstructPANumber(int value);
        // void Construct(PANumber number);
        void IStateConstructPAOutput(BFSRecord Record);
        // void Construct(PAResource resource);
        void IStateConstructPAPair(PAElement Node, PAElement Neigh);
        void IStateConstructPAResource(PANumber Value);

        void IStateConstructPASeries(PACount M, PAElement[] ADJ);

        void IStateConstructPAStatus(PAResource Resource);

        void IStateConstructPATransposeTree(PATree tree);

        void IStateConstructPATree(PACount N, PACount M, PASeries Series, PAElement Element);
        // void     (PANode node);
    }
}