using System.Reflection;
using PA_Library;
namespace SM
{
    interface StateConstruct : StateInitialise
    {
        void Initialise(PANumber number);
        void Initialise(PACount count);
        void Initialise(PAResource resource);

        void Initialise(PAElement element);
        void Initialise(PAInput input);

        void Initialise(PALink link);
        void Initialise(PAList list);

        void Initialise(PANormalTree normalTree);
        // void Initialise(PANumber number);
        void Initialise(PAPair number);
        // void Initialise(PAResource resource);
        void Initialise(PAResult series);
        void Initialise(PASeries series);

        void Initialise(PAStatus status);

        void Initialise(PATransposeTree transposeTree);

        void Initialise(PATree tree);
        // void Initialise(PANode node);
    }
}