using System.Xml.Serialization;
using SM;
interface StateMachine : StateConstruct, StateInitialise, StateDelete, StateFinish
{
    void Construct();
}