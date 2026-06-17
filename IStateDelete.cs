// using System.Data;
using PA_Library;
namespace SM
{
    interface IStateDelete : IStateDelete
    {
        void Delete(PANumber number);
        void Delete(PACount count);
        void Delete(PAResource resource);

        void Delete(PAElement element);
        void Delete(PAInput input);

        void Delete(PALink link);
        void Delete(PAList list);

        void Delete(PANormalTree normalTree);
        // void Delete(PANumber number);
        void Delete(PAPair number);
        // void Delete(PAResource resource);
        void Delete(PAResult series);
        void Delete(PASeries series);

        void Delete(PAStatus status);

        void Delete(PATransposeTree transposeTree);

        void Delete(PATree tree);
        // void     (PANode node);
    }
}