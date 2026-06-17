 using PA_Library;
 namespace SM 
 {
    internal interface IStateFinish 
    {
        void IStateFinishPACount(PANumber number);
        // PANumber Finish(PANumber number);
        // void Finish(PANumber number);
        void IStateFinishPAData(PAResource count);
        void IStateFinishPAElement(PAData Data, PAStatus Status);

        void IStateFinishPAInput(PACount N, PACount M, PAList ADJ, PAElement Source);
        void FinishPALink(PAPair Pair);

        void IStateFinishPAList(PACount N, PASeries[] series);
        void IStateFinishPANormalTree(PATree Tree);

        void IStateFinishPANumber(int value);
        // void Finish(PANumber number);
        void IStateFinishPAOutput(BFSRecord Record);
        // void Finish(PAResource resource);
        void IStateFinishPAPair(PAElement Node, PAElement Neigh);
        void IStateFinishPAResource(PANumber Value);

        void IStateFinishPASeries(PACount M, PAElement[] ADJ);

        void IStateFinishPAStatus(PAResource Resource);

        void IStateFinishPATransposeTree(PATree tree);

        void IStateFinishPATree(PACount N, PACount M, PASeries Series, PAElement Element);
    }
 }