// using System.Data;
using PA_Library;
namespace SM
{
    interface IStateDelete
    {
         void DeletePACount(PANumber number);

        // PANumber Delete(PANumber number);
        // void Delete(PANumber number);
        void DeletePAData(PAResource count);
        void DeletePAElement(PAData Data, PAStatus Status);

        void DeletePAInput(PACount N, PACount M, PAList ADJ, PAElement Source);
        void DeletePALink(PAPair Pair);

        void DeletePAList(PACount N, PASeries[] series);
        void DeletePANormalTree(PATree Tree);

        void DeletePANumber(int value);
        // void Delete(PANumber number);
        void DeletePAOutput(BFSRecord Record);
        // void Delete(PAResource resource);
        void DeletePAPair(PAElement Node, PAElement Neigh);
        void DeletePAResource(PANumber Value);

        void DeletePASeries(PACount M, PAElement[] ADJ);

        void DeletePAStatus(PAResource Resource);

        void DeletePATransposeTree(PATree tree);

        void    PATree(PACount N, PACount M, PASeries Series, PAElement Element);
        // void     (PANode node);
    }
}