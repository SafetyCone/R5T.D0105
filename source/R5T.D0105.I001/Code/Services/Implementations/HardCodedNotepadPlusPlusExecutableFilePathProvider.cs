using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0105.I001
{
    [ServiceImplementationMarker]
    public class HardCodedNotepadPlusPlusExecutableFilePathProvider : INotepadPlusPlusExecutableFilePathProvider, IServiceImplementation
    {
        public const string NotepadPlusPlusExecutableFilePath = @"C:\Program Files (x86)\Notepad++\notepad++.exe";


        public Task<string> GetNotepadPlusPlusExecutableFilePath()
        {
            var output = StringHelper.Enquote(HardCodedNotepadPlusPlusExecutableFilePathProvider.NotepadPlusPlusExecutableFilePath);

            return Task.FromResult(output);
        }
    }
}
