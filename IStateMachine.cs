using System.Xml.Serialization;
using PA_Library;
using SM;
interface IStateMachine : IStateConstruct, StateInitialise, IStateDelete, IStateFinish
{
    
}