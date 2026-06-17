using System.Reflection;
using PA_Library;
namespace SM
{
    interface IStateConstruct
    {
        PACount ConstructPACount(PANumber number);

        // PANumber Construct(PANumber number);
        // void Construct(PANumber number);
        void ConstructPAData(PAResource count);
        void ConstructPAElement(PAData Data, PAStatus Status);

        void ConstructPAInput(PACount N, PACount M, PAList ADJ, PAElement Source);
        void ConstructPALink(PAPair Pair);

        void ConstructPAList(PACount N, PASeries[] series);
        void ConstructPANormalTree(PATree Tree);

        void ConstructPANumber(int value);
        // void Construct(PANumber number);
        void ConstructPAOutput(BFSRecord Record);
        // void Construct(PAResource resource);
        void ConstructPAPair(PAElement Node, PAElement Neigh);
        void ConstructPAResource(PANumber Value);

        void ConstructPASeries(PACount M, PAElement[] ADJ);

        void ConstructPAStatus(PAResource Resource);

        void ConstructPATransposeTree(PATree tree);

        void ConstructPATree(PACount N, PACount M, PASeries Series, PAElement Element);
        // void     (PANode node);
    }
}