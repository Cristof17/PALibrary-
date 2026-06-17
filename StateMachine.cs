using System.Xml.Serialization;
using PA_Library;
using SM;
interface StateMachine : StateConstruct
{
        void Construct(PANumber number);
        void Construct(PACount count);
        void Construct(PAResource resource);

        void Construct(PAElement element);
        void Construct(PAInput input);

        void Construct(PALink link);
        void Construct(PAList list);

        void Construct(PANormalTree normalTree);
        // void Construct(PANumber number);
        void Construct(PAPair number);
        // void Construct(PAResource resource);
        void Construct(PAResult series);
        void Construct(PASeries series);

        void Construct(PAStatus status);

        void Construct(PATransposeTree transposeTree);

        void Construct(PATree tree);
}