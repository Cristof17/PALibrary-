using PA_Library;
namespace SM
{
    interface IStateFinish
    {
        void Finish(PANumber number);
        void Finish(PACount count);
        void Finish(PAResource resource);

        void Finish(PAElement element);
        void Finish(PAInput input);

        void Finish(PALink link);
        void Finish(PAList list);

        void Finish(PANormalTree normalTree);
        // void Finish(PANumber number);
        void Finish(PAPair number);
        // void Finish(PAResource resource);
        void Finish(PAResult series);
        void Finish(PASeries series);

        void Finish(PAStatus status);

        void Finish(PATransposeTree transposeTree);

        void Finish(PATree tree);
        // void     (PANode node);
    }
}