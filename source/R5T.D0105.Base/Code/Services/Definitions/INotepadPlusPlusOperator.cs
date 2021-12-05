using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0105
{
    [ServiceDefinitionMarker]
    public interface INotepadPlusPlusOperator : IServiceDefinition
    {
        Task OpenFilePath(string filePath);
    }
}