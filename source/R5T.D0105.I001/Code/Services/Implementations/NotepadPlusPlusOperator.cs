using System;
using System.Threading.Tasks;

using R5T.D0075;
using R5T.T0064;


namespace R5T.D0105.I001
{
    [ServiceImplementationMarker]
    public class NotepadPlusPlusOperator : INotepadPlusPlusOperator, IServiceImplementation
    {
        private ICommandLineOperator CommandLineOperator { get; }
        private INotepadPlusPlusExecutableFilePathProvider NotepadPlusPlusExecutableFilePathProvider { get; }


        public NotepadPlusPlusOperator(
            ICommandLineOperator commandLineOperator,
            INotepadPlusPlusExecutableFilePathProvider notepadPlusPlusExecutableFilePathProvider)
        {
            this.CommandLineOperator = commandLineOperator;
            this.NotepadPlusPlusExecutableFilePathProvider = notepadPlusPlusExecutableFilePathProvider;
        }

        public async Task OpenFilePath(string filePath)
        {
            var notepadPlusPlusExecutableFilePath = await this.NotepadPlusPlusExecutableFilePathProvider.GetNotepadPlusPlusExecutableFilePath();

            var enquotedFilePath = StringHelper.Enquote(filePath);

            await this.CommandLineOperator.Run(notepadPlusPlusExecutableFilePath, enquotedFilePath);
        }
    }
}
