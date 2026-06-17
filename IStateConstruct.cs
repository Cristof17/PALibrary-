using System.Reflection;
using PA_Library;
namespace SM
{
    interface IStateConstruct
    {
        PACount ConstructPACount(PANumber number);

        // PANumber Construct(PANumber number);
        // void Construct(PANumber number);
        void ConstructPAData(PACount count);
        void ConstructPAElement(PAResource resource);

        void ConstructPAInput(PAElement element);
        void ConstructPALink(PAInput input);

        void ConstructPAList(PALink link);
        void ConstructPANormalTree(PAList list);

        void ConstructPANumber(PANormalTree normalTree);
        // void Construct(PANumber number);
        void ConstructPAOutput(PAPair number);
        // void Construct(PAResource resource);
        void ConstructPAPair(PAResult series);
        void ConstructPAResource(PASeries series);

        void ConstructPASeries(PAStatus status);

        void ConstructPAStatus(PATransposeTree transposeTree);

        void ConstructPATransposeTree(PATree tree);
        void ConstructPATree(PATree tree);
        // void     (PANode node);
    }
}