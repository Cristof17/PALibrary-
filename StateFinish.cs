 using PA_Library;
 namespace SM 
 {
    interface IStateFinish 
    {
        void FinishPACount(PANumber number);
        // PANumber Finish(PANumber number);
        // void Finish(PANumber number);
        void FinishPAData(PAResource count);
        void FinishPAElement(PAData Data, PAStatus Status);

        void FinishPAInput(PACount N, PACount M, PAList ADJ, PAElement Source);
        void FinishPALink(PAPair Pair);

        void FinishPAList(PACount N, PASeries[] series);
        void FinishPANormalTree(PATree Tree);

        void FinishPANumber(int value);
        // void Finish(PANumber number);
        void FinishPAOutput(BFSRecord Record);
        // void Finish(PAResource resource);
        void FinishPAPair(PAElement Node, PAElement Neigh);
        void FinishPAResource(PANumber Value);

        void FinishPASeries(PACount M, PAElement[] ADJ);

        void FinishPAStatus(PAResource Resource);

        void FinishPATransposeTree(PATree tree);

        void FinishPATree(PACount N, PACount M, PASeries Series, PAElement Element);

    }
 }