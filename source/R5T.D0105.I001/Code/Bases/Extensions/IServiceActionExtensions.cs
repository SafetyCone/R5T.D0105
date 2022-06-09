using System;

using R5T.D0075;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0105.I001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="NotepadPlusPlusOperator"/> implementation of <see cref="INotepadPlusPlusOperator"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<INotepadPlusPlusOperator> AddNotepadPlusPlusOperatorAction(this IServiceAction _,
            IServiceAction<ICommandLineOperator> commandLineOperatorAction,
            IServiceAction<INotepadPlusPlusExecutableFilePathProvider> notepadPlusPlusExecutableFilePathProviderAction)
        {
            var serviceAction = _.New<INotepadPlusPlusOperator>(services => services.AddNotepadPlusPlusOperator(
                commandLineOperatorAction,
                notepadPlusPlusExecutableFilePathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="HardCodedNotepadPlusPlusExecutableFilePathProvider"/> implementation of <see cref="INotepadPlusPlusExecutableFilePathProvider"/> as a <see cref="Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<INotepadPlusPlusExecutableFilePathProvider> AddHardCodedNotepadPlusPlusExecutableFilePathProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<INotepadPlusPlusExecutableFilePathProvider>(services => services.AddHardCodedNotepadPlusPlusExecutableFilePathProvider());
            return serviceAction;
        }
    }
}
