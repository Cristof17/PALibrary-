using PA_Library;
namespace SM
{
    internal interface IStateInitialise
    {
         void IStateInitialisePACount(PANumber number);

        // PANumber Initialise(PANumber number);
        // void Initialise(PANumber number);
        void IStateInitialisePAData(PAResource count);
        void IStateInitialisePAElement(PAData Data, PAStatus Status);

        void IStateInitialisePAInput(PACount N, PACount M, PAList ADJ, PAElement Source);
        void IStateInitialisePALink(PAPair Pair);

        void IStateInitialisePAList(PACount N, PASeries[] series);
        void IStateInitialisePANormalTree(PATree Tree);

        void IStateInitialisePANumber(int value);
        // void Initialise(PANumber number);
        void IStateInitialisePAOutput(BFSRecord Record);
        // void Initialise(PAResource resource);
        void IStateInitialisePAPair(PAElement Node, PAElement Neigh);
        void IStateInitialisePAResource(PANumber Value);

        void IStateInitialisePASeries(PACount M, PAElement[] ADJ);

        void IStateInitialisePAStatus(PAResource Resource);

        void IStateInitialisePATransposeTree(PATree tree);

        void IStateInitialisePATree(PACount N, PACount M, PASeries Series, PAElement Element);
        // void     (PANode node);
    }
}