using PA_Library;
namespace SM
{
    interface StateInitialise : IStateDelete
    {
         void InitialisePACount(PANumber number);

        // PANumber Initialise(PANumber number);
        // void Initialise(PANumber number);
        void InitialisePAData(PAResource count);
        void InitialisePAElement(PAData Data, PAStatus Status);

        void InitialisePAInput(PACount N, PACount M, PAList ADJ, PAElement Source);
        void InitialisePALink(PAPair Pair);

        void InitialisePAList(PACount N, PASeries[] series);
        void InitialisePANormalTree(PATree Tree);

        void InitialisePANumber(int value);
        // void Initialise(PANumber number);
        void InitialisePAOutput(BFSRecord Record);
        // void Initialise(PAResource resource);
        void InitialisePAPair(PAElement Node, PAElement Neigh);
        void InitialisePAResource(PANumber Value);

        void InitialisePASeries(PACount M, PAElement[] ADJ);

        void InitialisePAStatus(PAResource Resource);

        void InitialisePATransposeTree(PATree tree);

        void InitialisePATree(PACount N, PACount M, PASeries Series, PAElement Element);
        // void     (PANode node);
    }
}