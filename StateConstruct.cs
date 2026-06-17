using System.Reflection;
using PA_Library;
namespace SM
{
    interface IStateConstruct
    {
        void IStateConstruct(PANumber number);
        void IStateConstruct(PACount count);
        void IStateConstruct(PAResource resource);

        void IStateConstruct(PAElement element);
        void IStateConstruct(PAInput input);

        void IStateConstruct(PALink link);
        void IStateConstruct(PAList list);

        void IStateConstruct(PANormalTree normalTree);
        // void Construct(PANumber number);
        void IStateConstruct(PAPair number);
        // void Construct(PAResource resource);
        void IStateConstruct(PAResult series);
        void IStateConstruct(PASeries series);

        void IStateConstruct(PAStatus status);

        void IStateConstruct(PATransposeTree transposeTree);

        void IStateConstruct(PATree tree);
        // void     (PANode node);
    }
}