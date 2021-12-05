using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0075;
using R5T.T0063;


namespace R5T.D0105.I001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="NotepadPlusPlusOperator"/> implementation of <see cref="INotepadPlusPlusOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddNotepadPlusPlusOperator(this IServiceCollection services,
            IServiceAction<ICommandLineOperator> commandLineOperatorAction,
            IServiceAction<INotepadPlusPlusExecutableFilePathProvider> notepadPlusPlusExecutableFilePathProviderAction)
        {
            services
                .Run(commandLineOperatorAction)
                .Run(notepadPlusPlusExecutableFilePathProviderAction)
                .AddSingleton<INotepadPlusPlusOperator, NotepadPlusPlusOperator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="HardCodedNotepadPlusPlusExecutableFilePathProvider"/> implementation of <see cref="INotepadPlusPlusExecutableFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddHardCodedNotepadPlusPlusExecutableFilePathProvider(this IServiceCollection services)
        {
            services.AddSingleton<INotepadPlusPlusExecutableFilePathProvider, HardCodedNotepadPlusPlusExecutableFilePathProvider>();

            return services;
        }
    }
}