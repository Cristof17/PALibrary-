 using PA_Library;
 namespace SM 
 {
    internal interface IStateFinish 
    {
        void IStateFinishPACount(PACount PA);
        // PANumber Finish(PANumber number);
        // void Finish(PANumber number);
        // void IStateFinishPAData(PACount PA);
        void IStateFinishPAData(PAData PA);
        void IStateFinishPAElement(PAElement PA);

        void IStateFinishPAInput(PAInput PA);
        void FinishPALink(PALink PA);

        void IStateFinishPAList(PAList PA);
        void IStateFinishPANormalTree(PANormalTree Tree);

        void IStateFinishPANumber(PANumber PA);
        // void Finish(PANumber number);
        void IStateFinishPAOutput(PAOutput PA);
        // void Finish(PAResource resource);
        void IStateFinishPAPair(PAPair PA);
        void IStateFinishPAResource(PAResource PA);

        void IStateFinishPASeries(PASeries PA);

        void IStateFinishPAStatus(PAStatus PA);

        void IStateFinishPATransposeTree(PATransposeTree PA);

        void IStateFinishPATree(PATree PA);
    }
 }